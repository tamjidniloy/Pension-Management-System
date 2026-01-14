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
    public partial class Employee_Management : Form
    {
        int selectedUserId = 0;
        string connectionString = @"Server=NILOY\SQLEXPRESS;Initial Catalog=Pension Management System;Integrated Security=True;";
        public Employee_Management()
        {
            InitializeComponent();
            RefreshForm();
            ClearPanel();
            PrepareForAdd();
            LoadEmployees();
        }

        private void RefreshForm()
        {
            selectedUserId = 0;
            LoadEmployees();
            ClearPanel();
            PrepareForAdd();
        }

        private void ClearPanel()
        {
            txtUserId.Clear();
            txtRole.Clear();
            cmbRole.SelectedIndex = -1;
            txtSearch.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }

        private void PrepareForAdd()
        {
            selectedUserId = 0;
            cmbRole.Visible = true;
            txtRole.Visible = false;
            cmbRole.SelectedIndex = -1;
            txtRole.Clear();
        }

        private void LoadEmployees()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                    U.User_Id,
                    R.Role_Name,
                    U.User_Name,
                    U.User_Email,
                    U.User_PhoneNum
                    FROM Users U
                    JOIN Roles R ON U.Role_Id = R.Role_Id
                    WHERE U.IsActive = 1";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvEmployees.AutoGenerateColumns = false;
                    dgvEmployees.DataSource = dt;
                    dgvEmployees.Refresh();
                    dgvEmployees.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadRoles()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT Role_Id, Role_Name FROM Roles";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbRole.DataSource = dt;
                    cmbRole.DisplayMember = "Role_Name"; 
                    cmbRole.ValueMember = "Role_Id";    
                    cmbRole.SelectedIndex = -1;          
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load roles.\n" + ex.Message);
            }
        }

        private void Employee_Management_Load(object sender, EventArgs e)
        {
            try
            {
                pnlEmployee.Visible = true;
                RefreshForm();
                LoadRoles();
                LoadEmployees();  
                PrepareForAdd();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAdminDashboard adminDashboard = new FrmAdminDashboard();
            adminDashboard.Show();
        }

        private void dgvEmployees_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                selectedUserId = Convert.ToInt32( dgvEmployees.CurrentRow.Cells["dgvUser_Id"].Value);
                txtUserId.Text = dgvEmployees.CurrentRow.Cells["dgvUser_Id"].Value.ToString();
                txtRole.Text = dgvEmployees.CurrentRow.Cells["Role_Id"].Value.ToString();
                txtName.Text = dgvEmployees.CurrentRow.Cells["User_Name"].Value.ToString();
                txtEmail.Text = dgvEmployees.CurrentRow.Cells["User_Email"].Value.ToString();
                txtPhone.Text = dgvEmployees.CurrentRow.Cells["User_PhoneNum"].Value.ToString();
                cmbRole.Visible = false;
                txtRole.Visible = true;
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
                    if (selectedUserId == 0)
                    {
                        string insertQuery = @"INSERT INTO Users (Role_Id, User_Name, User_Email, User_PhoneNum, Password, IsActive) VALUES (@RoleID, @UserName, @Email, @Phone, @Password, 1)";
                        cmd = new SqlCommand(insertQuery, con);
                        cmd.Parameters.AddWithValue("@RoleID", cmbRole.SelectedValue);
                        cmd.Parameters.AddWithValue("@UserName", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", "1234");
                    }
                    else
                    {
                        string updateQuery = @"UPDATE Users SET User_Name = @UserName, User_Email = @Email, User_PhoneNum = @Phone WHERE User_Id = @Id";
                        cmd = new SqlCommand(updateQuery, con);
                        cmd.Parameters.AddWithValue("@Id", selectedUserId);
                        cmd.Parameters.AddWithValue("@UserName", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());                    
                    }
                    con.Open();
                    cmd.ExecuteNonQuery();
                }                
                RefreshForm();
                MessageBox.Show("User information updated/Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedUserId == 0) return;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query ="UPDATE Users SET IsActive = 0 WHERE User_Id=@Id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", selectedUserId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                    U.User_Id,
                    R.Role_Name,
                    U.User_Name,
                    U.User_Email,
                    U.User_PhoneNum
                FROM Users U
                JOIN Roles R ON U.Role_Id = R.Role_Id
                WHERE U.IsActive = 1
                  AND (U.User_Email LIKE @key
                       OR U.User_PhoneNum LIKE @key)";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue( "@key", "%" + txtSearch.Text.Trim() + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvEmployees.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
