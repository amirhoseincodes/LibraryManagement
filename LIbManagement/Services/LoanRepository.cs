using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using LIbManagement.Repository;



namespace LIbManagement.Services
{
    class LoanRepository : ILoanRepository

    {
        IMemberRepository memberRepository;
        public LoanRepository()
        {

            memberRepository = new MemberRepository();
        }
        public string connectionString = "Data Source=.;Initial Catalog=Member_DB;Integrated Security=true";

        public bool LoanCheck(int contactId, DataGridView member)
        {

            if (int.Parse(member.CurrentRow.Cells[4].Value.ToString()) > 0)
            {
                memberRepository.Update(int.Parse(member.CurrentRow.Cells[4].Value.ToString()) - 1, contactId);

                return true;
            }
            else
            {
                return false;
            }


        }

        public bool Loan(int contactId, int bookId, DataGridView member, DataGridView book)
        {
            BookRepository bookRepository = new BookRepository();

            bookRepository.Update(bookId, "ناموجود");

            HistoryRepository history = new HistoryRepository();
            DateTime dateTime = DateTime.Now;
            string relatedUser = member.CurrentRow.Cells[0].Value.ToString() + " " + member.CurrentRow.Cells[1].Value.ToString();
            history.Insert(relatedUser, "امانت گرفتن کتاب", book.CurrentRow.Cells[0].Value.ToString(), dateTime.ToString(), int.Parse(member.CurrentRow.Cells[2].Value.ToString()), int.Parse(book.CurrentRow.Cells[3].Value.ToString()));

            return true;
        }

        public bool LoanBack(int contactId, int bookId, DataGridView member, DataGridView book)
        {
            HistoryRepository history = new HistoryRepository();
            if (history.LoanHistory(contactId, bookId))
            {
                BookRepository bookRepository = new BookRepository();
                bookRepository.Update(bookId, "موجود");

                MessageBox.Show("کتاب با موفقیت پس داده شد!");

                HistoryRepository his = new HistoryRepository();
                DateTime dateTime = DateTime.Now;
                string relatedUser = member.CurrentRow.Cells[0].Value.ToString() + " " + member.CurrentRow.Cells[1].Value.ToString();
                his.Insert(relatedUser, "پس دادن کتاب", book.CurrentRow.Cells[0].Value.ToString(), dateTime.ToString(), int.Parse(member.CurrentRow.Cells[2].Value.ToString()), int.Parse(book.CurrentRow.Cells[3].Value.ToString()));

                return true;
            }
            else
            {
                MessageBox.Show("کتاب مد نظر را شما برنداشته اید خیالتان از عواقب دنیوی و اخروی این موضوع راحت باشد. ", "توجه");

                return false;
            }

        }


    }
}

