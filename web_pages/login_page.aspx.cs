using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SLIPGENERATION_MASTER.web_pages
{
    public partial class login_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SUHANI\\SQLEXPRESS;Initial Catalog=slipgenerator;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            
            string query = "SELECT * FROM login_table WHERE username = @username AND password = @password;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;

            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                
                Session["user"] = "admin";
                Response.Redirect("input_page.aspx");

            }
            else
            {
                Response.Write("<script>alert('login error');</script>");
            }
            dr.Close();
            cmd.Connection.Close();

        }

    }
}