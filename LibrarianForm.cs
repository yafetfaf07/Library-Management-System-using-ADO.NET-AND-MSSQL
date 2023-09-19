using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LMS
{
    public partial class LibrarianForm : MaterialSkin.Controls.MaterialForm
    {
        Book book= new Book();
       
        public LibrarianForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            showBooks();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Librarian_Form_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            book.isbn_no = Int32.Parse(isbn_textField.Text);
            book.author = author_TextField.Text;
            book.title=title_TextField.Text;
            book.publicationYear = Int32.Parse(publishedYear_TextField.Text);
            book.bookQuantity = Int32.Parse(amount_TextField.Text);

            book.AddBook();

            showBooks();

            isbn_textField.Text = null;
            author_TextField.Text = null;
            publishedYear_TextField.Text = null;
            amount_TextField.Text = null;
            title_TextField.Text = null;

        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {
         
        }
        private void showBooks()
        {
            try
            {
                string ConString = "server=.; database=LMS; integrated security=true;";
                using (SqlConnection connection = new SqlConnection(ConString))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select isbn_no, title, author," +
                        $" book_quantity, publicationYear from Book", connection);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    int s = dt.Rows.Count;
                    MessageBox.Show(s.ToString());
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            book.isbn_no = Int32.Parse(isbn_textField.Text);
            book.author = author_TextField.Text;
            book.title = title_TextField.Text;
            book.publicationYear = Int32.Parse(publishedYear_TextField.Text);
            book.bookQuantity = Int32.Parse(amount_TextField.Text);

            book.UpdateBook();

            showBooks();
            isbn_textField.Text = null;
            author_TextField.Text = null;
            publishedYear_TextField.Text = null;
            amount_TextField.Text = null;
            title_TextField.Text = null;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            isbn_textField.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            title_TextField.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            author_TextField.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            amount_TextField.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            publishedYear_TextField.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();

        }
        private void sortingByPublicationYear() // use Insertion Sort
        {
            dataGridView1.DataSource = null;

            try
            {
                string ConString = "server=.; database=LMS; integrated security=true;";
                using (SqlConnection connection = new SqlConnection(ConString))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select" +
                        $" publicationYear from Book", connection);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    int s = dt.Rows.Count;
                    int[] publicationYear = new int[s];

                    /* Insertion Sort Algorithm*/

                    for (int i = 0; i < publicationYear.Length; i++)
                    {
                        publicationYear[i] = Int32.Parse(dt.Rows[i]["publicationYear"].ToString());
                    }

                    
                    int n = publicationYear.Length;
                    for (int i = 1; i < n; i++)
                    {
                        int key = publicationYear[i];
                        int j = i - 1;
                        while (j >= 0 && publicationYear[j] > key)
                        {
                            publicationYear[j + 1] = publicationYear[j];
                            j--;
                        }
                        publicationYear[j + 1] = key;
                    }
                    dataGridView1.Columns.Add("Index", "Publication-Year");
                    dataGridView1.Columns.Add("Index", "ISBN");
                    dataGridView1.Columns.Add("Index", "Title");
                    dataGridView1.Columns.Add("Index", "Author");
                    dataGridView1.Columns.Add("Index", "Book-Quantity");



                    for (int i=0; i< publicationYear.Length; i++)
                    {
                      


                        SqlDataAdapter isbnNo = new SqlDataAdapter($"select isbn_no from Book where" +
                            $" publicationYear={publicationYear[i]}", connection);
                        
                        SqlDataAdapter title = new SqlDataAdapter($"select title from Book where" +
                            $" publicationYear={publicationYear[i]}", connection);
                        SqlDataAdapter author = new SqlDataAdapter($"select author from Book where" +
                            $" publicationYear={publicationYear[i]}", connection);
                        SqlDataAdapter bookQuantity = new SqlDataAdapter($"select book_quantity from Book where" +
                            $" publicationYear={publicationYear[i]}", connection);
                        DataTable isbnTable = new DataTable();
                        DataTable titleTable = new DataTable();
                        DataTable authorTable = new DataTable();
                        DataTable bookQuantityTable = new DataTable();

                        isbnNo.Fill(isbnTable);
                        title.Fill(titleTable);
                        author.Fill(authorTable);
                        bookQuantity.Fill(bookQuantityTable);
                        dataGridView1.Rows.Add( new Object[] {publicationYear[i].ToString(),
                            isbnTable.Rows[0]["isbn_no"].ToString(),
                            titleTable.Rows[0]["title"].ToString(),
                            authorTable.Rows[0]["author"].ToString(),
                            bookQuantityTable.Rows[0]["book_quantity"].ToString()
                        });

                        
                       
                        //dataGridView1.Rows.Add(isbnNo.ToString());
                        //dataGridView1.Rows.Add(title.ToString());
                        //dataGridView1.Rows.Add(author.ToString());
                        //dataGridView1.Rows.Add(bookQuantity.ToString());

                    }
                    /*Insertion Sort is done */


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }
        private void sortByTitle () // Use Bubble sort
        {
            dataGridView1.DataSource = null;
            try
            {
                string ConString = "server=.; database=LMS; integrated security=true;";
                using (SqlConnection connection = new SqlConnection(ConString))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select title from Book", connection);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    int s = dt.Rows.Count;
                    String[] title = new String[s];
                    for (int i = 0; i < title.Length; i++)
                    {
                        title[i] = dt.Rows[i]["title"].ToString();
                    }

                    /* Bubble Sort Algorithm*/

                    String temp;

                    // Sorting strings using bubble sort
                    for (int j = 0; j < title.Length - 1; j++)
                    {
                        for (int i = j + 1; i < title.Length; i++)
                        {
                            if (title[j].CompareTo(title[i]) > 0)
                            {
                                temp = title[j];
                                title[j] = title[i];
                                title[i] = temp;
                            }
                        }
                    }

                    dataGridView1.Columns.Add("Index", "Publication-Year");
                    dataGridView1.Columns.Add("Index", "ISBN");
                    dataGridView1.Columns.Add("Index", "Title");
                    dataGridView1.Columns.Add("Index", "Author");
                    dataGridView1.Columns.Add("Index", "Book-Quantity");


                    //dataGridView1.Columns.Add("Index", "Title");
                    //dataGridView1.Columns.Add("Index", "ISBN");
                    //dataGridView1.Columns.Add("Index", "Publication-Year");
                    //dataGridView1.Columns.Add("Index", "Author");
                    //dataGridView1.Columns.Add("Index", "Book-Quantity");



                    for (int i = 0; i < title.Length; i++)
                    {

                        SqlDataAdapter isbnNo = new SqlDataAdapter($"select isbn_no from Book where" +
                            $" title={title[i]}", connection);

                        SqlDataAdapter publicationYear = new SqlDataAdapter($"select publicationYear from Book where" +
                            $" title={title[i]}", connection);
                        SqlDataAdapter author = new SqlDataAdapter($"select author from Book where" +
                            $" title={title[i]}", connection);
                        SqlDataAdapter bookQuantity = new SqlDataAdapter($"select book_quantity from Book where" +
                            $" title={title[i]}", connection);
                        DataTable isbnTable = new DataTable();
                        DataTable publicationYearTable = new DataTable();
                        DataTable authorTable = new DataTable();
                        DataTable bookQuantityTable = new DataTable();

                        isbnNo.Fill(isbnTable);
                        publicationYear.Fill(publicationYearTable);
                        author.Fill(authorTable);
                        bookQuantity.Fill(bookQuantityTable);
                        dataGridView1.Rows.Add(new Object[] {dt.Rows[0]["title"].ToString(),
                            isbnTable.Rows[0]["isbn_no"].ToString(),
                            publicationYearTable.Rows[0]["publicationYear"].ToString(),
                            authorTable.Rows[0]["author"].ToString(),
                            bookQuantityTable.Rows[0]["book_quantity"].ToString()
                        });



                        //dataGridView1.Rows.Add(isbnNo.ToString());
                        //dataGridView1.Rows.Add(title.ToString());
                        //dataGridView1.Rows.Add(author.ToString());
                        //dataGridView1.Rows.Add(bookQuantity.ToString());

                    }
                    /*Insertion Sort is done */


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

      

        private void sortingByAuthor() // use Selection Sort
        {

        }

        private void SortByYear_Click(object sender, EventArgs e)
        {
            sortingByPublicationYear();
        }

        private void SortByTitle_Click(object sender, EventArgs e)
        {
            sortByTitle();

        }
    }
}
