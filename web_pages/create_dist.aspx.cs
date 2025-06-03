using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SLIPGENERATION_MASTER.web_pages
{
    public partial class create_dist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtDistriName.Text = "";
            txtDCode.Text = "";
            txtEmail.Text = "";
            txtMobileNum.Text = "";
            txtDistance.Text = "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=SUHANI\\SQLEXPRESS;Initial Catalog=slipgenerator;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            string insertQuery = "INSERT INTO distributors (dist_name, dist_code, dist_email, dist_phone,dist_distance) VALUES (@dist_name, @dist_code, @dist_email, @dist_phone,@dist_distance)";


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {

                    con.Open();


                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {

                        cmd.Parameters.AddWithValue("@dist_name", txtDistriName.Text);
                        cmd.Parameters.AddWithValue("@dist_code", txtDCode.Text);
                        cmd.Parameters.AddWithValue("@dist_email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@dist_phone", txtMobileNum.Text);
                        cmd.Parameters.AddWithValue("@dist_distance", txtDistance.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Response.Write("<script>alert('Distributor added successfully.');</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('Failed to add Distributor');</script>");
                        }
                    }
                }
                catch (Exception ex)
                {

                    Response.Write("Error: " + ex.Message);
                }

                txtDistriName.Text = "";
                txtDCode.Text = "";
                txtEmail.Text = "";
                txtMobileNum.Text = "";
                txtDistance.Text = "";
            }
        }
    }
}
