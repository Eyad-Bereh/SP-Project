using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CardOperations
{
    public class Card
    {
        private readonly string card_number;
        private string car_number;
        private int monthly_limit;
        private int current_consumption;
        private static MySqlConnection mysql_connection;

        public Card(string card_number)
        {
            this.card_number = card_number;
        }

        public Card(string card_number, string car_number, int monthly_limit, int current_consumption)
        {
            this.card_number = card_number;
            this.car_number = car_number;
            this.monthly_limit = monthly_limit;
            this.current_consumption = current_consumption;
        }

        public string CardNumber
        {
            get
            {
                return this.card_number;
            }
        }

        public string CarNumber
        {
            get
            {
                return this.car_number;
            }
            set
            {
                this.car_number = value;
            }
        }

        public int MonthlyLimit
        {
            get
            {
                return this.monthly_limit;
            }
            set
            {
                this.monthly_limit = value;
            }
        }

        public int CurrentConsumption
        {
            get
            {
                return this.current_consumption;
            }
            set
            {
                this.current_consumption = value;
            }
        }

        public static MySqlConnection MySQLConnection
        {
            get
            {
                return mysql_connection;
            }
            set
            {
                mysql_connection = value;
            }
        }

        public static bool CardExist(string CardNumber)
        {
            MySqlCommand SearchCommand = new MySqlCommand("SELECT * FROM `cards` WHERE `card_number` = @CardNumber;");
            SearchCommand.Connection = MySQLConnection;
            SearchCommand.Prepare();
            SearchCommand.Parameters.AddWithValue("@CardNumber", CardNumber);
            SearchCommand.ExecuteNonQuery();

            MySqlDataReader DataReader = SearchCommand.ExecuteReader();

            if (!DataReader.HasRows)
            {
                DataReader.Close();
                return false;
            }
            DataReader.Close();
            return true;
        }

        public static bool IsValidCardNumber(string CardNumber)
        {
            Regex CardNumberRegex = new Regex(@"\d{8}", RegexOptions.ECMAScript);
            if (!CardNumberRegex.IsMatch(CardNumber))
            {
                return false;
            }
            return true;
        }

        public static bool CarExist(string CarNumber)
        {
            MySqlCommand SearchCommand = new MySqlCommand("SELECT * FROM `cards` WHERE `car_number` = @CarNumber;");
            SearchCommand.Connection = MySQLConnection;
            SearchCommand.Prepare();
            SearchCommand.Parameters.AddWithValue("@CarNumber", CarNumber);
            SearchCommand.ExecuteNonQuery();

            MySqlDataReader DataReader = SearchCommand.ExecuteReader();

            if (!DataReader.HasRows)
            {
                DataReader.Close();
                return false;
            }
            DataReader.Close();
            return true;
        }

        public static bool IsValidCarNumber(string CarNumber)
        {
            Regex CardNumberRegex = new Regex(@"\d{8}", RegexOptions.ECMAScript);
            if (!CardNumberRegex.IsMatch(CarNumber))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidMonthlyLimit(string MonthlyLimit)
        {
            int temp = -1;
            try
            {
                temp = Convert.ToInt32(MonthlyLimit);
            }
            catch (Exception Exception)
            {
                return false;
            }

            if (temp <= 0)
            {
                return false;
            }
            return true;
        }

        public static Card GetCardInfo(string CardNumber)
        {
            MySqlCommand SearchCommand = new MySqlCommand("SELECT * FROM `cards` WHERE `card_number` = @CardNumber;");
            SearchCommand.Connection = MySQLConnection;
            SearchCommand.Prepare();
            SearchCommand.Parameters.AddWithValue("@CardNumber", CardNumber);
            SearchCommand.ExecuteNonQuery();

            MySqlDataReader DataReader = SearchCommand.ExecuteReader();

            if (!DataReader.HasRows)
            {
                return null;
            }

            DataReader.Read();
            Card Info = new Card(CardNumber);

            Info.CarNumber = DataReader["car_number"].ToString();
            Info.MonthlyLimit = Convert.ToInt32(DataReader["monthly_limit"].ToString());
            Info.CurrentConsumption = Convert.ToInt32(DataReader["current_consumption"].ToString());
            DataReader.Close();

            return Info;
        }

        public static void RemoveCard(string CardNumber)
        {
            MySqlCommand Command = MySQLConnection.CreateCommand();
            MySqlTransaction Transaction = MySQLConnection.BeginTransaction();

            Command.Connection = MySQLConnection;
            Command.Transaction = Transaction;

            try
            {
                Command.CommandText = "DELETE FROM `log` WHERE `card_number` = @LogCardNumber";
                Command.Prepare();
                Command.Parameters.AddWithValue("@LogCardNumber", CardNumber);
                Command.ExecuteNonQuery();

                Command.CommandText = "DELETE FROM `cards` WHERE `card_number` = @CardNumber;";
                Command.Prepare();
                Command.Parameters.AddWithValue("@CardNumber", CardNumber);
                Command.ExecuteNonQuery();

                Transaction.Commit();
            }
            catch (MySqlException Exception)
            {
                throw Exception;
            }
        }

        public static void AddCard(Card CustomerCard)
        {
            MySqlCommand Command = MySQLConnection.CreateCommand();
            Command.Connection = MySQLConnection;
            Command.CommandText = "INSERT INTO `cards` VALUES(@CardNumber, @CarNumber, @MonthlyLimit, 0);";
            Command.Prepare();
            Command.Parameters.AddWithValue("@CardNumber", CustomerCard.CardNumber);
            Command.Parameters.AddWithValue("@CarNumber", CustomerCard.CarNumber);
            Command.Parameters.AddWithValue("@MonthlyLimit", CustomerCard.MonthlyLimit);

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (MySqlException Exception)
            {
                throw Exception;
            }
        }

        public static void UpdateCard(Card CustomerCard)
        {
            MySqlCommand Command = MySQLConnection.CreateCommand();
            Command.Connection = MySQLConnection;
            Command.CommandText = "UPDATE `cards` SET `car_number` = @CarNumber, `monthly_limit` = @MonthlyLimit WHERE `card_number` = @CardNumber;";
            Command.Prepare();
            Command.Parameters.AddWithValue("@CardNumber", CustomerCard.CardNumber);
            Command.Parameters.AddWithValue("@CarNumber", CustomerCard.CarNumber);
            Command.Parameters.AddWithValue("@MonthlyLimit", CustomerCard.MonthlyLimit);

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (MySqlException Exception)
            {
                throw Exception;
            }
        }

        public static bool CanCustomerRefill(string CardNumber, int Quantity)
        {
            MySqlCommand SearchCommand = new MySqlCommand("SELECT * FROM `cards` WHERE `card_number` = @CardNumber");
            SearchCommand.Connection = MySQLConnection;
            SearchCommand.Prepare();
            SearchCommand.Parameters.AddWithValue("@CardNumber", CardNumber);
            SearchCommand.ExecuteNonQuery();

            MySqlDataReader DataReader = SearchCommand.ExecuteReader();

            if (!DataReader.HasRows)
            {
                DataReader.Close();
                return false;
            }

            DataReader.Read();
            int MonthlyLimit = Convert.ToInt32(DataReader["monthly_limit"].ToString());
            int CurrentConsumption = Convert.ToInt32(DataReader["current_consumption"].ToString());
            if (Quantity + CurrentConsumption > MonthlyLimit)
            {
                DataReader.Close();
                return false;
            }

            DataReader.Close();
            return true;
        }

        public static bool IsValidConsumptionAmount(string ConsumptionAmount)
        {
            int temp = -1;
            try
            {
                temp = Convert.ToInt32(ConsumptionAmount);
            }
            catch (Exception Exception)
            {
                return false;
            }

            if (temp <= 0)
            {
                return false;
            }
            return true;
        }

        public static void ConsumeFuel(string CardNumber, string ConsumptionAmount)
        {
            MySqlCommand Command = MySQLConnection.CreateCommand();
            MySqlTransaction Transaction = MySQLConnection.BeginTransaction();

            Command.Connection = MySQLConnection;
            Command.Transaction = Transaction;

            try
            {
                int TimeStamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
                Command.CommandText = "UPDATE `cards` SET `current_consumption` = `current_consumption` + @ConsumptionAmount WHERE `card_number` = @CardNumber;";
                Command.Prepare();
                Command.Parameters.AddWithValue("@ConsumptionAmount", ConsumptionAmount);
                Command.Parameters.AddWithValue("@CardNumber", CardNumber);
                Command.ExecuteNonQuery();

                Command.CommandText = "INSERT INTO `log` VALUES(@LogCardNumber, @LogConsumptionAmount, @TimeStamp)";
                Command.Prepare();
                Command.Parameters.AddWithValue("@LogCardNumber", CardNumber);
                Command.Parameters.AddWithValue("@LogConsumptionAmount", ConsumptionAmount);
                Command.Parameters.AddWithValue("@TimeStamp", TimeStamp);
                Command.ExecuteNonQuery();
                Transaction.Commit();
            }
            catch (MySqlException Exception)
            {
                throw Exception;
            }
        }

        public static CardOperationInfo GetCardOperationInfo(string CardNumber)
        {
            MySqlCommand SearchCommand = new MySqlCommand("SELECT * FROM `cards` JOIN `log` ON (`cards`.`card_number` = `log`.`card_number`) WHERE `cards`.`card_number` = @CardNumber ORDER BY `log`.`timestamp` DESC LIMIT 1;");
            SearchCommand.Connection = MySQLConnection;
            SearchCommand.Prepare();
            SearchCommand.Parameters.AddWithValue("@CardNumber", CardNumber);
            SearchCommand.ExecuteNonQuery();

            MySqlDataReader DataReader = SearchCommand.ExecuteReader();
            DataReader.Read();

            int TimeStamp = Convert.ToInt32(DataReader["timestamp"].ToString());
            TimeStamp = new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(TimeStamp).Second;

            CardOperationInfo OperationInfo = new CardOperationInfo();
            OperationInfo.CardNumber = DataReader["card_number"].ToString();
            OperationInfo.CarNumber = DataReader["car_number"].ToString();
            OperationInfo.CurrentConsumption = Convert.ToInt32(DataReader["current_consumption"].ToString());
            OperationInfo.MonthlyLimit = Convert.ToInt32(DataReader["monthly_limit"].ToString());
            OperationInfo.ConsumptionAmount = Convert.ToInt32(DataReader["consumption_amount"].ToString());
            OperationInfo.TimeStamp = TimeStamp;
            OperationInfo.RemainingFuel = OperationInfo.MonthlyLimit - OperationInfo.CurrentConsumption;

            DataReader.Close();
            return OperationInfo;
        }

        public override string ToString()
        {
            string message = "";
            message += "CardNumber=" + CardNumber + ";";
            message += "CarNumber=" + CardNumber + ";";
            message += "MonthlyLimit=" + MonthlyLimit + ";";
            message += "CurrentConsumption=" + CurrentConsumption + ";";
            return message;
        }
    }

    public class CardOperationInfo
    {
        public string CardNumber;
        public string CarNumber;
        public int CurrentConsumption;
        public int MonthlyLimit;
        public int ConsumptionAmount;
        public int TimeStamp;
        public int RemainingFuel;

        public override string ToString()
        {
            string message = "";
            message += "CardNumber=" + CardNumber + ";";
            message += "CarNumber=" + CarNumber + ";";
            message += "CurrentConsumption=" + CurrentConsumption + ";";
            message += "MonthlyLimit=" + MonthlyLimit + ";";
            message += "ConsumptionAmount=" + ConsumptionAmount + ";";
            message += "TimeStamp=" + TimeStamp + ";";
            message += "RemainingFuel=" + RemainingFuel + ";";
            return message;
        }
    }
}
