using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LIbManagement.Repository
{
      interface IHistory
    {

        DataTable SellectAll();
        public bool Insert(string relatedUser, string actionType, string relatedBook, string actionDate, int userId, int bookId);

        public bool LoanHistory(int userId, int bookId);
    }
}
