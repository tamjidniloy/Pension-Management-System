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
using System.Xml.Linq;

namespace Pension_Management_System
{
    public partial class Pensioner_Management : Form
    {
        int selectedPensionerId = 0;
        string connectionString = @"Server=DESKTOP-OI5KIFE\SQLEXPRESS;Initial Catalog=Pension Management System;Integrated Security=True;";
        public Pensioner_Management()
        {
            InitializeComponent();
            LoadPensioners();
            RefreshForm();
        }

        private void LoadPensioners()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT Pensioner_Id, Full_Name, NID_Num, Phone_Num, Email, Date_Of_Birth, Retirement_Date, Service_Years, Last_Salary
                             FROM Pensioners
                             WHERE IsActive = 1 ORDER BY Pensioner_Id DESC ";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPensioners.AutoGenerateColumns = false;
                    dgvPensioners.DataSource = dt;
                    dgvPensioners.Refresh();
                    dgvPensioners.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load pensioners.\n" + ex.Message);
            }
        }

        private void RefreshForm()
        {
            selectedPensionerId = 0;
            txtPensionerId.Clear();
            txtName.Clear();
            txtNID.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtServiceYears.Clear();
            txtLastSalary.Clear();
            dtpDOB.Value = DateTime.Today;
            dtpRetirement.Value = DateTime.Today;
            txtSearch.Clear();
            LoadPensioners();
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
                txtPensionerId.Text = dgvPensioners.CurrentRow.Cells["Pensioner_Id"].Value.ToString();
                txtName.Text = dgvPensioners.CurrentRow.Cells["Full_Name"].Value.ToString();
                txtNID.Text = dgvPensioners.CurrentRow.Cells["NID_Num"].Value.ToString();
                txtPhone.Text = dgvPensioners.CurrentRow.Cells["Phone_Num"].Value.ToString();
                txtEmail.Text = dgvPensioners.CurrentRow.Cells["Email"].Value.ToString();
                dtpDOB.Value = Convert.ToDateTime(dgvPensioners.CurrentRow.Cells["Date_Of_Birth"].Value);
                dtpRetirement.Value = Convert.ToDateTime(dgvPensioners.CurrentRow.Cells["Retirement_Date"].Value);
                txtServiceYears.Text = dgvPensioners.CurrentRow.Cells["Service_Years"].Value.ToString();
                txtLastSalary.Text = dgvPensioners.CurrentRow.Cells["Last_Salary"].Value.ToString();
                txtPensionerId.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load pensioner.\n" + ex.Message);
            }
        }

        private void Pensioner_Management_Load(object sender, EventArgs e)
        {
            try
            {
                pnlPensioner.Visible = true;
                LoadPensioners();
                RefreshForm();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd;
                    if (selectedPensionerId == 0)
                    {
                        string insertQuery = @"INSERT INTO Pensioners (Full_Name, NID_Num, Phone_Num, Email, Date_Of_Birth, Retirement_Date, Service_Years, Last_Salary, IsActive)
                                            VALUES (@Name, @NID, @Phone, @Email, @DOB, @RetDate, @ServiceYears, @Salary, 1)";
                        cmd = new SqlCommand(insertQuery, con);
                        cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@NID", txtNID.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@RetDate", dtpRetirement.Value.Date);
                        cmd.Parameters.AddWithValue("@ServiceYears", int.Parse(txtServiceYears.Text));
                        cmd.Parameters.AddWithValue("@Salary", decimal.Parse(txtLastSalary.Text));
                        MessageBox.Show(" A new Pensioner Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string updateQuery = @" UPDATE Pensioners
                                            SET Full_Name=@Name,
                                                NID_Num=@NID,
                                                Phone_Num=@Phone,
                                                Email=@Email,
                                                Date_Of_Birth=@DOB,
                                                Retirement_Date=@RetDate,
                                                Service_Years=@ServiceYears,
                                                Last_Salary=@Salary
                                                WHERE Pensioner_Id=@Id";
                        cmd = new SqlCommand(updateQuery, con);
                        cmd.Parameters.AddWithValue("@Id", selectedPensionerId);
                        cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@NID", txtNID.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@RetDate", dtpRetirement.Value.Date);
                        cmd.Parameters.AddWithValue("@ServiceYears", int.Parse(txtServiceYears.Text));
                        cmd.Parameters.AddWithValue("@Salary", decimal.Parse(txtLastSalary.Text));
                        MessageBox.Show(" Pensioner details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                    
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed.\n" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedPensionerId == 0)
                {
                    MessageBox.Show("Please select a pensioner first.");
                    return;
                }
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Pensioners SET IsActive = 0 WHERE Pensioner_Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", selectedPensionerId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Pensioner deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed.\n" + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT * FROM Pensioners WHERE IsActive = 1
                                    AND (Email LIKE @Search OR Phone_Num LIKE @Search OR NID_Num LIKE @Search OR Full_Name LIKE @Search OR Pensioner_Id LIKE @Search)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text.Trim() + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPensioners.DataSource = dt;
                    dgvPensioners.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed.\n" + ex.Message);
            }
        }

    }
}
