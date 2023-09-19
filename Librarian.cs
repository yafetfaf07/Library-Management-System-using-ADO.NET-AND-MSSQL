using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    internal class Librarian
    {
        public String firstName;
        public String lastName;
        public int age;
        public String email;
        public String phone;
        public String userName;
        public String password;

        public void AddLibrarian()
        {
           
                try
                {
                    String conn = "server=.; database=LMS; integrated security=true;";
                    using (SqlConnection sqlConnection = new SqlConnection(conn))
                    {
                        sqlConnection.Open();

                        SqlCommand cmd = new SqlCommand("sp_insertLibrarian", sqlConnection);

                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@fname", firstName);
                        cmd.Parameters.AddWithValue("@lname", lastName);
                        cmd.Parameters.AddWithValue("@userName", userName);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone_no", phone);
                        cmd.Parameters.AddWithValue("@password", password);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Librarian has been added successfully");

                    new LibrarianForm().Show();



                    }





                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }

        }
    }

