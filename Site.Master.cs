using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SLIPGENERATION_MASTER
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var user_name = (string)Session["user"];

            SqlConnection con = new SqlConnection("Data Source=SUHANI\\SQLEXPRESS;Initial Catalog=slipgenerator;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            if (user_name != "admin")
            {
                Response.Redirect("denied.aspx");
            }

        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {   
            Session["user"] = null;
            Response.Redirect("login_page.aspx");
        }
    }
}