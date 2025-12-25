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
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (email == "" || password == "")
                {
                    MessageBox.Show("Please enter email and password",
                                    "Validation",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                string connectionString =
                    @"Server=NILOY\SQLEXPRESS;
              Initial Catalog=Pension Management System;
              Integrated Security=True;";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT R.Role_Name
                FROM Users U
                JOIN Roles R ON U.Role_Id = R.Role_Id
                WHERE U.User_Email = @Email
                      AND U.Password = @Password
                      AND U.IsActive = 1";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        con.Open();
                        object role = cmd.ExecuteScalar();

                        if (role == null)
                        {
                            MessageBox.Show("Invalid email or password",
                                            "Login Failed",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            return;
                        }

                        this.Hide();

                        string userRole = role.ToString();

                        if (userRole == "Admin")
                        {
                            new FrmAdminDashboard().Show();
                        }
                        else if (userRole == "Employee")
                        {
                            new FrmEmployeeDashboard().Show();
                        }
                        else
                        {
                            MessageBox.Show("Unknown role detected",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            this.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "System Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
