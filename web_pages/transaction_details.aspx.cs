using Microsoft.Reporting.WebForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SLIPGENERATION_MASTER.web_pages
{
    public partial class transaction_details : System.Web.UI.Page
    {
        string connectionString = "Data Source=SUHANI\\SQLEXPRESS;Initial Catalog=slipgenerator;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string trnId1 = Request.QueryString["trn_id"];
                if (!string.IsNullOrEmpty(trnId1))
                {
                    LoadTransactionDetails(trnId1);
                }
            }
        }

        private void GetV()
        {
            ReportViewer1.LocalReport.Refresh();
        }

        private void LoadTransactionDetails(string trnId)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Slip_view WHERE trn_id = @trn_id", sqlCon);
                sqlCmd.Parameters.AddWithValue("@trn_id", trnId);
                //SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                SqlDataAdapter d = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable();
                d.Fill(dt);
                //if (sqlReader.Read())
                {
                    //lblTransactionId.Text = "Transaction ID: " + sqlReader["trn_id"].ToString();
                    ReportViewer1.LocalReport.DataSources.Clear();
                    ReportDataSource source = new ReportDataSource("Slip_view_dataset", dt);
                    ReportViewer1.LocalReport.ReportPath = "Diesel_report.rdlc";
                    ReportViewer1.LocalReport.DataSources.Add(source);
                    GetV();
                    //}
                    sqlCon.Close();
                }
            }
        }
    }
}
