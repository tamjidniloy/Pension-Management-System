namespace Pension_Management_System
{
    partial class Monthly_Pension_Process
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvMonthlyStatus = new System.Windows.Forms.DataGridView();
            this.Pensioner_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monthly_Pension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Current_Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Month_Accrued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment_Method_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCurrentBalance = new System.Windows.Forms.TextBox();
            this.txtTotalAccrued = new System.Windows.Forms.TextBox();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMonthlyPension = new System.Windows.Forms.TextBox();
            this.btnRunMonthlyPension = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyStatus)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(28, 177);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(580, 40);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(630, 174);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 45);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvMonthlyStatus
            // 
            this.dgvMonthlyStatus.AllowUserToAddRows = false;
            this.dgvMonthlyStatus.AllowUserToDeleteRows = false;
            this.dgvMonthlyStatus.AllowUserToResizeColumns = false;
            this.dgvMonthlyStatus.AllowUserToResizeRows = false;
            this.dgvMonthlyStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvMonthlyStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMonthlyStatus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMonthlyStatus.BackgroundColor = System.Drawing.Color.White;
            this.dgvMonthlyStatus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMonthlyStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvMonthlyStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlyStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pensioner_Id,
            this.Full_Name,
            this.Monthly_Pension,
            this.Current_Balance,
            this.Total_Month_Accrued,
            this.Payment_Method_Name});
            this.dgvMonthlyStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonthlyStatus.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvMonthlyStatus.EnableHeadersVisualStyles = false;
            this.dgvMonthlyStatus.GridColor = System.Drawing.Color.White;
            this.dgvMonthlyStatus.Location = new System.Drawing.Point(28, 244);
            this.dgvMonthlyStatus.Margin = new System.Windows.Forms.Padding(0);
            this.dgvMonthlyStatus.MultiSelect = false;
            this.dgvMonthlyStatus.Name = "dgvMonthlyStatus";
            this.dgvMonthlyStatus.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonthlyStatus.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvMonthlyStatus.RowHeadersVisible = false;
            this.dgvMonthlyStatus.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMonthlyStatus.RowTemplate.DividerHeight = 1;
            this.dgvMonthlyStatus.RowTemplate.Height = 30;
            this.dgvMonthlyStatus.RowTemplate.ReadOnly = true;
            this.dgvMonthlyStatus.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonthlyStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonthlyStatus.Size = new System.Drawing.Size(976, 554);
            this.dgvMonthlyStatus.TabIndex = 4;
            this.dgvMonthlyStatus.VirtualMode = true;
            this.dgvMonthlyStatus.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMonthlyStatus_CellMouseDoubleClick);
            // 
            // Pensioner_Id
            // 
            this.Pensioner_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pensioner_Id.DataPropertyName = "Pensioner_Id";
            this.Pensioner_Id.DividerWidth = 1;
            this.Pensioner_Id.HeaderText = "ID num";
            this.Pensioner_Id.MinimumWidth = 6;
            this.Pensioner_Id.Name = "Pensioner_Id";
            this.Pensioner_Id.ReadOnly = true;
            this.Pensioner_Id.Width = 127;
            // 
            // Full_Name
            // 
            this.Full_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Full_Name.DataPropertyName = "Full_Name";
            this.Full_Name.DividerWidth = 1;
            this.Full_Name.HeaderText = "Name";
            this.Full_Name.MinimumWidth = 6;
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.ReadOnly = true;
            this.Full_Name.Width = 112;
            // 
            // Monthly_Pension
            // 
            this.Monthly_Pension.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Monthly_Pension.DataPropertyName = "Monthly_Pension";
            this.Monthly_Pension.DividerWidth = 1;
            this.Monthly_Pension.HeaderText = "Monthly Pension";
            this.Monthly_Pension.MinimumWidth = 6;
            this.Monthly_Pension.Name = "Monthly_Pension";
            this.Monthly_Pension.ReadOnly = true;
            this.Monthly_Pension.Width = 237;
            // 
            // Current_Balance
            // 
            this.Current_Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Current_Balance.DataPropertyName = "Current_Balance";
            this.Current_Balance.DividerWidth = 1;
            this.Current_Balance.HeaderText = "Current Balance";
            this.Current_Balance.MinimumWidth = 6;
            this.Current_Balance.Name = "Current_Balance";
            this.Current_Balance.ReadOnly = true;
            this.Current_Balance.Width = 227;
            // 
            // Total_Month_Accrued
            // 
            this.Total_Month_Accrued.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total_Month_Accrued.DataPropertyName = "Total_Month_Accrued";
            this.Total_Month_Accrued.DividerWidth = 1;
            this.Total_Month_Accrued.HeaderText = "Months";
            this.Total_Month_Accrued.MinimumWidth = 6;
            this.Total_Month_Accrued.Name = "Total_Month_Accrued";
            this.Total_Month_Accrued.ReadOnly = true;
            this.Total_Month_Accrued.Width = 134;
            // 
            // Payment_Method_Name
            // 
            this.Payment_Method_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Payment_Method_Name.DataPropertyName = "Payment_Method_Name";
            this.Payment_Method_Name.DividerWidth = 1;
            this.Payment_Method_Name.HeaderText = "Method";
            this.Payment_Method_Name.MinimumWidth = 6;
            this.Payment_Method_Name.Name = "Payment_Method_Name";
            this.Payment_Method_Name.ReadOnly = true;
            this.Payment_Method_Name.Width = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(636, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Pension Payment System";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1795, 113);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pensioner ID : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 40);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 40);
            this.label6.TabIndex = 2;
            this.label6.Text = "Monthly Pension : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 40);
            this.label7.TabIndex = 3;
            this.label7.Text = "Current Balance : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 40);
            this.label8.TabIndex = 4;
            this.label8.Text = "Number of Months : ";
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentBalance.Location = new System.Drawing.Point(358, 208);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.ReadOnly = true;
            this.txtCurrentBalance.Size = new System.Drawing.Size(310, 40);
            this.txtCurrentBalance.TabIndex = 11;
            // 
            // txtTotalAccrued
            // 
            this.txtTotalAccrued.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAccrued.Location = new System.Drawing.Point(358, 265);
            this.txtTotalAccrued.Name = "txtTotalAccrued";
            this.txtTotalAccrued.ReadOnly = true;
            this.txtTotalAccrued.Size = new System.Drawing.Size(310, 40);
            this.txtTotalAccrued.TabIndex = 15;
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlEmployee.BackColor = System.Drawing.Color.LightYellow;
            this.pnlEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployee.Controls.Add(this.txtMethod);
            this.pnlEmployee.Controls.Add(this.label2);
            this.pnlEmployee.Controls.Add(this.txtID);
            this.pnlEmployee.Controls.Add(this.txtName);
            this.pnlEmployee.Controls.Add(this.txtMonthlyPension);
            this.pnlEmployee.Controls.Add(this.txtTotalAccrued);
            this.pnlEmployee.Controls.Add(this.txtCurrentBalance);
            this.pnlEmployee.Controls.Add(this.label8);
            this.pnlEmployee.Controls.Add(this.label7);
            this.pnlEmployee.Controls.Add(this.label6);
            this.pnlEmployee.Controls.Add(this.label5);
            this.pnlEmployee.Controls.Add(this.label4);
            this.pnlEmployee.Location = new System.Drawing.Point(1068, 244);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(701, 441);
            this.pnlEmployee.TabIndex = 6;
            // 
            // txtMethod
            // 
            this.txtMethod.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMethod.Location = new System.Drawing.Point(358, 322);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.ReadOnly = true;
            this.txtMethod.Size = new System.Drawing.Size(310, 40);
            this.txtMethod.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 40);
            this.label2.TabIndex = 19;
            this.label2.Text = "Payment Method : ";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(358, 37);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(310, 40);
            this.txtID.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(358, 94);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(310, 40);
            this.txtName.TabIndex = 17;
            // 
            // txtMonthlyPension
            // 
            this.txtMonthlyPension.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthlyPension.Location = new System.Drawing.Point(358, 151);
            this.txtMonthlyPension.Name = "txtMonthlyPension";
            this.txtMonthlyPension.ReadOnly = true;
            this.txtMonthlyPension.Size = new System.Drawing.Size(310, 40);
            this.txtMonthlyPension.TabIndex = 16;
            // 
            // btnRunMonthlyPension
            // 
            this.btnRunMonthlyPension.AutoSize = true;
            this.btnRunMonthlyPension.BackColor = System.Drawing.Color.LightGreen;
            this.btnRunMonthlyPension.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRunMonthlyPension.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunMonthlyPension.Location = new System.Drawing.Point(900, 166);
            this.btnRunMonthlyPension.Name = "btnRunMonthlyPension";
            this.btnRunMonthlyPension.Size = new System.Drawing.Size(329, 51);
            this.btnRunMonthlyPension.TabIndex = 7;
            this.btnRunMonthlyPension.Text = "Run Monthly Pension";
            this.btnRunMonthlyPension.UseVisualStyleBackColor = false;
            this.btnRunMonthlyPension.Click += new System.EventHandler(this.btnRunMonthlyPension_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.Color.Orange;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1635, 166);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 45);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Monthly_Pension_Process
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1796, 822);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRunMonthlyPension);
            this.Controls.Add(this.pnlEmployee);
            this.Controls.Add(this.dgvMonthlyStatus);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Name = "Monthly_Pension_Process";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly_Pension_Process";
            this.Load += new System.EventHandler(this.Monthly_Pension_Process_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyStatus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvMonthlyStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCurrentBalance;
        private System.Windows.Forms.TextBox txtTotalAccrued;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.TextBox txtMonthlyPension;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnRunMonthlyPension;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pensioner_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monthly_Pension;
        private System.Windows.Forms.DataGridViewTextBoxColumn Current_Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Month_Accrued;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment_Method_Name;
    }   
}