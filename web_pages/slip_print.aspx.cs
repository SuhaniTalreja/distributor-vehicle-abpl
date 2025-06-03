using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SLIPGENERATION_MASTER.web_pages
{
    public partial class slip_print : System.Web.UI.Page
    {
        string connectionString = "Data Source=SUHANI\\SQLEXPRESS;Initial Catalog=slipgenerator;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTransactions();
                LoadGridView();
            }
        }

        private void LoadTransactions()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SELECT trn_id FROM Slip_view", sqlCon);
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                trn_input.Items.Clear();
                trn_input.Items.Add(new ListItem("Select Transaction ID", ""));
                while (sqlReader.Read())
                {
                    trn_input.Items.Add(new ListItem(sqlReader["trn_id"].ToString(), sqlReader["trn_id"].ToString()));
                }
            }
        }

        private void LoadGridView(string transactionId = "")
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa;
                if (string.IsNullOrEmpty(transactionId) || transactionId == "Select Transaction ID")
                {
                    sqlDa = new SqlDataAdapter("SELECT * FROM Slip_view", sqlCon);
                }
                else
                {
                    sqlDa = new SqlDataAdapter("SELECT * FROM Slip_view WHERE trn_id = @trn_id", sqlCon);
                    sqlDa.SelectCommand.Parameters.AddWithValue("@trn_id", transactionId);
                }
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                gv.DataSource = dtbl;
                gv.DataBind();
            }
        }

        protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ViewDetails")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gv.Rows[index];
                string trnId = row.Cells[0].Text;
                Response.Redirect("transaction_details.aspx?trn_id=" + trnId);
            }
        }

        protected void trn_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTrnId = trn_input.SelectedValue;
            LoadGridView(selectedTrnId);
        }
    }
}
