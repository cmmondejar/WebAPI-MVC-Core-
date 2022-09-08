using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPPMVC.Models
{
    public class DBUser
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-I0PP50M9\\MSSQLSERVER3;Initial Catalog=myDB;Integrated Security=True;User ID=sa;password=269842327");

        public string LoginCheck(UserLogin user)
        {
            SqlCommand cmd = new SqlCommand("SP_LOGIN", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", user.UserName);
            cmd.Parameters.AddWithValue("@UserPassword", user.UserPassword);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string res = dr["Role"].ToString();
            con.Close();
            return res;

        }

    }
}
