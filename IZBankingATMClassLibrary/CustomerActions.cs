using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace IZBankingATMClassLibrary
{
    public class CustomerActions : Database
    {
        PasswordConvertor passwordConvertor = new PasswordConvertor();
        public bool customerLogin(string account_number, string pincode)
        {
            //pincode = passwordConvertor.ComputeSha256Hash(pincode);
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM izbanking_accounts WHERE account_number = @account_number AND pincode = @pincode", connection);
                cmd.Parameters.AddWithValue("@account_number", account_number);
                cmd.Parameters.AddWithValue("@pincode", pincode);

                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    string full_name = rdr["firstname"].ToString() + " " + rdr["lastname"].ToString();
                    CustomerInfo.CustomerName = full_name;
                    CustomerInfo.CustomerID = rdr["id"].ToString();


                    string blocked = rdr["status"].ToString();
                    if (blocked == "1")
                    {
                        
                        return false;
                    }

                    CloseConnection();
                    return true;

                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("Account did not match");
            CloseConnection();
            return false;
        }

        public double accountBalance()
        {
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM izbanking_accounts WHERE id = @id", connection);
                cmd.Parameters.AddWithValue("@id", CustomerInfo.CustomerID);

                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {

                    return Convert.ToDouble(rdr["balance"]);
                }
                rdr.Close();
                CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return 0.0;
        }

        public string customerWithdraw(string amount)
        {
            try
            {
                if (validateWithdrawHistory())
                {
                    if (validateAffordable(amount))
                    {
                        double newBalance = newAmount(amount);
                        Console.WriteLine(newBalance);
                        CloseConnection();
                        OpenConnection();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO `izbanking_transactions` (`amount`, `type`, `created_at`, `customer_id`) VALUES (@amount, @type, CURRENT_DATE(), @customer_id)", connection);
                        MySqlCommand cmd2 = new MySqlCommand("UPDATE `izbanking_accounts` SET balance = @balance WHERE id = @id", connection);

                        cmd.Parameters.AddWithValue("@amount", Convert.ToDouble(amount));
                        cmd.Parameters.AddWithValue("@type", CustomerInfo.Withdraw);
                        cmd.Parameters.AddWithValue("@customer_id", CustomerInfo.CustomerID);

                        cmd2.Parameters.AddWithValue("@balance", newBalance);
                        cmd2.Parameters.AddWithValue("@id", CustomerInfo.CustomerID);

                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();

                        CloseConnection();
                        CloseConnection();

                        return "Transactie goedgekeurd.";
                    }
                    else
                    {
                        return "U heeft niet genoeg geld.";
                    }
                }
                else
                {
                    Console.WriteLine("To many trans");
                    return "Uw heeft te veel transacties gedaan vandaag.";
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return "error";
        }

        public bool validateWithdrawHistory()
        {
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `izbanking_transactions` WHERE customer_id = @id AND created_at = CURRENT_DATE() AND type = 'withdraw'", connection);
                cmd.Parameters.AddWithValue("@id", CustomerInfo.CustomerID);

                MySqlDataReader rdr = cmd.ExecuteReader();

                int counter = 0;
                while (rdr.Read())
                {
                    counter++;
                }
                rdr.Close();

                if (counter < 3)
                {
                    CloseConnection();
                    return true;
                }
                else
                {
                    CloseConnection();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            CloseConnection();
            return false;
        }        

        public double newAmount(string amount)
        {
            return accountBalance() - Convert.ToDouble(amount);
        }

        public bool validateAffordable(string amount)
        {
            double newBalance = newAmount(amount);
            if (newBalance < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool deposit(string amount)
        {
            try
            {

                double currentBalance = accountBalance();
                double newBalance = Convert.ToDouble(amount) + Convert.ToDouble(currentBalance);
                CloseConnection();
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `izbanking_transactions` (`amount`, `type`, `created_at`, `customer_id`) VALUES (@amount, @type, CURRENT_DATE(), @customer_id)", connection);
                MySqlCommand cmd2 = new MySqlCommand("UPDATE `izbanking_accounts` SET balance = @balance WHERE id = @id", connection);

                cmd.Parameters.AddWithValue("@amount", Convert.ToDouble(amount));
                cmd.Parameters.AddWithValue("@type", CustomerInfo.Deposit);
                cmd.Parameters.AddWithValue("@customer_id", CustomerInfo.CustomerID);

                cmd2.Parameters.AddWithValue("@balance", newBalance);
                cmd2.Parameters.AddWithValue("@id", CustomerInfo.CustomerID);

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                CloseConnection();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return false;
        }

        public string transactionHistory()
        {
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `izbanking_transactions` WHERE customer_id = @id ORDER BY id DESC LIMIT 3", connection);
                cmd.Parameters.AddWithValue("@id", CustomerInfo.CustomerID);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    DateTime dateAndTime = DateTime.Parse(rdr["created_at"].ToString());
                    string optAmount = rdr["amount"].ToString();
                    string optType = rdr["type"].ToString();

                    if (CustomerInfo.counter == 0)
                    {
                        CustomerInfo.CustomerTransactions1 = "€" + optAmount + "   " + optType + "   " + dateAndTime.ToString("dd/MM/yyyy");
                    }

                    if (CustomerInfo.counter == 1)
                    {
                        CustomerInfo.CustomerTransactions2 = "€" + optAmount + "   " + optType + "   " + dateAndTime.ToString("dd/MM/yyyy");
                    }

                    if (CustomerInfo.counter == 2)
                    {
                        CustomerInfo.CustomerTransactions3 = "€" + optAmount + "   " + optType + "   " + dateAndTime.ToString("dd/MM/yyyy");
                    }
                    CustomerInfo.counter++;


                }
                CustomerInfo.counter = 0;
                rdr.Close();
                CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return "";
        }
    }
}
