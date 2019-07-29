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

namespace StationSide
{
    public partial class StationForm : Form
    {
        private const string ConnectionString = @"server=127.0.0.1;uid=root;database=smartcardsystem";
        private TcpClient C;
        private NetworkStream NS;
        private StreamReader SR;
        private StreamWriter SW;

        public StationForm()
        {
            InitializeComponent();
        }

        private void TabsControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Add_CardNumber.Text = "";
            this.Add_CarNumber.Text = "";
            this.Add_MonthlyLimit.Text = "";
            this.Add_CardNumberLabel.Text = "";
            this.Add_CarNumberLabel.Text = "";
            this.Add_MonthlyLimitLabel.Text = "";
            this.AddCardMessage.Text = "";

            this.Remove_CardNumber.Text = "";
            this.Remove_CardNumberLabel.Text = "";
            this.RemoveCardMessage.Text = "";

            this.Update_CardNumber.Text = "";
            this.Update_CardNumberLabel.Text = "";
            this.UpdateCardPanel.Visible = false;

            this.Text = "Online Smart Card System - " + this.TabsControl.SelectedTab.Text;
        }

        private void AddCardButton_Click(object sender, EventArgs e)
        {
            if (!C.Connected)
            {
                ConnectClient();
            }

            string CardNumber = this.Add_CardNumber.Text;
            SW.WriteLine("Action=CardExist;CardNumber=" + CardNumber + ";");
            SW.Flush();

            bool CardExist = Convert.ToBoolean(SR.ReadLine().Split('=')[1].Split(';')[0]);

            if (CardExist)
            {
                this.Add_CardNumberLabel.ForeColor = Color.Red;
                this.Add_CardNumberLabel.Text = "A card with same number already exist.";
                this.Add_CardNumberLabel.Visible = true;
                this.AddCardMessage.Visible = false;
                return;
            }

            if (!Card.IsValidCardNumber(CardNumber))
            {
                this.Add_CardNumberLabel.ForeColor = Color.Red;
                this.Add_CardNumberLabel.Text = "Invalid card number.";
                this.Add_CardNumberLabel.Visible = true;
                this.AddCardMessage.Visible = false;
                return;
            }

            this.Add_CardNumberLabel.Visible = false;

            string CarNumber = this.Add_CarNumber.Text;
            SW.WriteLine("Action=CarExist;CarNumber=" + CarNumber + ";");
            SW.Flush();

            bool CarExist = Convert.ToBoolean(SR.ReadLine().Split('=')[1].Split(';')[0]);
            if (CardExist)
            {
                this.Add_CarNumberLabel.ForeColor = Color.Red;
                this.Add_CarNumberLabel.Text = "A car with same number already exist.";
                this.Add_CarNumberLabel.Visible = true;
                this.AddCardMessage.Visible = false;
                return;
            }

            if (!Card.IsValidCarNumber(CarNumber))
            {
                this.Add_CarNumberLabel.ForeColor = Color.Red;
                this.Add_CarNumberLabel.Text = "Invalid car number.";
                this.Add_CarNumberLabel.Visible = true;
                this.AddCardMessage.Visible = false;
                return;
            }

            this.Add_CarNumberLabel.Visible = false;

            string MonthlyLimit = this.Add_MonthlyLimit.Text;
            if (!Card.IsValidMonthlyLimit(MonthlyLimit))
            {
                this.Add_MonthlyLimitLabel.ForeColor = Color.Red;
                this.Add_MonthlyLimitLabel.Text = "Invalid supplied monthly limit.\nMust be a positive integer.";
                this.Add_MonthlyLimitLabel.Visible = true;
                this.AddCardMessage.Visible = false;
                return;
            }

            this.Add_MonthlyLimitLabel.Visible = false;

            Card CustomerCard = new Card(CardNumber);
            CustomerCard.CarNumber = CarNumber;
            CustomerCard.MonthlyLimit = Convert.ToInt32(MonthlyLimit);

            SW.WriteLine("Action=AddCard;CardNumber=" + CardNumber + ";CarNumber=" + CarNumber + ";MonthlyLimit=" + MonthlyLimit);
            SW.Flush();

            string Message = SR.ReadLine();

            string temp = Message;
            temp = temp.Split('=')[0];
            if (temp == "Error")
            {
                this.AddCardMessage.ForeColor = Color.Red;
                this.AddCardMessage.Text = temp.Split('=')[1].Split(';')[0];
                this.AddCardMessage.Visible = true;
                return;
            }


            this.AddCardMessage.Text = "Card has been added successfully.";
            this.AddCardMessage.ForeColor = Color.Green;
            this.AddCardMessage.Visible = true;

            return;
        }

        private void RemoveCardButton_Click(object sender, EventArgs e)
        {
            if (!C.Connected)
            {
                ConnectClient();
            }
            string CardNumber = this.Remove_CardNumber.Text;

            if (!Card.IsValidCardNumber(CardNumber))
            {
                this.Remove_CardNumberLabel.ForeColor = Color.Red;
                this.Remove_CardNumberLabel.Text = "Invalid card number.";
                this.Remove_CardNumberLabel.Visible = true;
                this.RemoveCardMessage.Visible = false;
                return;
            }

            SW.WriteLine("Action=CardExist;CardNumber=" + CardNumber + ";");
            SW.Flush();

            bool CardExist = Convert.ToBoolean(SR.ReadLine().Split('=')[1].Split(';')[0]);

            if (!CardExist)
            {
                this.Remove_CardNumberLabel.ForeColor = Color.Red;
                this.Remove_CardNumberLabel.Text = "No such card exist.";
                this.Remove_CardNumberLabel.Visible = true;
                this.RemoveCardMessage.Visible = false;
                return;
            }

            this.Remove_CardNumberLabel.Visible = false;

            SW.WriteLine("Action=RemoveCard;CardNumber=" + CardNumber + ";");
            SW.Flush();

            string Message = SR.ReadLine();

            string temp = Message;
            temp = temp.Split('=')[0];
            if (temp == "Error")
            {
                this.RemoveCardMessage.ForeColor = Color.Red;
                this.RemoveCardMessage.Text = temp.Split('=')[1].Split(';')[0];
                this.RemoveCardMessage.Visible = true;
                return;
            }

            this.RemoveCardMessage.Text = "Card has been deleted successfully.";
            this.RemoveCardMessage.ForeColor = Color.Green;
            this.RemoveCardMessage.Visible = true;

            return;
        }

        private void FetchCardButton_Click(object sender, EventArgs e)
        {
            if (!C.Connected)
            {
                ConnectClient();
            }
            string CardNumber = this.Update_CardNumber.Text;

            if (!Card.IsValidCardNumber(CardNumber))
            {
                this.Update_CardNumberLabel.ForeColor = Color.Red;
                this.Update_CardNumberLabel.Text = "Invalid card number.";
                this.Update_CardNumberLabel.Visible = true;
                this.UpdateCardPanel.Visible = false;
                return;
            }

            SW.WriteLine("Action=CardExist;CardNumber=" + CardNumber + ";");
            SW.Flush();

            bool CardExist = Convert.ToBoolean(SR.ReadLine().Split('=')[1].Split(';')[0]);

            if (!CardExist)
            {
                this.Update_CardNumberLabel.ForeColor = Color.Red;
                this.Update_CardNumberLabel.Text = "No such card exist.";
                this.Update_CardNumberLabel.Visible = true;
                this.UpdateCardPanel.Visible = false;
                return;
            }

            this.Update_CardNumberLabel.Visible = false;

            SW.WriteLine("Action=Enquiry;CardNumber=" + CardNumber);
            SW.Flush();

            string[] Temp = SR.ReadLine().Split(';');
            string[] KeyValue = new string[4];
            for (int i = 0; i < 4; i++)
            {
                KeyValue[i] = Temp[i].Split('=')[1];
            }

            this.Update_CardNumber.Text = KeyValue[0];
            this.Update_CarNumber.Text = KeyValue[1];
            this.Update_MonthlyLimit.Text = KeyValue[2];
            this.Update_CurrentConsumption.Text = KeyValue[3];

            this.UpdateCardPanel.Visible = true;
        }

        private void UpdateCardButton_Click(object sender, EventArgs e)
        {
            if (!C.Connected)
            {
                ConnectClient();
            }
            string CarNumber = this.Update_CarNumber.Text;

            if (!Card.IsValidCarNumber(CarNumber))
            {
                this.Update_CarNumberLabel.ForeColor = Color.Red;
                this.Update_CarNumberLabel.Text = "Invalid car number.";
                this.Update_CarNumberLabel.Visible = true;
                this.UpdateCardPanel.Visible = false;
                return;
            }

            this.Update_CarNumberLabel.Visible = false;

            string MonthlyLimit = this.Update_MonthlyLimit.Text;

            if (!Card.IsValidMonthlyLimit(MonthlyLimit))
            {
                this.Update_MonthlyLimitLabel.ForeColor = Color.Red;
                this.Update_MonthlyLimitLabel.Text = "Invalid supplied monthly limit.\nMust be a positive integer.";
                this.Update_MonthlyLimitLabel.Visible = true;
                this.UpdateCardMessage.Visible = false;
                return;
            }

            this.Update_MonthlyLimitLabel.Visible = false;

            Card CustomerCard = new Card(this.Update_CardNumber.Text);
            CustomerCard.CarNumber = CarNumber;
            CustomerCard.MonthlyLimit = Convert.ToInt32(MonthlyLimit);

            SW.WriteLine("Action=UpdateCard;" + CustomerCard);
            SW.Flush();

            string Message = SR.ReadLine();
            string[] Temp = Message.Split(';');

            string temp = Message;
            temp = temp.Split('=')[0];
            if (temp == "Error")
            {
                this.UpdateCardMessage.ForeColor = Color.Red;
                this.UpdateCardMessage.Text = temp.Split('=')[1].Split(';')[0];
                this.UpdateCardMessage.Visible = true;
                return;
            }

            this.UpdateCardMessage.Text = "Card has been updated successfully.";
            this.UpdateCardMessage.ForeColor = Color.Green;
            this.UpdateCardMessage.Visible = true;

            return;
        }

        private void ServerForm_Load(object sender, EventArgs e)
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
