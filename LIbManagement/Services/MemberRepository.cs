using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;



namespace LIbManagement
{
    class MemberRepository : IMemberRepository
    {
        public string connectionString = "Data Source=.;Initial Catalog=Member_DB;Integrated Security=true";
        public bool Delete(int memberId)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                string query = "Delete From memberTable where memberId=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", memberId);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally { connection.Close(); }
        }

        public bool Insert(string name, string family, string type, float point)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Insert Into memberTable (name,family,memberType,point) values (@name,@family,@memberType,@point)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@family", family);
                command.Parameters.AddWithValue("@memberType", type);
                command.Parameters.AddWithValue("@point", point);

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
            string query = "Select * From memberTable";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable SellectRow(int memberId)
        {
            string query = "Select * From memberTable where memberId=" + memberId;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public bool Update(string name, string family, string type, int point, int memberId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Update memberTable set name=@Name,family=@Family,memberType=@Type,point=@Point where memberId=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", memberId);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Type", type);
                command.Parameters.AddWithValue("@Family", family);
                command.Parameters.AddWithValue("@Point", point);

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
        public bool Update(int point, int memberId)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Update memberTable set point=@Point where memberId=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", memberId);
                command.Parameters.AddWithValue("@Point", point);

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
            string query = "Select * From memberTable where name like @str or family like @str";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@str", "%" + text + "%");

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;



        }


    }
}
