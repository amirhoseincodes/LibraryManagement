//using LIbManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LIbManagement
{
    public partial class AddOrEdit : Form
    {
        IMemberRepository Repository;

        public int addoreditid = 0;
        public AddOrEdit()
        {
            Repository = new MemberRepository();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        bool ValidateInputs()
        {
            if (textName.Text == "")
            {
                MessageBox.Show("لطفا نام را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textFamily.Text == "")
            {
                MessageBox.Show("لطفا نام خانوادگی را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textType.Text == "")
            {
                MessageBox.Show("لطفا نوع کاربر را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() && addoreditid == 0)
            {
                bool isSuccess = Repository.Insert(textName.Text, textFamily.Text, textType.Text, (int)textPoint.Value);

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
                bool isSuccess = Repository.Update(textName.Text, textFamily.Text, textType.Text, (int)textPoint.Value, addoreditid);

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

        private void AddOrEdit_Load(object sender, EventArgs e)
        {
            if (addoreditid == 0)
            {
                this.Text = "افزودن شخص";

            }
            else
            {
                this.Text = "ویرایش شخص";
                DataTable dt = Repository.SellectRow(addoreditid);
                textName.Text = dt.Rows[0][0].ToString();
                textFamily.Text = dt.Rows[0][1].ToString();
                textType.Text = dt.Rows[0][3].ToString();
                textPoint.Value = Convert.ToInt32(dt.Rows[0][4].ToString());

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() && addoreditid == 0)
            {
                bool isSuccess = Repository.Insert(textName.Text, textFamily.Text, textType.Text, (int)textPoint.Value);

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
                bool isSuccess = Repository.Update(textName.Text, textFamily.Text, textType.Text, (int)textPoint.Value, addoreditid);

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
    }
}
