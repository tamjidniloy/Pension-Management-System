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
    public partial class Pension_Withdrawal : Form
    {
        int selectedAccountId = 0;
        int selectedPensionerId = 0;
        decimal selectedBalance = 0;
        string selectedPaymentMethod = "";
        private Form previousForm;
        string connectionString = @"Server=NILOY\SQLEXPRESS;Initial Catalog=Pension Management System;Integrated Security=True;";
        public Pension_Withdrawal(Form pform)
        {
            InitializeComponent();
            HideAllPanels();
            this.previousForm = pform;
        }

        private void HideAllPanels()
        {
            pnlCash.Visible = false;
            pnlBank.Visible = false;
            pnlMFS.Visible = false;
        }

        private void LoadPensionerAccounts(string keyword = "")
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"
            SELECT 
                pa.PensionerAccountId,
                p.Full_Name,
                p.NID_Num,
                pa.Current_Balance,
                pm.Payment_Method_Name
            FROM Pensioner_Accounts pa
            INNER JOIN Pensioners p ON p.Pensioner_Id = pa.Pensioner_Id
            INNER JOIN PaymentMethods pm ON pm.Payment_Method_Id = pa.Payment_Method_Id
            WHERE pa.IsActive = 1
              AND p.IsActive = 1
              AND (CAST(pa.PensionerAccountId AS VARCHAR) LIKE @keyOR p.Full_Name LIKE @key OR p.NID_Num LIKE @key)";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@key", "%" + keyword + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAccounts.DataSource = dt;
                    dgvAccounts.AutoGenerateColumns = false;
                    dgvAccounts.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshForm()
        {
            txtSearch.Clear();
            txtAccountId.Clear();
            txtName.Clear();
            txtBalance.Clear();
            txtPaymentMethod.Clear();
            txtNIDnum.Clear();
            txtBalance.Clear();
            HideAllPanels();
            LoadPensionerAccounts();
            LoadBanks();
        }

        private void LoadBanks()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT Bank_Id, Bank_Name FROM Banks";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbBank.DataSource = dt;
                    cmbBank.DisplayMember = "Bank_Name";
                    cmbBank.ValueMember = "Bank_Id";
                    cmbBank.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load banks.\n" + ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void dgvAccounts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvAccounts.Rows[e.RowIndex];
                    selectedAccountId = Convert.ToInt32(row.Cells["PensionerAccountId"].Value);
                    txtAccountId.Text = selectedAccountId.ToString();
                    txtName.Text = row.Cells["Full_Name"].Value.ToString();
                    txtNIDnum.Text = row.Cells["NID_Num"].Value.ToString();
                    txtBalance.Text = row.Cells["Current_Balance"].Value.ToString();
                    txtPaymentMethod.Text = row.Cells["Payment_Method_Name"].Value.ToString();
                    selectedBalance = Convert.ToDecimal(row.Cells["Current_Balance"].Value);
                    selectedPaymentMethod = row.Cells["Payment_Method_Name"].Value.ToString();

                    HideAllPanels();

                    if (selectedPaymentMethod == "Hand Cash")
                        pnlCash.Visible = true;
                    else if (selectedPaymentMethod == "Bank")
                        pnlBank.Visible = true;
                    else
                        pnlMFS.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Pension_Withdrawal_Load(object sender, EventArgs e)
        {
            LoadPensionerAccounts();
            LoadBanks();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadPensionerAccounts(txtSearch.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWithdrawCash_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount = Convert.ToDecimal(txtWithdrawAmount.Text);

                if (amount <= 0 || amount > selectedBalance)
                {
                    MessageBox.Show("Invalid amount");
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlTransaction tran = con.BeginTransaction();

                    try
                    {
                        // Debit pension account
                        SqlCommand cmd1 = new SqlCommand(@"
                    UPDATE Pensioner_Accounts
                    SET Current_Balance = Current_Balance - @amt
                    WHERE PensionerAccountId = @acc", con, tran);

                        cmd1.Parameters.AddWithValue("@amt", amount);
                        cmd1.Parameters.AddWithValue("@acc", selectedAccountId);
                        cmd1.ExecuteNonQuery();

                        // Ledger
                        SqlCommand cmd2 = new SqlCommand(@"
                    INSERT INTO PensionLedger
                    (PensionerAccountId, Debit_Amount, Balance)
                    VALUES (@acc, @amt, @bal)", con, tran);

                        cmd2.Parameters.AddWithValue("@acc", selectedAccountId);
                        cmd2.Parameters.AddWithValue("@amt", amount);
                        cmd2.Parameters.AddWithValue("@bal", selectedBalance - amount);
                        cmd2.ExecuteNonQuery();

                        tran.Commit();
                        MessageBox.Show("Cash withdrawn successfully");
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }

                LoadPensionerAccounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTransferBank_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount = Convert.ToDecimal(txtWithdrawAmount.Text);
                int bankId = Convert.ToInt32(cmbBank.SelectedValue);
                string accNo = txtBankAccount.Text.Trim();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlTransaction tran = con.BeginTransaction();

                    try
                    {
                        // Debit pension
                        SqlCommand debit = new SqlCommand(@"
                UPDATE Pensioner_Accounts
                SET Current_Balance = Current_Balance - @amt
                WHERE PensionerAccountId = @acc", con, tran);

                        debit.Parameters.AddWithValue("@amt", amount);
                        debit.Parameters.AddWithValue("@acc", selectedAccountId);
                        debit.ExecuteNonQuery();

                        // Credit bank
                        SqlCommand credit = new SqlCommand(@"
                UPDATE Bank_Accounts
                SET Office_Tracked_Balance = Office_Tracked_Balance + @amt
                WHERE Account_Number = @accno", con, tran);

                        credit.Parameters.AddWithValue("@amt", amount);
                        credit.Parameters.AddWithValue("@accno", accNo);
                        credit.ExecuteNonQuery();

                        // Ledger
                        SqlCommand ledger = new SqlCommand(@"
                INSERT INTO PensionLedger
                (PensionerAccountId, Debit_Amount, Balance)
                VALUES (@acc, @amt, @bal)", con, tran);

                        ledger.Parameters.AddWithValue("@acc", selectedAccountId);
                        ledger.Parameters.AddWithValue("@amt", amount);
                        ledger.Parameters.AddWithValue("@bal", selectedBalance - amount);
                        ledger.ExecuteNonQuery();

                        tran.Commit();
                        MessageBox.Show("Bank transfer successful");
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }

                LoadPensionerAccounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTransferMFS_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount = Convert.ToDecimal(txtWithdrawAmount.Text);
                string phone = txtMFSPhone.Text.Trim();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlTransaction tran = con.BeginTransaction();

                    try
                    {
                        // Debit pension
                        SqlCommand debit = new SqlCommand(@"
                UPDATE Pensioner_Accounts
                SET Current_Balance = Current_Balance - @amt
                WHERE PensionerAccountId = @acc", con, tran);

                        debit.Parameters.AddWithValue("@amt", amount);
                        debit.Parameters.AddWithValue("@acc", selectedAccountId);
                        debit.ExecuteNonQuery();

                        // Credit MFS
                        SqlCommand credit = new SqlCommand(@"
                UPDATE MFS_Accounts
                SET Office_Tracked_Balance = Office_Tracked_Balance + @amt
                WHERE Phone_Number = @phone", con, tran);

                        credit.Parameters.AddWithValue("@amt", amount);
                        credit.Parameters.AddWithValue("@phone", phone);
                        credit.ExecuteNonQuery();

                        // Ledger
                        SqlCommand ledger = new SqlCommand(@"
                INSERT INTO PensionLedger
                (PensionerAccountId, Debit_Amount, Balance)
                VALUES (@acc, @amt, @bal)", con, tran);

                        ledger.Parameters.AddWithValue("@acc", selectedAccountId);
                        ledger.Parameters.AddWithValue("@amt", amount);
                        ledger.Parameters.AddWithValue("@bal", selectedBalance - amount);
                        ledger.ExecuteNonQuery();

                        tran.Commit();
                        MessageBox.Show("MFS transfer successful");
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }

                LoadPensionerAccounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
