using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CardOperations;

namespace ServerSide
{
    class Program
    {
        public static TcpListener Server = new TcpListener(8512);

        public static int Main(string[] args)
        {
            Card.MySQLConnection = new MySqlConnection(@"server=127.0.0.1;uid=root;database=smartcardsystem");
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
            }
            Server.Start();
            Thread ListenerThread = new Thread(Listener);
            ListenerThread.Start();
            Console.ReadKey();
            return 0;
        }

        public static void Listener()
        {
            while (true)
            {
                TcpClient C = Server.AcceptTcpClient();
                Console.WriteLine(C.Client.RemoteEndPoint + " Client Accepted");
                Thread WorkerThread = new Thread(Worker);
                WorkerThread.IsBackground = true;
                WorkerThread.Start(C);
            }
        }

        public static void Worker(object Client)
        {
            try
            {
                NetworkStream NS = (Client as TcpClient).GetStream();
                StreamReader SR = new StreamReader(NS);
                StreamWriter SW = new StreamWriter(NS);

                while (true)
                {
                    string Line = SR.ReadLine();
                    Console.WriteLine("Recieved " + Line + " From Client " + (Client as TcpClient).Client.RemoteEndPoint);
                    string[] Temp = Line.Split(';');
                    string message = "";
                    Dictionary<string, string> Parameters = new Dictionary<string, string>();
                    string Action = Temp[0].Split('=')[1];
                    if (Action == "CardExist")
                    {
                        string CardNumber = Temp[1].Split('=')[1];
                        bool CardExist = Card.CardExist(CardNumber);
                        message = "Result=" + CardExist + ";";
                        SW.WriteLine(message);
                        SW.Flush();
                    }
                    else if (Action == "CarExist")
                    {
                        string CarNumber = Temp[1].Split('=')[1];
                        bool CarExist = Card.CarExist(CarNumber);
                        message = "Result=" + CarExist + ";";
                        SW.WriteLine(message);
                        SW.Flush();
                    }
                    else if (Action == "Enquiry")
                    {
                        string CardNumber = Temp[1].Split('=')[1];
                        Card CardInfo = Card.GetCardInfo(CardNumber);
                        message = CardInfo.ToString();
                        SW.WriteLine(CardInfo);
                        SW.Flush();
                    }
                    else if (Action == "CanCustomerRefill")
                    {
                        string CardNumber = Temp[1].Split('=')[1];
                        int Quantity = Convert.ToInt32(Temp[2].Split('=')[1]);
                        bool CanCustomerRefill = Card.CanCustomerRefill(CardNumber, Quantity);
                        message = "Result=" + CanCustomerRefill + ";";
                        SW.WriteLine(message);
                        SW.Flush();
                    }
                    else if (Action == "ConsumeFuel")
                    {
                        string CardNumber = Temp[1].Split('=')[1];
                        string Quantity = Temp[2].Split('=')[1];
                        try
                        {
                            Card.ConsumeFuel(CardNumber, Quantity);
                        }
                        catch (MySqlException Exception)
                        {
                            message = "Error=" + Exception.Message + ";";
                            Console.WriteLine("Sent " + message + " To Client " + (Client as TcpClient).Client.RemoteEndPoint);
                        }
                        message = Card.GetCardOperationInfo(CardNumber).ToString();
                        SW.WriteLine(message);
                        SW.Flush();
                    }
                    else if (Action == "AddCard")
                    {
                        string CardNumber = Temp[1].Split('=')[1];
                        string CarNumber = Temp[2].Split('=')[1];
                        string MonthlyLimit = Temp[3].Split('=')[1];
                        try
                        {
                            Card CustomerCard = new Card(CardNumber);
                            CustomerCard.CarNumber = CarNumber;
                            CustomerCard.MonthlyLimit = Convert.ToInt32(MonthlyLimit);
                            Card.AddCard(CustomerCard);
                        }
                        catch (MySqlException Exception)
                        {
                            message = "Error=" + Exception.Message + ";";
                            Console.WriteLine("Sent " + message + " To Client " + (Client as TcpClient).Client.RemoteEndPoint);
                        }
                        message = "Result=Success;";
                        SW.WriteLine(message);
                        SW.Flush();
                    }
                    else if (Action == "RemoveCard")
                    {
                        string CardNumber = Temp[1].Split('=')[1];
                        try
                        {
                            Card.RemoveCard(CardNumber);
                        }
                        catch (MySqlException Exception)
                        {
                            message = "Error=" + Exception.Message + ";";
                            Console.WriteLine("Sent " + message + " To Client " + (Client as TcpClient).Client.RemoteEndPoint);
                        }
                        message = "Result=Success;";
                        SW.WriteLine(message);
                        SW.Flush();

                    }
                    else if (Action == "UpdateCard")
                    {
                        string CardNumber = Temp[1].Split('=')[1];
                        string CarNumber = Temp[2].Split('=')[1];
                        string MonthlyLimit = Temp[3].Split('=')[1];
                        string CurrentConsumption = Temp[4].Split('=')[1];

                        Card CustomerCard = new Card(CardNumber);
                        CustomerCard.CarNumber = CarNumber;
                        CustomerCard.MonthlyLimit = Convert.ToInt32(MonthlyLimit);
                        CustomerCard.CurrentConsumption = Convert.ToInt32(CurrentConsumption);

                        try
                        {
                            Card.UpdateCard(CustomerCard);
                        }
                        catch (MySqlException Exception)
                        {
                            message = "Error=" + Exception.Message + ";";
                            Console.WriteLine("Sent " + message + " To Client " + (Client as TcpClient).Client.RemoteEndPoint);
                        }
                        message = "Result=Success;";
                        SW.WriteLine(message);
                        SW.Flush();
                    }
                    Console.WriteLine("Sent " + message + " To Client " + (Client as TcpClient).Client.RemoteEndPoint);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
