using LIbManagement.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LIbManagement.Services
{
    public class HistoryRepository : IHistory
    {
        public string connectionString = "Data Source=.;Initial Catalog=Member_DB;Integrated Security=true";

        public bool Insert(string relatedUser, string actionType, string relatedBook, string actionDate, int userId, int bookId)
        {


            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Insert Into historyTable (relatedUser,actionType,relatedBook,actionDate,userId,bookId) values (@RelatedUser,@ActionType,@RelatedBook,@ActionDate,@UserId,@BookId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RelatedUser", relatedUser);
                command.Parameters.AddWithValue("@RelatedBook", relatedBook);
                command.Parameters.AddWithValue("@ActionType", actionType);
                command.Parameters.AddWithValue("@ActionDate", actionDate);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@BookId", bookId);

                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }

            catch
            {
                return false;
            }
            finally
            {
                connection.Close();

            }
        }

        public DataTable SellectAll()
        {
            string query = "Select * From historyTable";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }



        public bool LoanHistory(int userId, int bookId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Update memberTable set userId=@UserID,bookId=@BookID  where userId=@UserID AND bookId=@BookID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userId);
                command.Parameters.AddWithValue("@BookID", bookId);

                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }

            catch
            {
                return true;
            }
            finally
            {
                connection.Close();

            }

        }
    }
}
