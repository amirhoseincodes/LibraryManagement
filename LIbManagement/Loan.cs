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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LIbManagement
{
    public partial class Loan : Form
    {
        IBookRepository repository;
        IMemberRepository memberRepository;
        public Loan()
        {
            InitializeComponent();
            repository = new BookRepository();
            memberRepository = new MemberRepository();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Loan_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = memberRepository.SellectAll();

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = repository.SellectAll();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BindGride()
        {
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = repository.SellectAll();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = memberRepository.SellectAll();

        }
        private void button1_Click(object sender, EventArgs e)
        {

            int contactId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            int bookId = int.Parse(dataGridView2.CurrentRow.Cells[3].Value.ToString());

            if (dataGridView2.CurrentRow.Cells[2].Value.ToString() == "موجود")
            {
                LoanRepository loan = new LoanRepository();
                if (loan.LoanCheck(contactId, dataGridView1))
                {
                    loan.Loan(contactId, bookId, dataGridView1, dataGridView2);
                    MessageBox.Show("کتاب با موفقیت واگذاری شد!");

                    BindGride();

                }
            }
            else
            {
                MessageBox.Show("کتاب مد نظر در دسترس نیست و یحتمل توسط شخص دیگری قرض گرفته شده ", "توجه");

            }



        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int contactId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            int bookId = int.Parse(dataGridView2.CurrentRow.Cells[3].Value.ToString());

            if (dataGridView2.CurrentRow.Cells[2].Value.ToString() == "ناموجود")
            {
                LoanRepository loan = new LoanRepository();

                loan.LoanBack(contactId, bookId,dataGridView1,dataGridView2);
                MemberRepository member = new MemberRepository();
                member.Update(int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()) + 1, contactId);
                BindGride();


            }
            else
            {
                MessageBox.Show("کتاب مد نظر را شما برنداشته اید خیالتان از عواقب دنیوی و اخروی این موضوع راحت باشد. ", "توجه");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = memberRepository.Search(textName.Text);

        }

        private void textBookName_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = repository.Search(textBookName.Text);

        }
    }
}
