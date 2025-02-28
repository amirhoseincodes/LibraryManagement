using LIbManagement.Repository;
using LIbManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbManagement
{
    public partial class AddOrEditBook : Form
    {
        IBookRepository bookRepository;
        public int addoreditid = 0;

        public AddOrEditBook()
        {
            bookRepository = new BookRepository();

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        bool ValidateInputs()
        {
            if (textName.Text == "")
            {
                MessageBox.Show("لطفا نام را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textAuthor.Text == "")
            {
                MessageBox.Show("لطفا نام نویسنده را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textGenre.Text == "")
            {
                MessageBox.Show("لطفا ژانر را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            bool datevalue = true;
            try
            {
                Convert.ToInt32(textDate.Text);

            }
            catch { datevalue = false; }
            if (textDate.Text == "" && datevalue)
            {
                MessageBox.Show("لطفا تاریخ صحیح انتشار را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() && addoreditid == 0)
            {
                bool isSuccess = bookRepository.Insert(textName.Text, textAuthor.Text, textGenre.Text, Convert.ToInt32(textDate.Text));

                if (isSuccess == true)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("عملیات با شکست مواجه شد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ValidateInputs())
            {
                bool isSuccess = bookRepository.Update(textName.Text, textAuthor.Text, textGenre.Text, Convert.ToInt32(textDate.Text), addoreditid);

                if (isSuccess == true)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("عملیات با شکست مواجه شد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void AddOrEditBook_Load(object sender, EventArgs e)
        {
            if (addoreditid == 0)
            {
                this.Text = "افزودن کتاب";

            }
            else
            {
                this.Text = "ویرایش کتاب";
                DataTable dt = bookRepository.SellectRow(addoreditid);
                textName.Text = dt.Rows[0][0].ToString();
                textAuthor.Text = dt.Rows[0][2].ToString();
                textGenre.Text = dt.Rows[0][4].ToString();
                textDate.Text = dt.Rows[0][3].ToString();

            }
        }

        private void textDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
