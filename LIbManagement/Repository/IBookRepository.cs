using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbManagement.Repository
{
    internal interface IBookRepository
    {
        bool Insert(string name, string author,string genre, int date);

        bool Update(string name, string author,string genre, int date, int bookId);
        bool Update( int bookId,string available);

        bool Delete(int bookId);

        DataTable SellectAll();
        DataTable SellectRow(int bookId);
        DataTable Search(string text);
    }
}
