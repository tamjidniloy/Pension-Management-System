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
        int bankAccountId = 0;
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
            LoadBanks();
            SearchPensionerAccounts();
            this.previousForm = pform;
        }

        private void HideAllPanels()
        {
            pnlCash.Visible = false;
            pnlBank.Visible = false;
            pnlMFS.Visible = false;
        }

        private void LoadPensionerAccounts()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                                            p.Pensioner_Id,
                                            pa.PensionerAccountId,
                                            p.Full_Name,
                                            p.NID_Num,
                                            pa.Current_Balance,
                                            pm.Payment_Method_Name
                                        FROM Pensioner_Accounts pa
                                        INNER JOIN Pensioners p ON p.Pensioner_Id = pa.Pensioner_Id
                                        INNER JOIN PaymentMethods pm ON pm.Payment_Method_Id = pa.Payment_Method_Id
                                        WHERE pa.IsActive = 1
                                          AND p.IsActive = 1 ORDER by pa.PensionerAccountId DESC ";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAccounts.AutoGenerateColumns = false;
                    dgvAccounts.DataSource = dt;
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
            try
            {
                txtMFSPhone.Clear();
                txtBankAccount.Clear();
                cmbBank.SelectedIndex = -1;
                txtWithdrawAmount.Clear();
                txtPensionerID.Clear();
                txtSearch.Clear();
                txtAccountId.Clear();
                txtName.Clear();
                txtNIDnum.Clear();
                txtBalance.Clear();
                txtPaymentMethod.Clear();
                HideAllPanels();
                LoadPensionerAccounts();
                bankAccountId = 0;
                selectedAccountId = 0;
                selectedPensionerId = 0;
                selectedBalance = 0;
                selectedPaymentMethod = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    selectedPensionerId = Convert.ToInt32(row.Cells["Pensioner_Id"].Value);
                    txtAccountId.Text = selectedAccountId.ToString();
                    txtPensionerID.Text = selectedPensionerId.ToString();
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

        private void SearchPensionerAccounts()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"
            SELECT 
                p.Pensioner_Id,
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
              AND (
                    CAST(pa.PensionerAccountId AS VARCHAR(20)) = @key
                 OR p.NID_Num = @key
                 OR p.Full_Name LIKE @name
              )";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@key", txtSearch.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", "%" + txtSearch.Text.Trim() + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvAccounts.AutoGenerateColumns = false;
                    dgvAccounts.DataSource = dt;
                    dgvAccounts.ClearSelection();
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
                        SqlCommand cmd1 = new SqlCommand(@" UPDATE Pensioner_Accounts SET Current_Balance = Current_Balance - @amt WHERE PensionerAccountId = @acc", con, tran);
                        cmd1.Parameters.AddWithValue("@amt", amount);
                        cmd1.Parameters.AddWithValue("@acc", selectedAccountId);
                        cmd1.ExecuteNonQuery();

                        SqlCommand ledgerCmd = new SqlCommand(@"INSERT INTO PensionLedger(Pensioner_Id,PensionerAccountId, Debit_Amount,Credit_Amount, Balance) VALUES (@Pid, @AccId, @Debit, 0, @Balance )", con, tran);
                        ledgerCmd.Parameters.AddWithValue("@Pid", selectedPensionerId);
                        ledgerCmd.Parameters.AddWithValue("@AccId", selectedAccountId);
                        ledgerCmd.Parameters.AddWithValue("@Debit", amount);
                        ledgerCmd.Parameters.AddWithValue("@Balance", selectedBalance - amount);
                        ledgerCmd.ExecuteNonQuery();
                        tran.Commit();
                        MessageBox.Show("The Money withdraw has been completed successfully.","Transfer Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        RefreshForm();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
                RefreshForm();
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
                        SqlCommand debit = new SqlCommand(@" UPDATE Pensioner_Accounts SET Current_Balance = Current_Balance - @amt WHERE PensionerAccountId = @acc", con, tran);
                        debit.Parameters.AddWithValue("@amt", amount);
                        debit.Parameters.AddWithValue("@acc", selectedAccountId);
                        debit.ExecuteNonQuery();

                        // Credit bank
                        SqlCommand credit = new SqlCommand(@"UPDATE Bank_Accounts SET Office_Tracked_Balance = Office_Tracked_Balance + @amt WHERE Account_Number = @accno", con, tran);
                        credit.Parameters.AddWithValue("@amt", amount);
                        credit.Parameters.AddWithValue("@accno", accNo);
                        credit.ExecuteNonQuery();

                        // Ledger
                        SqlCommand ledgerCmd = new SqlCommand(@" INSERT INTO PensionLedger ( Pensioner_Id, PensionerAccountId, Debit_Amount, Credit_Amount, Balance)VALUES(@Pid,@AccId,@Debit,0,@Balance)", con, tran);
                        ledgerCmd.Parameters.AddWithValue("@Pid", selectedPensionerId);
                        ledgerCmd.Parameters.AddWithValue("@AccId", selectedAccountId);
                        //ledgerCmd.Parameters.AddWithValue("@BankAccId", "123456");
                        ledgerCmd.Parameters.AddWithValue("@Debit", amount);
                        ledgerCmd.Parameters.AddWithValue("@Balance", selectedBalance - amount);
                        ledgerCmd.ExecuteNonQuery();

                        tran.Commit();
                        MessageBox.Show("The Bank transfer has been completed successfully.", "Transfer Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
                RefreshForm();
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
                        SqlCommand debit = new SqlCommand(@" UPDATE Pensioner_Accounts SET Current_Balance = Current_Balance - @amt WHERE PensionerAccountId = @acc", con, tran);
                        debit.Parameters.AddWithValue("@amt", amount);
                        debit.Parameters.AddWithValue("@acc", selectedAccountId);
                        debit.ExecuteNonQuery();

                        // Credit MFS
                        SqlCommand credit = new SqlCommand(@" UPDATE MFS_Accounts SET Office_Tracked_Balance = Office_Tracked_Balance + @amt WHERE Phone_Number = @phone", con, tran);
                        credit.Parameters.AddWithValue("@amt", amount);
                        credit.Parameters.AddWithValue("@phone", phone);
                        credit.ExecuteNonQuery();

                        // Ledger
                        SqlCommand ledgerCmd = new SqlCommand(@"INSERT INTO PensionLedger (Pensioner_Id, PensionerAccountId, Debit_Amount, Credit_Amount, Balance) VALUES (@Pid, @AccId, @Debit, 0, @Balance)", con, tran);
                        ledgerCmd.Parameters.AddWithValue("@Pid", selectedPensionerId);
                        ledgerCmd.Parameters.AddWithValue("@AccId", selectedAccountId);
                        //ledgerCmd.Parameters.AddWithValue("@MfsAccId", null);
                        ledgerCmd.Parameters.AddWithValue("@Debit", amount);
                        ledgerCmd.Parameters.AddWithValue("@Balance", selectedBalance - amount);
                        ledgerCmd.ExecuteNonQuery();

                        tran.Commit();
                        MessageBox.Show("The MFS transfer has been completed successfully.", "Transfer Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    MessageBox.Show("Please enter Account ID, Name, or NID.");
                    return;
                }
                SearchPensionerAccounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
