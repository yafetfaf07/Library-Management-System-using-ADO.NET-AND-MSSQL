using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            String connectionString = "server=.; database=LMS; integrated security=true;";

            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    

                    if(loginCmb.Text=="Librarian")
                    {

                        SqlCommand cmd1 = new SqlCommand("select userName,passwords from Librarian", conn);
                        SqlDataReader rdLibrarian;
                        rdLibrarian = cmd1.ExecuteReader();



                        while (rdLibrarian.Read())
                        {
                            if (rdLibrarian["userName"].ToString() == userNameTxt.Text && rdLibrarian["passwords"].ToString() == passwordTxt.Text)
                            {
                                new LibrarianForm().Show();
                                this.Hide();

                            }
                            //else
                            //{
                            //    MessageBox.Show("Username or password is incorrect");
                            //}
                        }
                        rdLibrarian.Close();

                    }

                    else if (loginCmb.Text=="Student")
                    {
                        SqlCommand cmd2 = new SqlCommand("select userName,passwords from Student", conn);
                        SqlDataReader rdStudent;
                        rdStudent = cmd2.ExecuteReader();
                        while (rdStudent.Read())
                        {
                            if (rdStudent["userName"].ToString() == userNameTxt.Text && rdStudent["passwords"].ToString() == passwordTxt.Text)
                            {
                                // new LibrarianForm().Show();
                                MessageBox.Show("Design the student platform");

                            }
                            //else
                            //{
                            //    MessageBox.Show("Username or password is incorrect");
                            //}
                            

                        }
                        rdStudent.Close();

                        errorProvider1.SetError(passwordTxt, null);
                        errorProvider1.SetError(passwordTxt, "User Name or Password is Incorrect");


                    }

                   

                    

                



                }

            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
