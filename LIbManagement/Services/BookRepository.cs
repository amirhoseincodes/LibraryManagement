using LIbManagement.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbManagement.Services
{
    class BookRepository : IBookRepository
    {
        public string connectionString = "Data Source=.;Initial Catalog=Member_DB;Integrated Security=true";
        public bool Delete(int bookId)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                string query = "Delete From bookTable where bookId=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", bookId);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally { connection.Close(); }
        }
        public bool Insert(string name, string author, string genre, int date)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Insert Into bookTable (name,author,date,genre) values (@name,@author,@date,@genre)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@author", author); 
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@genre", genre);


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
            string query = "Select * From bookTable";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable SellectRow(int bookId)
        {
            string query = "Select * From bookTable where bookId=" + bookId;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public bool Update(string name, string author, string genre, int date, int bookId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Update  bookTable set  name=@Name,author=@Author,date=@Date,genre=@Genre where bookId=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", bookId);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Author", author);
                command.Parameters.AddWithValue("@Genre", genre);
                command.Parameters.AddWithValue("@Date", date);


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
        public bool Update( int bookId,string available)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Update bookTable set available=@Available where bookId=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", bookId);
                command.Parameters.AddWithValue("@Available", available);


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
        public DataTable Search(string text)
        {
            string query = "Select * From bookTable where name like @str or author like @str";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@str", "%" + text + "%");

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;



        }
    }
}
