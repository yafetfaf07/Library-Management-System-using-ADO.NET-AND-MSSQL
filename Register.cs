using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Register : MaterialSkin.Controls.MaterialForm
    {
        Student student = new Student();
        Librarian librarian = new Librarian();

        public Register()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }

        private void Blah_Load(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            //if(firstName.Text!=null && lastName.Text!=null && userName.Text!=null && phoneNo.Text!=null
            //    && password.Text==null && email.Text==null && age.Text==null && RegisterAs.Text!=null)
            //{
                if (RegisterAs.Text == "Student")
                {
                    student.firstName = firstName.Text;
                    student.lastName = lastName.Text;
                    student.userName = userName.Text;
                    student.phone = phoneNo.Text;
                    student.password = password.Text;
                    student.email = email.Text;
                    student.age = Int32.Parse(age.Text);

                    student.AddStudent();
                    firstName.Text = "";
                    lastName.Text = "";
                    userName.Text = "";
                    phoneNo.Text = "";
                    password.Text = "";
                    email.Text = "";
                    age.Text = "";

                }
                else if (RegisterAs.Text == "Librarian")
                {
                    librarian.firstName = firstName.Text;
                    librarian.lastName = lastName.Text;
                    librarian.userName = userName.Text;
                    librarian.phone = phoneNo.Text;
                    librarian.password = password.Text;
                    librarian.email = email.Text;
                    librarian.age = Int32.Parse(age.Text);

                    librarian.AddLibrarian();
                    firstName.Text = "";
                    lastName.Text = "";
                    userName.Text = "";
                    phoneNo.Text = "";
                    password.Text = "";
                    email.Text = "";
                    age.Text = "";

                }
                else
                {
                    MessageBox.Show("Either Librarian or Student can register");
                }

            }
            //else
            //{
            //    MessageBox.Show("Please Make sure all data is given");
            //}
        
        }
    
}
