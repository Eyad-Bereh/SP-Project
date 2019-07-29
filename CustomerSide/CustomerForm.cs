using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.IO;
using System.Net;
using System.Net.Sockets;
using CardOperations;

namespace ClientSide
{
    public partial class CustomerForm : Form
    {
        private const string ConnectionString = @"server=127.0.0.1;uid=root;database=smartcardsystem";
        private TcpClient C;
        private NetworkStream NS;
        private StreamReader SR;
        private StreamWriter SW;

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Card.MySQLConnection = new MySqlConnection(ConnectionString);
            try
            {
                Card.MySQLConnection.Open();
            }
            catch (MySqlException Ex)
            {
                string ErrorMessage = "The following error has occured: \n";

                switch (Ex.Number)
                {
                    case 0:
                    case 1042:
                        ErrorMessage += "The connection to MySQL server has failed.\n";
                        ErrorMessage += "Maybe the server is down.\n";
                        break;

                    case 1044:
                    case 1045:
                        ErrorMessage += "Acces denied.\n";
                        ErrorMessage += "Maybe because invalid username or password were supplied.\n";
                        break;

                    default:
                        ErrorMessage += (Ex.Number) + ": " + (Ex.Message) + "\n";
                        break;
                }

                ErrorMessage += "Due to this, the program will now terminate itself.";
                MessageBox.Show(ErrorMessage, "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            Control.CheckForIllegalCrossThreadCalls = false;
            C = new TcpClient();
        }

        private void TabsControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = "Online Smart Card System - " + this.TabsControl.SelectedTab.Text;
        }

        private void EnquiryButton_Click(object sender, EventArgs e)
        {
            if (!C.Connected)
            {
                ConnectClient();
            }
            string CardNumber = this.CardNumberEnquiry.Text;

            if (!Card.IsValidCardNumber(CardNumber))
            {
                this.EnquiryMessage.ForeColor = Color.Red;
                this.EnquiryMessage.Text = "Invalid card number format.";
                this.EnquiryMessage.Visible = true;
                this.EnquiryInformationPanel.Visible = false;
                return;
            }

            SW.WriteLine("Action=CardExist;CardNumber=" + CardNumber + ";");
            SW.Flush();

            bool CardExist = Convert.ToBoolean(SR.ReadLine().Split('=')[1].Split(';')[0]);

            if (!CardExist)
            {
                this.EnquiryMessage.ForeColor = Color.Red;
                this.EnquiryMessage.Text = "No such card exist.";
                this.EnquiryMessage.Visible = true;
                this.EnquiryInformationPanel.Visible = false;
                return;
            }

            SW.WriteLine("Action=Enquiry;CardNumber=" + CardNumber);
            SW.Flush();
            
            string[] Temp = SR.ReadLine().Split(';');
            string[] KeyValue = new string[4];
            for (int i = 0; i < 4; i++)
            {
                KeyValue[i] = Temp[i].Split('=')[1];
            }
            

            this.CardNumberEnquiryLabel.Text = KeyValue[0];
            this.CarNumberEnquiryLabel.Text = KeyValue[1];
            this.CurrentConsumptionEnquiryLabel.Text = KeyValue[2];
            this.MonthlyLimitEnquiryLabel.Text = KeyValue[3];

            this.EnquiryMessage.ForeColor = Color.Green;
            this.EnquiryMessage.Text = "Card has been queried successfully.";
            this.EnquiryMessage.Visible = true;
            this.EnquiryInformationPanel.Visible = true;   
        }

        private void ConsumeButton_Click(object sender, EventArgs e)
        {
            if (!C.Connected)
            {
                ConnectClient();
            }
            string CardNumber = this.CardNumberFill.Text;
            if (!Card.IsValidCardNumber(CardNumber))
            {
                this.FillMessage.ForeColor = Color.Red;
                this.FillMessage.Text = "Invalid card number format.";
                this.FillMessage.Visible = true;
                this.FillInformationPanel.Visible = false;
                return;
            }

            SW.WriteLine("Action=CardExist;CardNumber=" + CardNumber + ";");
            SW.Flush();

            bool CardExist = Convert.ToBoolean(SR.ReadLine().Split('=')[1].Split(';')[0]);

            if (!CardExist)
            {
                this.FillMessage.ForeColor = Color.Red;
                this.FillMessage.Text = "No such card exist.";
                this.FillMessage.Visible = true;
                this.FillInformationPanel.Visible = false;
                return;
            }

            string ConsumptionAmount = this.ConsumptionAmount.Text;
            if (!Card.IsValidConsumptionAmount(ConsumptionAmount))
            {
                this.FillMessage.ForeColor = Color.Red;
                this.FillMessage.Text = "Invalid consumption amount was supplied.\nMust be a positive value.";
                this.FillMessage.Visible = true;
                this.FillInformationPanel.Visible = false;
                return;
            }

            SW.WriteLine("Action=CanCustomerRefill;CardNumber=" + CardNumber + ";Quantity=" + ConsumptionAmount);
            SW.Flush();

            bool CanCustomerRefill = Convert.ToBoolean(SR.ReadLine().Split('=')[1].Split(';')[0]);
            if (!CanCustomerRefill)
            {
                this.FillMessage.ForeColor = Color.Red;
                this.FillMessage.Text = "Insufficient supplies.";
                this.FillMessage.Visible = true;
                this.FillInformationPanel.Visible = false;
                return;
            }

            SW.WriteLine("Action=ConsumeFuel;CardNumber=" + CardNumber + ";Quantity=" + ConsumptionAmount);
            SW.Flush();

            string Message = SR.ReadLine();

            try
            {
                string temp = Message;
                temp = temp.Split('=')[0];
                if (temp == "Error")
                {
                    this.FillMessage.ForeColor = Color.Red;
                    this.FillMessage.Text = temp.Split('=')[1].Split(';')[0];
                    this.FillMessage.Visible = true;
                    this.FillInformationPanel.Visible = false;
                    return;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            
            string[] Temp = Message.Split(';');
            string[] KeyValue = new string[7];
            for (int i = 0; i < 7; i++)
            {
                KeyValue[i] = Temp[i].Split('=')[1];
            }

            this.CardNumberFillLabel.Text = KeyValue[0];
            this.CarNumberFillLabel.Text = KeyValue[1];
            this.MonthlyLimitFillLabel.Text = KeyValue[3];
            this.RemainingFuelFillLabel.Text = KeyValue[6];
            this.CurrentConsumptionFillLabel.Text = KeyValue[2];
            this.LastConsumptionFillLabel.Text = KeyValue[4];
            this.DateFillLabel.Text = new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(Convert.ToInt32(KeyValue[5])).ToString();
            

            this.FillMessage.ForeColor = Color.Green;
            this.FillMessage.Text = "Card has been queried successfully.";
            this.FillMessage.Visible = true;
            this.FillInformationPanel.Visible = true;
        }

        private void ConnectClient()
        {
            if (!C.Connected)
            {
                C.Connect("127.0.0.1", 8512);
                NS = C.GetStream();
                SR = new StreamReader(NS);
                SW = new StreamWriter(NS);
            }
        }
    }
}
