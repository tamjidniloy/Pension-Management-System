namespace Pension_Management_System
{
    partial class FrmAdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnManageEmployee = new System.Windows.Forms.Button();
            this.btnManagePensionar = new System.Windows.Forms.Button();
            this.btnManageAccounts = new System.Windows.Forms.Button();
            this.btnManagePayment = new System.Windows.Forms.Button();
            this.btnManageWithdraw = new System.Windows.Forms.Button();
            this.btnManageReport = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 104);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 58);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Admin Portal";
            // 
            // btnManageEmployee
            // 
            this.btnManageEmployee.AutoSize = true;
            this.btnManageEmployee.BackColor = System.Drawing.Color.DarkCyan;
            this.btnManageEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageEmployee.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmployee.ForeColor = System.Drawing.Color.White;
            this.btnManageEmployee.Location = new System.Drawing.Point(101, 142);
            this.btnManageEmployee.Name = "btnManageEmployee";
            this.btnManageEmployee.Size = new System.Drawing.Size(320, 64);
            this.btnManageEmployee.TabIndex = 1;
            this.btnManageEmployee.Text = "Manage Employees ";
            this.btnManageEmployee.UseVisualStyleBackColor = false;
            this.btnManageEmployee.Click += new System.EventHandler(this.btnManageEmployee_Click);
            // 
            // btnManagePensionar
            // 
            this.btnManagePensionar.AutoSize = true;
            this.btnManagePensionar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnManagePensionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManagePensionar.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagePensionar.ForeColor = System.Drawing.Color.White;
            this.btnManagePensionar.Location = new System.Drawing.Point(473, 142);
            this.btnManagePensionar.Name = "btnManagePensionar";
            this.btnManagePensionar.Size = new System.Drawing.Size(364, 64);
            this.btnManagePensionar.TabIndex = 2;
            this.btnManagePensionar.Text = "Manage Pensioners";
            this.btnManagePensionar.UseVisualStyleBackColor = false;
            this.btnManagePensionar.Click += new System.EventHandler(this.btnManagePensionar_Click);
            // 
            // btnManageAccounts
            // 
            this.btnManageAccounts.AutoSize = true;
            this.btnManageAccounts.BackColor = System.Drawing.Color.DarkCyan;
            this.btnManageAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageAccounts.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAccounts.ForeColor = System.Drawing.Color.White;
            this.btnManageAccounts.Location = new System.Drawing.Point(923, 142);
            this.btnManageAccounts.Name = "btnManageAccounts";
            this.btnManageAccounts.Size = new System.Drawing.Size(364, 64);
            this.btnManageAccounts.TabIndex = 3;
            this.btnManageAccounts.Text = "Pensioner Accounts";
            this.btnManageAccounts.UseVisualStyleBackColor = false;
            this.btnManageAccounts.Click += new System.EventHandler(this.btnManageAccounts_Click);
            // 
            // btnManagePayment
            // 
            this.btnManagePayment.AutoSize = true;
            this.btnManagePayment.BackColor = System.Drawing.Color.DarkCyan;
            this.btnManagePayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManagePayment.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagePayment.ForeColor = System.Drawing.Color.White;
            this.btnManagePayment.Location = new System.Drawing.Point(473, 292);
            this.btnManagePayment.Name = "btnManagePayment";
            this.btnManagePayment.Size = new System.Drawing.Size(364, 64);
            this.btnManagePayment.TabIndex = 4;
            this.btnManagePayment.Text = "Pension Payments";
            this.btnManagePayment.UseVisualStyleBackColor = false;
            this.btnManagePayment.Click += new System.EventHandler(this.btnManagePayment_Click);
            // 
            // btnManageWithdraw
            // 
            this.btnManageWithdraw.AutoSize = true;
            this.btnManageWithdraw.BackColor = System.Drawing.Color.DarkCyan;
            this.btnManageWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageWithdraw.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnManageWithdraw.Location = new System.Drawing.Point(482, 412);
            this.btnManageWithdraw.Name = "btnManageWithdraw";
            this.btnManageWithdraw.Size = new System.Drawing.Size(364, 64);
            this.btnManageWithdraw.TabIndex = 5;
            this.btnManageWithdraw.Text = "Pension Withdraw";
            this.btnManageWithdraw.UseVisualStyleBackColor = false;
            // 
            // btnManageReport
            // 
            this.btnManageReport.AutoSize = true;
            this.btnManageReport.BackColor = System.Drawing.Color.DarkCyan;
            this.btnManageReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageReport.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageReport.ForeColor = System.Drawing.Color.White;
            this.btnManageReport.Location = new System.Drawing.Point(482, 543);
            this.btnManageReport.Name = "btnManageReport";
            this.btnManageReport.Size = new System.Drawing.Size(364, 64);
            this.btnManageReport.TabIndex = 6;
            this.btnManageReport.Text = "Pension Report";
            this.btnManageReport.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1405, 753);
            this.Controls.Add(this.btnManageReport);
            this.Controls.Add(this.btnManageWithdraw);
            this.Controls.Add(this.btnManagePayment);
            this.Controls.Add(this.btnManageAccounts);
            this.Controls.Add(this.btnManagePensionar);
            this.Controls.Add(this.btnManageEmployee);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdminDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManageEmployee;
        private System.Windows.Forms.Button btnManagePensionar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnManageAccounts;
        private System.Windows.Forms.Button btnManagePayment;
        private System.Windows.Forms.Button btnManageWithdraw;
        private System.Windows.Forms.Button btnManageReport;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}