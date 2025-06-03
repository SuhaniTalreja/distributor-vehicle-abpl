using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SLIPGENERATION_MASTER.web_pages
{
    public partial class create_vehicle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtAvg.Text = "";
            txtVehicleNo.Text = "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=SUHANI\\SQLEXPRESS;Initial Catalog=slipgenerator;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string insertQuery = "INSERT INTO vehicles (vehicle_num, vehicle_avg) VALUES (@vehicle_num, @vehicle_avg)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.Add("@vehicle_num", System.Data.SqlDbType.NVarChar, 50).Value = txtVehicleNo.Text;
                        cmd.Parameters.Add("@vehicle_avg", System.Data.SqlDbType.Decimal).Value = Convert.ToDecimal(txtAvg.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Response.Write("<script>alert('Vehicle added successfully.');</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('Failed to add Vehicle');</script>");
                        }
                    }
                }
                catch (Exception ex)
                {

                    Response.Write("Error: " + ex.Message);
                }

                txtAvg.Text = "";
                txtVehicleNo.Text = "";
            }
        }
    }
}
