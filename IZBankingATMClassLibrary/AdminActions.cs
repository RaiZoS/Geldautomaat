using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace IZBankingATMClassLibrary
{
    public class AdminActions : Database
    {
        PasswordConvertor passwordConvertor = new PasswordConvertor();
        public bool adminLogin(string employee_number, string password)
        {
            //pincode = passwordConvertor.ComputeSha256Hash(pincode);
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM izbanking_employees WHERE employee_number = @employee_number AND password = @password", connection);
                cmd.Parameters.AddWithValue("@employee_number", employee_number);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string full_name = rdr["first_name"].ToString() + " " + rdr["last_name"].ToString();
                    AdminInfo.AdminName = full_name;

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

        public bool createUser(string email, string sex, string firstname, string lastname, string bsn_number, string date_of_birth, string address, string house_number, string postalcode, string town)
        {
            try
            {
                OpenConnection();
                Random RandNum = new Random();

                int account_number = RandNum.Next(10000000, 99999999);

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM izbanking_accounts WHERE account_number = @account_number", connection);
                cmd.Parameters.AddWithValue("@account_number", account_number);
                MySqlDataReader rdr = cmd.ExecuteReader();

                string pincode = "0000";

                if (rdr.Read())
                {
                    rdr.Close();
                    createUser(email, sex, firstname, lastname, bsn_number, date_of_birth, address, house_number, postalcode, town);
                }
                else
                {
                    rdr.Close();
                    //string pinCode = passwordConvert.randomPincode();
                    cmd = new MySqlCommand("INSERT INTO izbanking_accounts (email, sex, firstname, lastname, bsn_number, date_of_birth, address, house_number, postalcode, town, account_number, pincode) VALUES(@email, @sex, @first_name, @last_name, @bsn_number, @date_of_birth, @address, @house_number, @postalcode, @town, @account_number, @pincode)", connection);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@sex", sex);
                    cmd.Parameters.AddWithValue("@first_name", firstname);
                    cmd.Parameters.AddWithValue("@last_name", lastname);
                    cmd.Parameters.AddWithValue("@bsn_number", bsn_number);
                    cmd.Parameters.AddWithValue("@date_of_birth", date_of_birth);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@house_number", house_number);
                    cmd.Parameters.AddWithValue("@postalcode", postalcode);
                    cmd.Parameters.AddWithValue("@town", town);
                    cmd.Parameters.AddWithValue("@account_number", account_number);
                    cmd.Parameters.AddWithValue("@pincode", pincode);

                    cmd.ExecuteNonQuery();

                    CloseConnection();

                    Console.WriteLine("SUCCESSS");
                    return true;
                }
                rdr.Close();

                CloseConnection();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return false;
        }

        public class DiscountStructure
        {
            public string Id { get; set; }
            public string Email { get; set; }
            public string Geslacht { get; set; }
            public string Voornaam { get; set; }
            public string Achternaam { get; set; }
            public string Bsn_nummer { get; set; }
            public string Geboortedatum { get; set; }
            public string Adres { get; set; }
            public string Nummer { get; set; }
            public string Postcode { get; set; }
            public string Woonplaats { get; set; }
            public string Account_nummer { get; set; }
            public string Pincode { get; set; }
            public string Status { get; set; }
        }

        public List<DiscountStructure> fillCustomerTable(String filter = "")
        {
            List<DiscountStructure> DiscountList = new List<DiscountStructure>();

            try
            {
                CloseConnection();
                OpenConnection();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM izbanking_accounts WHERE account_number LIKE @filter", connection);

                cmd.Parameters.AddWithValue("@filter", "%" + filter + "%");

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    DiscountList.Add(new DiscountStructure()
                    {
                        Id = rdr["id"].ToString(),
                        Email = rdr["email"].ToString(),
                        Geslacht = rdr["sex"].ToString(),
                        Voornaam = rdr["firstname"].ToString(),
                        Achternaam = rdr["lastname"].ToString(),
                        Bsn_nummer = rdr["bsn_number"].ToString(),
                        Geboortedatum = Convert.ToDateTime(rdr["date_of_birth"]).ToString("dd/MM/yyyy"),
                        Adres = rdr["address"].ToString(),
                        Nummer = rdr["house_number"].ToString(),
                        Postcode = rdr["postalcode"].ToString(),
                        Woonplaats = rdr["town"].ToString(),
                        Account_nummer = rdr["account_number"].ToString(),
                        Pincode = rdr["pincode"].ToString(),
                        Status = "goed",
                    });
                }

                rdr.Close();
                CloseConnection();

                return DiscountList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return DiscountList;
            }
        }
    }
}
