using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SLIPGENERATION_MASTER.web_pages
{
    public partial class input_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDistributorDropdown();
                LoadVehicleDropdown();
            }
        }

        private void LoadDistributorDropdown()
        {
            string connectionString = "Data Source=SUHANI\\SQLEXPRESS;Initial Catalog=slipgenerator;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT dist_code, dist_name FROM distributors", con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        ddlDistributorCode.Items.Clear();
                        ddlDistributorCode.Items.Add(new ListItem("Select Distributor", ""));
                        while (reader.Read())
                        {
                            ddlDistributorCode.Items.Add(new ListItem(reader["dist_code"].ToString(), reader["dist_code"].ToString()));
                        }
                    }
                }
            }
        }

        private void LoadVehicleDropdown()
        {
            string connectionString = "Data Source=SUHANI\\SQLEXPRESS;Initial Catalog=slipgenerator;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT vehicle_num FROM vehicles", con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        ddlVehicleNo.Items.Clear();
                        ddlVehicleNo.Items.Add(new ListItem("Select Vehicle", ""));
                        while (reader.Read())
                        {
                            ddlVehicleNo.Items.Add(new ListItem(reader["vehicle_num"].ToString(), reader["vehicle_num"].ToString()));
                        }
                    }
                }
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ddlDistributorCode.SelectedIndex = 0;
            txtDistributorName.Text = "";
            txtDistanceCovered.Text = "";
            txtDieselUsed.Text = "";
            ddlVehicleNo.SelectedIndex = 0;
            txtMobileNum.Text = "";
            txtVehicleAvg.Text = "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=SUHANI\\SQLEXPRESS;Initial Catalog=slipgenerator;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string insertQuery = "INSERT INTO [transaction] (dist_code, vehicle_num, dist_diesel, trn_date) VALUES (@dist_code, @vehicle_num, @dist_diesel, @trn_date)";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.Add("@dist_code", SqlDbType.NVarChar, 50).Value = ddlDistributorCode.SelectedValue;
            cmd.Parameters.Add("@vehicle_num", SqlDbType.NVarChar, 50).Value = ddlVehicleNo.SelectedValue;
            cmd.Parameters.Add("@dist_diesel", SqlDbType.Decimal).Value = Convert.ToDecimal(txtDieselUsed.Text);
            cmd.Parameters.Add("@trn_date", SqlDbType.DateTime).Value = DateTime.Now;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            string message = "Your details have been saved sucessfully.";
            string script = "window.onload = function(){ alert('";
            script += message;
            script += "')}";
            ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
            
            ddlDistributorCode.SelectedIndex = 0;
            txtDistributorName.Text = "";
            txtDistanceCovered.Text = "";
            txtDieselUsed.Text = "";
            ddlVehicleNo.SelectedIndex = 0;
            txtMobileNum.Text = "";
            txtVehicleAvg.Text = "";

        }


        protected void ddlDistributorCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlDistributorCode.SelectedIndex > 0)
            {
                string selectedDistCode = ddlDistributorCode.SelectedValue;
                FetchDistributorDetails(selectedDistCode);
            }
        }

        private void FetchDistributorDetails(string distCode)
        {
            string connectionString = "Data Source=SUHANI\\SQLEXPRESS;Initial Catalog=slipgenerator;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetDistributorDetailsByCode", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DistCode", distCode);

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtDistributorName.Text = reader["dist_name"].ToString();
                            txtDistanceCovered.Text = reader["dist_distance"].ToString();
                            txtMobileNum.Text = reader["dist_phone"].ToString();
                        }
                    }
                }
            }
        }

        protected void ddlVehicleNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlVehicleNo.SelectedIndex > 0)
            {
                string selectedVehicle = ddlVehicleNo.SelectedValue;
                FetchVehicleDetails(selectedVehicle);
            }
        }

        private void FetchVehicleDetails(string vehicleNum)
        {
            string connectionString = "Data Source=SUHANI\\SQLEXPRESS;Initial Catalog=slipgenerator;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetVehicleDetails", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VehicleNum", vehicleNum);

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtVehicleAvg.Text = reader["vehicle_avg"].ToString();
                        }
                    }
                }
            }
        }
    }
}
