using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AddressBook_ADO.NET
{
    public class AddressBook
    {
        const string connection = "Data Source=.;Initial Catalog = AddressBook; Integrated Security = True";
        SqlConnection sql = new SqlConnection(connection);
        public void RetrieveAll()
        {
            string query = @"Select * From Addressbook";
            SqlCommand command = new SqlCommand(query, sql);
            Contact contact = new Contact();
            sql.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        contact.FirstName = reader.GetString(0);
                        contact.LastName = reader.GetString(1);
                        contact.Address = reader.GetString(2);
                        contact.City = reader.GetString(3);
                        contact.State = reader.GetString(4);
                        contact.Zip =reader.GetInt64(5);
                        contact.PhoneNumber = reader.GetInt64(6);
                        contact.Email = reader.GetString(7);
                        contact.Type = reader.GetString(8);
                        Console.WriteLine(" First Name: " + contact.FirstName + " Last Name: " + contact.LastName + " Address: " + contact.Address + " City: " + contact.City + " State : " + contact.State + " Zip: " + contact.Zip + " Phone Number: " + contact.PhoneNumber + " Email: " + contact.Email + " type: " + contact.Type);
                    }
                }
                reader.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void AddContact()
        {
            string select = @"Insert into AddressBook (FirstName ,LastName,Address,City,State,zip,PhoneNumber,Email,Type) VALUES( 'Priya','Moni','Hungama','Gujrat','Andra Pradesh',785457,9874563210,'moni@gmail.com','Friend')";
            SqlCommand cmd = new SqlCommand(select, sql);
            cmd.CommandType = CommandType.Text;
            sql.Open();
            try
            {
                var con = cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            sql.Close();
        }
        public void AddDate()
        {
            string Add = @"ALTER TABLE AddressBook ADD Date DateTime";
            SqlCommand cmd = new SqlCommand(Add, sql);
            cmd.CommandType = CommandType.Text;
            sql.Open();
            try
            {
                var con = cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            sql.Close();
        }
        public void UpdateDate()
        {

            //For Contact Ayub
            Contact contact = new Contact();
            var query = @"UPDATE AddressBook Set Date = '11-02-2020' where FirstName = 'Ayub'";
            SqlCommand cmd = new SqlCommand(query, sql);
            this.sql.Open();
            cmd.CommandType = CommandType.Text;


            cmd.Parameters.Add("Date", SqlDbType.DateTime).Value = "11 - 02 - 2020";
            cmd.ExecuteNonQuery();

            sql.Close();

            //For Contact Vijay
            Contact contact1 = new Contact();
            var query1 = @"UPDATE AddressBook Set Date = '11-05-2021' where FirstName = 'Vijay'";
            SqlCommand cmd1 = new SqlCommand(query1, sql);
            this.sql.Open();
            cmd1.CommandType = CommandType.Text;


            cmd1.Parameters.Add("Date", SqlDbType.DateTime).Value = "11 - 05 - 2021";
            cmd1.ExecuteNonQuery();

            sql.Close();



            //For Contact Priya
            Contact contact2 = new Contact();
            var query2 = @"UPDATE AddressBook Set Date = '11-07-2015' where FirstName = 'Priya'";
            SqlCommand cmd2 = new SqlCommand(query2, sql);
            this.sql.Open();
            cmd2.CommandType = CommandType.Text;


            cmd2.Parameters.Add("Date", SqlDbType.DateTime).Value = "11 - 07- 2015";
            cmd2.ExecuteNonQuery();

            sql.Close();



            //For Contact Nithish
            Contact contact3 = new Contact();
            var query3 = @"UPDATE AddressBook Set Date = '11-09-2016' where FirstName = 'Nithish'";
            SqlCommand cmd3 = new SqlCommand(query3, sql);
            this.sql.Open();
            cmd3.CommandType = CommandType.Text;


            cmd3.Parameters.Add("Date", SqlDbType.DateTime).Value = "11 - 09- 2016";
            cmd3.ExecuteNonQuery();

            sql.Close();


        }
        public string RetrieveFromDate()
            {
            string select = @"Select * FROM Addressbook Where date BETWEEN CAST('11 - 07- 2015' AS date) AND ('11 - 05 - 2021')";
            SqlCommand command = new SqlCommand(select, sql);
            sql.Open();
            Contact contact = new Contact();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        contact.FirstName = reader.GetString(0);
                        contact.LastName = reader.GetString(1);
                        contact.Address = reader.GetString(2);
                        contact.City = reader.GetString(3);
                        contact.State = reader.GetString(4);
                        contact.Zip = reader.GetInt64(5);
                        contact.PhoneNumber = reader.GetInt64(6);
                        contact.Email = reader.GetString(7);
                        contact.Type = reader.GetString(8);
                        Console.WriteLine(" First Name: " + contact.FirstName + " Last Name: " + contact.LastName + " Address: " + contact.Address
                            + " City: " + contact.City + " State : " + contact.State + " Zip: " + contact.Zip + " Phone Number: " + contact.PhoneNumber
                            + " Email: " + contact.Email + " type: " + contact.Type);
                    }
                }
                reader.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return contact.FirstName;
        }
    }
}
