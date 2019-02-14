using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PrimaryInput
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            Serialiaze.DeserializationFromXml<List<Book>>(ref book, "books.xml");
            if (book.Count != 0)
            {
                DgvKatalog.Rows.Clear();
                for (int i = 0; i < book.Count; i++)
                {
                    DgvKatalog.Rows.Add(book[i].kode, book[i].author, book[i].name, book[i].city, book[i].pubHouse, book[i].year, book[i].page, book[i].instance, book[i].image, book[i].cd);
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        void ClearForm()
        {
            lbCode.Text = "";
            lbKode.Text = "";

            lbAuthor.Text = "";

            tbName.Text = "";
            lbName.Text = "";
            tbName.BackColor = Color.White;

            tbCity.Text = "";
            lbCity.Text = "";
            tbCity.BackColor = Color.White;

            tbPubHouse.Text = "";
            lbPubHouse.Text = "";
            tbPubHouse.BackColor = Color.White;

            tbYear.Text = "";
            lbYear.Text = "";
            tbYear.BackColor = Color.White;

            tbPage.Text = "";
            tbPage.BackColor = Color.White;

            tbInstance.Text = "";
            tbInstance.BackColor = Color.White;

            lbPage.Text = "";

            lbInstance.Text = "";

            rbImage.Checked = false;
            rbCD.Checked = false;
           
        }

        public List<Book> book = new List<Book>();

        Regex text = new Regex(@"^[а-яА-ЯёЁа-яА-ЯіІa-zA-Z\s]{1,}$");

        private void btWrite_Click(object sender, EventArgs e)
        {
            Serialiaze.SerialiazeToXml<List<Book>>(ref book, "books.xml");

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //if (text.IsMatch(tbKode.Text))
            //{
                lbCode.Text = lbCode.Text + tbKode.Text + ", ";
                tbKode.Text = "";
                tbKode.BackColor = Color.White;
                lbKode.Text = "";
            //}
            //else
            //{
            //    tbKode.Clear();
            //    tbKode.BackColor = Color.Red;
            //    lbKode.Text = "Введено цифру або другий \n некоректний символ";
            //}
            
        }

        private void btAddTwo_Click(object sender, EventArgs e)
        {
            //Regex name = new Regex(@"^[A-ZА-Я][а-яёЁіІa-z]+\s+[А-яіІA-Z]\.\s+[А-яіІA-Z]\.$");
            //Regex name = new Regex(@"^[A-ZА-Я][а-яёЁіІa-z]+\s+[А-ЯІA-Z]\.+\s+[А-ЯІA-Z]\.");

            //if (name.IsMatch(tbAuthor.Text))
            //{
                lbAuthor.Text = lbAuthor.Text + tbAuthor.Text + ", ";
                tbAuthor.Text = "";
                tbAuthor.BackColor = Color.White;
                lbAuthors.Text = "";
            //}
            //else
            //{
            //    tbAuthor.Clear();
            //    tbAuthor.BackColor = Color.Red;
            //    lbAuthors.Text = "Введено цифру або другий некоректний символ";
            //}
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Regex year = new Regex (@"^[0-9]{4,4}$");
            Regex num = new Regex(@"^[0-9]+$");

            if (!text.IsMatch(tbName.Text))
            {
                tbName.Clear();
                tbName.BackColor = Color.Red;
                lbName.Text = "Введено цифру або другий непідходящий символ";
            }
            else
            {
                if (!text.IsMatch(tbCity.Text))
                {
                    tbCity.Clear();
                    tbCity.BackColor = Color.Red;
                    lbCity.Text = "Введено цифру або другий непідходящий символ";
                }
                else
                {
                    if (!text.IsMatch(tbPubHouse.Text))
                    {
                        tbPubHouse.Clear();
                        tbPubHouse.BackColor = Color.Red;
                        lbPubHouse.Text = "Введено цифру або другий непідходящий символ";
                    }
                    else
                    {
                        if (!year.IsMatch(tbYear.Text))
                        {
                            tbYear.Clear();
                            tbYear.BackColor = Color.Red;
                            lbYear.Text = "Наприклад '2000'";
                        }
                        else
                        {
                            if (!num.IsMatch(tbPage.Text))
                            {
                                tbPage.Clear();
                                tbPage.BackColor = Color.Red;
                                lbPage.Text = "Введено букву або інший символ";
                            }
                            else
                            {
                                if (!num.IsMatch(tbInstance.Text))
                                {
                                    tbInstance.Clear();
                                    tbInstance.BackColor = Color.Red;
                                    lbInstance.Text = "Введено букву або інший символ";
                                }
                                else
                                {
                                    Book obj = new Book(lbCode.Text, lbAuthor.Text, tbName.Text, tbCity.Text, tbPubHouse.Text, Convert.ToInt32(tbYear.Text), Convert.ToInt32(tbPage.Text), Convert.ToInt32(tbInstance.Text), rbImage.Checked, rbCD.Checked);
                                    book.Add(obj);
                                    ClearForm();

                                    if (book.Count != 0)
                                    {
                                        DgvKatalog.Rows.Clear();
                                        for (int i = 0; i < book.Count; i++)
                                        {
                                            DgvKatalog.Rows.Add(book[i].kode, book[i].author, book[i].name, book[i].city, book[i].pubHouse, book[i].year, book[i].page, book[i].instance, book[i].image, book[i].cd);
                                        }
                                    }
                                }
                            }
                            //MessageBox.Show("no");
                        }
                    }
                }
            }
            
        }

        private void lbAuthor_Click(object sender, EventArgs e)
        {

        }

        private void lbKode_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Serialiaze.SerialiazeToXml<List<Book>>(ref book, "books.xml");
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            var index = Convert.ToInt32(DgvKatalog.SelectedRows[0].Index.ToString());

            tbKode.Text = book[index].kode;
            tbAuthor.Text = book[index].author;
            tbName.Text = book[index].name;
            tbCity.Text = book[index].city;
            tbPubHouse.Text = book[index].pubHouse;
            tbYear.Text = Convert.ToString(book[index].year);
            tbPage.Text = Convert.ToString(book[index].page);
            tbInstance.Text = Convert.ToString(book[index].instance);
            rbImage.Checked = book[index].image;
            rbCD.Checked = book[index].cd;


            book.RemoveAt(index);

            DgvKatalog.Rows.Clear();

            if (book.Count != 0)
            {
                DgvKatalog.Rows.Clear();
                for (int i = 0; i < book.Count; i++)
                {
                    DgvKatalog.Rows.Add(book[i].kode, book[i].author, book[i].name, book[i].city, book[i].pubHouse, book[i].year, book[i].page, book[i].instance, book[i].image, book[i].cd);
                }
            }

        }
    }
}
    

