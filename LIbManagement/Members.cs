using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using LIbManagement.Services;

namespace LIbManagement
{
    public partial class Members : Form
    {
        IMemberRepository repository;
        public Members()
        {
            InitializeComponent();
            repository = new MemberRepository();
        }

        private void Members_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = repository.SellectAll();
        }


        private void BindGride()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = repository.SellectAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repository.Search(textBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindGride();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HistoryRepository his = new HistoryRepository();
            DateTime dateTime = DateTime.Now;
            his.Insert("", " افزودن شخص", "", dateTime.ToString(), 0, 0);

            AddOrEdit addOrEdit = new AddOrEdit();
            addOrEdit.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                string name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string family = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string fullname = name + " " + family;
                if (MessageBox.Show($"آیا از حذف {fullname}مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int contactId = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    repository.Delete(contactId);

                    HistoryRepository his = new HistoryRepository();
                    DateTime dateTime = DateTime.Now;
                    string relatedUser = dataGridView1.CurrentRow.Cells[0].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    his.Insert(relatedUser, "حذف شخص", "", dateTime.ToString(), int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()), 0);

                    BindGride();

                }
            }
            else
            {
                MessageBox.Show("لطفا یک شخص را از لیست انتخاب کنید.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {

                int contactId = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                AddOrEdit contact = new AddOrEdit();
                contact.addoreditid = contactId;
                if (contact.ShowDialog() == DialogResult.OK)
                {
                    BindGride();
                }

                HistoryRepository his = new HistoryRepository();
                DateTime dateTime = DateTime.Now;
                string relatedUser = dataGridView1.CurrentRow.Cells[0].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[1].Value.ToString();
                his.Insert(relatedUser, "ویرایش شخص", "", dateTime.ToString(), int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()), 0);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HistoryRepository his = new HistoryRepository();
            DateTime dateTime = DateTime.Now;
            his.Insert("", " خروجی اکسل اعضا", "", dateTime.ToString(), 0, 0);

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridview";

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {

                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;

            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            app.Quit();
        }

        private void excelImport_Click(object sender, EventArgs e)
        {

        }
    }
}



