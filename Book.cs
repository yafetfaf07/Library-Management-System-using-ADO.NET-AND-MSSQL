using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace LMS
{
    internal class Book
    {
        public  int isbn_no;
        public String title;
        public String author;
        public int bookQuantity;
        public int publicationYear;

        public void AddBook()
        {
            
                try
                {
                    String conn = "server=.; database=LMS; integrated security=true;";
                    using (SqlConnection sqlConnection = new SqlConnection(conn))
                    {
                        sqlConnection.Open();

                        SqlCommand cmd = new SqlCommand("sp_insertBooks", sqlConnection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@isbn_no", isbn_no);
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@author", author);
                        cmd.Parameters.AddWithValue("@book_quantity", bookQuantity);
                        cmd.Parameters.AddWithValue("@publication_Year", publicationYear);
                        

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Book has been added successfully");


                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 

        }

        public void UpdateBook()
        {
            try
            {
                String conn = "server=.; database=LMS; integrated security=true;";
                using (SqlConnection sqlConnection = new SqlConnection(conn))
                {
                    sqlConnection.Open();

                    SqlCommand cmd = new SqlCommand("sp_updateBooks", sqlConnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@isbn_no", isbn_no);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@book_quantity", bookQuantity);
                    cmd.Parameters.AddWithValue("@publication_Year", publicationYear);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book has been added successfully");


                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
