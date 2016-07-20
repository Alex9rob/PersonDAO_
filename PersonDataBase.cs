using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace WindowsFormsApplication9F
{
    public class PersonDataBase: PersonDAO
    {
        SqlConnection connection;
        public void connect()
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ort\code\WihFormsDB\WindowsFormsApplication9\WindowsFormsApplication9\Database9.mdf;Integrated Security=True;Connect Timeout=30";

            connection = new SqlConnection(ConnectionString);
            connection.Open();
        }
        public void add(Person p)
        {
            string sql = string.Format("Insert Person (ID,FName,Lname,Age) Values(@ID,@FName, @LName, @Age)");
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@ID", p.ID);
            cmd.Parameters.AddWithValue("@FName", p.FName);
            cmd.Parameters.AddWithValue("@LName", p.LName);
            cmd.Parameters.AddWithValue("@Age", p.Age);
            cmd.ExecuteNonQuery();
        }
        public void del(Person p)
        {
            string sql = "delete from [dbo].[Person] where Id = " + p.ID.ToString();
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
        }
        public void update(Person p)
        {
            del(p);
            add(p);
        }
        public List<Person> read()
        {
            string str = @"select * from  [dbo].[Person];";
            SqlCommand cmd = new SqlCommand(str, connection);
            SqlDataReader dat = cmd.ExecuteReader();
            List<Person> list = new List<Person>();
            while (dat.Read())
            {
                Person newItem = new Person();
                newItem.ID = dat.GetInt32(0);
                newItem.FName = dat.GetString(1);
                newItem.LName = dat.GetString(2);
                newItem.Age = dat.GetInt32(3);
                list.Add(newItem);
            }
            dat.Close();
            return list;
        }
    }
}
