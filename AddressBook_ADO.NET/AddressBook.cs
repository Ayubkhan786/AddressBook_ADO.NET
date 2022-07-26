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
    }
}
