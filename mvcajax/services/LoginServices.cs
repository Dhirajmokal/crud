using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using mvcajax.Models;


namespace mvcajax.services
{
    public class LoginServices
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["connection"]);
        public void postuser(Models.Login namedata) 
        { 

            SqlCommand cmd = new SqlCommand("postuser", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", namedata.Username);
           
            cmd.Parameters.AddWithValue("@pass", namedata.Password);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void putuser(Models.Login namedata)
        {
            SqlCommand cmd = new SqlCommand("putuser", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", namedata.Id);
            cmd.Parameters.AddWithValue("@Username", namedata.Username);
          
            cmd.Parameters.AddWithValue("@pass", namedata.Password);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void deleteuser(Models.Login namedata)
        {
            SqlCommand cmd = new SqlCommand("deleteuser", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
          
            cmd.Parameters.AddWithValue("@Id", namedata.Id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}