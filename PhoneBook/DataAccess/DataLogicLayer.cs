using PhoneBook.Model;
using System.Data.SqlClient;

namespace PhoneBook.DataAccess
{
    public class DataLogicLayer
    {

        private string connectionstring = "Data Source=DESKTOP-TPQOOMC\\SQLEXPRESS;Database=PhoneContact;Integrated Security=sspi;";
       
      
        public void AddContact(Contact contact)
        {

            string insertquery = "INSERT INTO Contacts (UserName, surname, phone, email) VALUES (@UserName, @surname, @phone, @email)";
           
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();


                    using (SqlCommand command = new SqlCommand(insertquery,connection))
                    {
                        command.Parameters.Add("@UserName", System.Data.SqlDbType.VarChar).Value = contact.Name;
                        command.Parameters.Add("@surname", System.Data.SqlDbType.VarChar).Value = contact.Surname;
                        command.Parameters.Add("@phone", System.Data.SqlDbType.VarChar).Value = contact.Phone;
                        command.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = contact.Email;
                       
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex) 
                {

                    Console.WriteLine(ex.Message);
                }
            
            }
        }

        
    }
}
