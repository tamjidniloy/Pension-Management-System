using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pension_Management_System
{
    public partial class Monthly_Pension_Process : Form
    {
        private Form previousForm;
        string connectionString = @"Server = Tanha\SQLEXPRESS;Initial Catalog=Pension Management System;Integrated Security=True;";
        public Monthly_Pension_Process(Form previousForm)
        {
            InitializeComponent();
            LoadMonthlyStatusGrid();
            this.previousForm = previousForm;
        }

       private void RefreshForm()
        {
            txtID.Clear();
            txtName.Clear();
            txtMethod.Clear();
            txtMonthlyPension.Clear();
            txtCurrentBalance.Clear();
            txtTotalAccrued.Clear();
            txtSearch.Clear();
            LoadMonthlyStatusGrid();
        }

        private void LoadMonthlyStatusGrid()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT  
                p.Pensioner_Id,
                p.Full_Name,
                pa.Monthly_Pension,
                pm.Payment_Method_Name,
                pa.Current_Balance,
                pa.Total_Month_Accrued
            FROM Pensioners p
            INNER JOIN Pensioner_Accounts pa ON p.Pensioner_Id = pa.Pensioner_Id
            INNER JOIN PaymentMethods pm ON pa.Payment_Method_Id = pm.Payment_Method_Id
            LEFT JOIN PensionLedger pl ON pa.PensionerAccountId = pl.PensionerAccountId
            WHERE p.IsActive = 1
            GROUP BY 
                p.Pensioner_Id,
                p.Full_Name,
                pa.Monthly_Pension,
                pm.Payment_Method_Name,
                pa.Current_Balance,
                pa.Total_Month_Accrued
            ORDER BY p.Pensioner_Id DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvMonthlyStatus.DataSource = dt;
                    dgvMonthlyStatus.AutoGenerateColumns = false;
                    dgvMonthlyStatus.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load monthly status.\n" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void Monthly_Pension_Process_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMonthlyStatusGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMonthlyStatus_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtID.Clear();
                txtName.Clear();
                txtMethod.Clear();
                txtMonthlyPension.Clear();
                txtCurrentBalance.Clear();
                txtTotalAccrued.Clear();
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvMonthlyStatus.Rows[e.RowIndex];
                    txtID.Text = row.Cells["Pensioner_Id"].Value.ToString();
                    txtName.Text = row.Cells["Full_Name"].Value.ToString();
                    txtMonthlyPension.Text = row.Cells["Monthly_Pension"].Value.ToString();
                    txtMethod.Text = row.Cells["Payment_Method_Name"].Value.ToString();
                    txtCurrentBalance.Text = row.Cells["Current_Balance"].Value.ToString();
                    txtTotalAccrued.Text = row.Cells["Total_Month_Accrued"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load row data.\n" + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT  
                p.Pensioner_Id,
                p.Full_Name,
                pa.Monthly_Pension,
                pm.Payment_Method_Name,
                pa.Current_Balance,
                pa.Total_Month_Accrued
            FROM Pensioners p
            INNER JOIN Pensioner_Accounts pa ON p.Pensioner_Id = pa.Pensioner_Id
            INNER JOIN PaymentMethods pm ON pa.Payment_Method_Id = pm.Payment_Method_Id
            WHERE p.IsActive = 1 AND (p.Pensioner_Id LIKE '%' + @Search + '%'OR p.Full_Name LIKE '%' + @Search + '%') ORDER BY p.Pensioner_Id DESC";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Search", txtSearch.Text.Trim());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMonthlyStatus.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed.\n" + ex.Message);
            }
        }

        private void btnRunMonthlyPension_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // 1️⃣ Get all active pensioner accounts
                    string getAccountsQuery = @"SELECT 
                                                pa.PensionerAccountId,
                                                pa.Pensioner_Id,
                                                pa.Monthly_Pension,
                                                pa.Current_Balance,
                                                pa.Total_Month_Accrued,
                                                pa.Total_Pension_Accrued
                                                FROM Pensioner_Accounts pa
                                                INNER JOIN Pensioners p ON p.Pensioner_Id = pa.Pensioner_Id
                                                WHERE pa.IsActive = 1 AND p.IsActive = 1";
                    SqlCommand getCmd = new SqlCommand(getAccountsQuery, con);
                    SqlDataReader dr = getCmd.ExecuteReader();
                    DataTable dtAccounts = new DataTable();
                    dtAccounts.Load(dr);
                    dr.Close();

                    foreach (DataRow row in dtAccounts.Rows)
                    {
                        int pensionerId = Convert.ToInt32(row["Pensioner_Id"]);
                        int accountId = Convert.ToInt32(row["PensionerAccountId"]);
                        decimal monthlyAmount = Convert.ToDecimal(row["Monthly_Pension"]);
                        decimal currentBalance = Convert.ToDecimal(row["Current_Balance"]);
                        int totalMonths = Convert.ToInt32(row["Total_Month_Accrued"]);
                        decimal totalPension = Convert.ToDecimal(row["Total_Pension_Accrued"]);

                        // 3️⃣ Calculate updated values
                        decimal newBalance = currentBalance + monthlyAmount;
                        int newTotalMonths = totalMonths + 1;
                        decimal newTotalPension = totalPension + monthlyAmount;

                        // 4️⃣ Update Pensioner Account (FULL UPDATE)
                        string updateAccountQuery = @"UPDATE Pensioner_Accounts SET 
                                                    Current_Balance = @Balance,
                                                    Total_Month_Accrued = @Months,
                                                    Total_Pension_Accrued = @TotalPension
                                                    WHERE PensionerAccountId = @AccId";
                        SqlCommand updateCmd = new SqlCommand(updateAccountQuery, con);
                        updateCmd.Parameters.AddWithValue("@Balance", newBalance);
                        updateCmd.Parameters.AddWithValue("@Months", newTotalMonths);
                        updateCmd.Parameters.AddWithValue("@TotalPension", newTotalPension);
                        updateCmd.Parameters.AddWithValue("@AccId", accountId);
                        updateCmd.ExecuteNonQuery();

                        // 5️⃣ Insert Ledger Entry (Credit)
                        string insertLedgerQuery = @"INSERT INTO PensionLedger
                                                   (Pensioner_Id, PensionerAccountId, Credit_Amount, Balance) VALUES (@Pid, @AccId, @Credit, @Balance)";
                        SqlCommand ledgerCmd = new SqlCommand(insertLedgerQuery, con);
                        ledgerCmd.Parameters.AddWithValue("@Pid", pensionerId);
                        ledgerCmd.Parameters.AddWithValue("@AccId", accountId);
                        ledgerCmd.Parameters.AddWithValue("@Credit", monthlyAmount);
                        ledgerCmd.Parameters.AddWithValue("@Balance", newBalance);
                        ledgerCmd.ExecuteNonQuery();
                    }
                }
                LoadMonthlyStatusGrid();
                MessageBox.Show("The monthly pension process has been completed successfully.","Process Completed",MessageBoxButtons.OK,MessageBoxIcon.Information);
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Monthly pension process failed.\n" + ex.Message);
            }
        }
    }
}
