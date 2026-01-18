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
    public partial class Pensioner_Accounts : Form
    {
        int selectedAccountId = 0;
        int selectedPensionerId = 0;
        string connectionString = @"Server = NILOY\SQLEXPRESS;Initial Catalog=Pension Management System;Integrated Security=True;";
        public Pensioner_Accounts()
        {
            InitializeComponent();
            LoadPensioners();
            LoadPaymentMethods();
            LoadPensionerAccountsGrid();
            RefreshForm();
        }

        private void RefreshForm()
        {
            selectedPensionerId = 0;
            txtPensionerName.Clear();
            txtPensionerNID.Clear();
            txtMonthlyPension.Clear();
            cmbPaymentMethod.SelectedIndex = -1;
            dtpPensionStartDate.Value = DateTime.Today;
            btnCreateAccount.Visible = false;
            lblPaymentMethod.Visible = false;
            cmbPaymentMethod.Visible = false;
            cmbNewPaymentMethod.SelectedIndex = -1;
            txtOldPaymentMethod.Clear();
            txtSearch.Clear();
            txtSearchPensionerAccount.Clear();
            LoadPensioners();
            LoadPaymentMethods();
            LoadPensionerAccountsGrid();
        }

        private void LoadPensioners()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                Pensioner_Id, 
                Full_Name, 
                NID_Num 
                FROM Pensioners 
                WHERE IsActive = 1
                ORDER BY Pensioner_Id DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPensioners.DataSource = dt;
                    dgvPensioners.AutoGenerateColumns = false;
                    dgvPensioners.Refresh();
                    dgvPensioners.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load pensioners.\n" + ex.Message);
            }
        }

        private void LoadPensionerAccountsGrid()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT pa.PensionerAccountId, p.Full_Name, p.NID_Num, pa.Monthly_Pension, pm.Payment_Method_Name FROM Pensioner_Accounts pa INNER JOIN Pensioners p ON pa.Pensioner_Id = p.Pensioner_Id INNER JOIN PaymentMethods pm ON pa.Payment_Method_Id = pm.Payment_Method_Id WHERE pa.IsActive = 1 ORDER BY pa.PensionerAccountId DESC";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPensionerAccounts.DataSource = dt;
                    dgvPensionerAccounts.AutoGenerateColumns = false;
                    dgvPensionerAccounts.Refresh();
                    dgvPensionerAccounts.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load accounts.\n" + ex.Message);
            }
        }

        private void LoadPaymentMethods()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT Payment_Method_Id, Payment_Method_Name FROM PaymentMethods";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbPaymentMethod.DataSource = dt;
                    cmbPaymentMethod.DisplayMember = "Payment_Method_Name";
                    cmbPaymentMethod.ValueMember = "Payment_Method_Id";
                    cmbPaymentMethod.SelectedIndex = -1;
                    cmbNewPaymentMethod.DataSource = dt.Copy();
                    cmbNewPaymentMethod.DisplayMember = "Payment_Method_Name";
                    cmbNewPaymentMethod.ValueMember = "Payment_Method_Id";
                    cmbNewPaymentMethod.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load payment methods.\n" + ex.Message);
            }
        }

        private void LoadPensionerForAccount(int pensionerId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"
            SELECT 
                Full_Name,
                NID_Num,
                Last_Salary,
                Service_Years
            FROM Pensioners
            WHERE Pensioner_Id = @Id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", pensionerId);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        decimal lastSalary = Convert.ToDecimal(dr["Last_Salary"]);
                        int serviceYears = Convert.ToInt32(dr["Service_Years"]);

                        txtPensionerName.Text = dr["Full_Name"].ToString();
                        txtPensionerNID.Text = dr["NID_Num"].ToString();

                        decimal monthlyPension = (lastSalary * serviceYears) / 60;
                        txtMonthlyPension.Text = monthlyPension.ToString("0.00");
                    }
                    dr.Close();
                }

                CheckExistingAccount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load pensioner info.\n" + ex.Message);
            }
        }

        private void CheckExistingAccount()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT COUNT(*) FROM Pensioner_Accounts WHERE Pensioner_Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", selectedPensionerId);
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        btnCreateAccount.Visible = false;
                        lblPaymentMethod.Visible = false;
                        cmbPaymentMethod.Visible = false;
                        MessageBox.Show("A pension account already exists for this pensioner.", "Duplicate Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        btnCreateAccount.Visible = true;
                        lblPaymentMethod.Visible = true;
                        cmbPaymentMethod.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Pensioner_Accounts_Load(object sender, EventArgs e)
        {
            try
            {
                LoadPensioners();
                LoadPaymentMethods();
                LoadPensionerAccountsGrid();
                btnCreateAccount.Visible = false;
                lblPaymentMethod.Visible = false;
                cmbPaymentMethod.Visible = false;
                cmbPaymentMethod.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAdminDashboard adminDashboard = new FrmAdminDashboard();
            adminDashboard.Show();
        }

        private void dgvPensioners_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvPensioners.CurrentRow == null) return;
                selectedPensionerId = Convert.ToInt32(dgvPensioners.CurrentRow.Cells["Pensioner_Id"].Value);
                LoadPensionerForAccount(selectedPensionerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to select pensioner.\n" + ex.Message);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT Pensioner_Id, Full_Name, NID_Num
                                    FROM Pensioners
                                    WHERE IsActive = 1
                                    AND (Pensioner_Id LIKE @Search OR Full_Name LIKE @Search OR NID_Num LIKE @Search)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text.Trim() + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPensioners.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed.\n" + ex.Message);
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Pensioner_Accounts (Pensioner_Id, Monthly_Pension, Pension_Starting_Date, Payment_Method_Id, IsActive) VALUES (@PensionerId, @Monthly, @StartDate, @PaymentMethod, 1)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@PensionerId", selectedPensionerId);
                    cmd.Parameters.AddWithValue("@Monthly", decimal.Parse(txtMonthlyPension.Text));
                    cmd.Parameters.AddWithValue("@StartDate", dtpPensionStartDate.Value.Date);
                    cmd.Parameters.AddWithValue("@PaymentMethod", cmbPaymentMethod.SelectedValue);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show( "The pensioner account has been created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create account.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void dgvPensionerAccounts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    selectedAccountId = Convert.ToInt32(dgvPensionerAccounts.CurrentRow.Cells["PensionerAccountId"].Value);
                    txtOldPaymentMethod.Text = dgvPensionerAccounts.CurrentRow.Cells["Payment_Method_Name"].Value.ToString();
                    cmbNewPaymentMethod.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdatePaymentMethod_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedAccountId == 0 || cmbNewPaymentMethod.SelectedIndex == -1)
                {
                    MessageBox.Show("Select account and new payment method.");
                    return;
                }
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Pensioner_Accounts SET Payment_Method_Id = @NewMethod WHERE PensionerAccountId = @AccId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@NewMethod", cmbNewPaymentMethod.SelectedValue);
                    cmd.Parameters.AddWithValue("@AccId", selectedAccountId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Pension account mayment method updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
