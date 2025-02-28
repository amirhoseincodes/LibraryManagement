using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbManagement.Repository
{
    internal interface ILoanRepository
    {
        public bool LoanCheck(int contactId, DataGridView member);

        public bool Loan(int contactId, int bookId, DataGridView member, DataGridView book);

        public bool LoanBack(int contactId, int bookId, DataGridView member, DataGridView book);

    }
}
