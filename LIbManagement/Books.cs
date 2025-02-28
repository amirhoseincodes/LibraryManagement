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
    public partial class Books : Form
    {
        IBookRepository repository;

        public Books()
        {
            InitializeComponent();
            repository = new BookRepository();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Books_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = repository.SellectAll();
        }

        private void BindGride()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = repository.SellectAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                string name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (MessageBox.Show($"آیا از حذف {name} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int bookId = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    repository.Delete(bookId);
                    HistoryRepository his = new HistoryRepository();
                    DateTime dateTime = DateTime.Now;
                    his.Insert("", " حذف کتاب", dataGridView1.CurrentRow.Cells[0].Value.ToString(), dateTime.ToString(),0, int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()));

                    BindGride();

                }
            }
            else
            {
                MessageBox.Show("لطفا یک کتاب را از لیست انتخاب کنید.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddOrEditBook addOrEditBook = new AddOrEditBook();
            HistoryRepository his = new HistoryRepository();
            DateTime dateTime = DateTime.Now;
            his.Insert("", " افزودن کتاب", "", dateTime.ToString(), 0,0);

            addOrEditBook.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindGride();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int contactId = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                AddOrEditBook contact = new AddOrEditBook();
                contact.addoreditid = contactId; 
                
                HistoryRepository his = new HistoryRepository();
                    DateTime dateTime = DateTime.Now;
                    his.Insert("", " ویرایش کتاب", dataGridView1.CurrentRow.Cells[0].Value.ToString(), dateTime.ToString(), 0, int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()));

                if (contact.ShowDialog() == DialogResult.OK)
                {
                   
                    BindGride();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repository.Search(textBox1.Text);

        }

        private void excelExport_Click(object sender, EventArgs e)
        {
            HistoryRepository his = new HistoryRepository();
            DateTime dateTime = DateTime.Now;
            his.Insert("", " خروجی اکسل کتابها", "", dateTime.ToString(), 0, 0);

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
    }
}
