using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace LIbManagement
{
    internal interface IMemberRepository
    {

        bool Insert(string name, string family, string type, float point);

        bool Update(string name, string family,string type,int point, int memberId);
        public bool Update(int point, int memberId);

        bool Delete(int memberId);

        DataTable SellectAll();
        DataTable SellectRow(int memberId);
        DataTable Search(string text);

    }
}
