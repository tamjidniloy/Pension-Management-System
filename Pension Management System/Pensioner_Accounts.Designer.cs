namespace Pension_Management_System
{
    partial class Pensioner_Accounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.dtpPensionStartDate = new System.Windows.Forms.DateTimePicker();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.txtPensionerName = new System.Windows.Forms.TextBox();
            this.txtPensionerNID = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonthlyPension = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPensioners = new System.Windows.Forms.DataGridView();
            this.Pensioner_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NID_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPensionerAccounts = new System.Windows.Forms.DataGridView();
            this.btnSearchAccount = new System.Windows.Forms.Button();
            this.txtSearchPensionerAccount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbNewPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnUpdatePaymentMethod = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOldPaymentMethod = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.PensionerAccountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFull_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNID_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monthly_Pension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment_Method_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEmployee.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPensioners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPensionerAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(24, 158);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(522, 40);
            this.txtSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pensioner List";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(552, 152);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 50);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1063, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pension Accounts Information";
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.BackColor = System.Drawing.Color.LightYellow;
            this.pnlEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployee.Controls.Add(this.dtpPensionStartDate);
            this.pnlEmployee.Controls.Add(this.cmbPaymentMethod);
            this.pnlEmployee.Controls.Add(this.lblPaymentMethod);
            this.pnlEmployee.Controls.Add(this.txtPensionerName);
            this.pnlEmployee.Controls.Add(this.txtPensionerNID);
            this.pnlEmployee.Controls.Add(this.btnCreateAccount);
            this.pnlEmployee.Controls.Add(this.label5);
            this.pnlEmployee.Controls.Add(this.label4);
            this.pnlEmployee.Controls.Add(this.txtMonthlyPension);
            this.pnlEmployee.Controls.Add(this.label8);
            this.pnlEmployee.Controls.Add(this.label6);
            this.pnlEmployee.Location = new System.Drawing.Point(15, 458);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(654, 405);
            this.pnlEmployee.TabIndex = 6;
            // 
            // dtpPensionStartDate
            // 
            this.dtpPensionStartDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpPensionStartDate.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPensionStartDate.Location = new System.Drawing.Point(258, 231);
            this.dtpPensionStartDate.Name = "dtpPensionStartDate";
            this.dtpPensionStartDate.Size = new System.Drawing.Size(343, 36);
            this.dtpPensionStartDate.TabIndex = 19;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(258, 18);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(249, 36);
            this.cmbPaymentMethod.TabIndex = 18;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(16, 19);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(236, 35);
            this.lblPaymentMethod.TabIndex = 17;
            this.lblPaymentMethod.Text = "Payment Method : ";
            // 
            // txtPensionerName
            // 
            this.txtPensionerName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPensionerName.Location = new System.Drawing.Point(258, 66);
            this.txtPensionerName.Name = "txtPensionerName";
            this.txtPensionerName.ReadOnly = true;
            this.txtPensionerName.Size = new System.Drawing.Size(377, 36);
            this.txtPensionerName.TabIndex = 16;
            // 
            // txtPensionerNID
            // 
            this.txtPensionerNID.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPensionerNID.Location = new System.Drawing.Point(258, 122);
            this.txtPensionerNID.Name = "txtPensionerNID";
            this.txtPensionerNID.ReadOnly = true;
            this.txtPensionerNID.Size = new System.Drawing.Size(377, 36);
            this.txtPensionerNID.TabIndex = 13;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.AutoSize = true;
            this.btnCreateAccount.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAccount.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(147, 318);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(302, 50);
            this.btnCreateAccount.TabIndex = 11;
            this.btnCreateAccount.Text = "Create Pension Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 35);
            this.label5.TabIndex = 12;
            this.label5.Text = "Starting date : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "Monthly Pension : ";
            // 
            // txtMonthlyPension
            // 
            this.txtMonthlyPension.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthlyPension.Location = new System.Drawing.Point(258, 180);
            this.txtMonthlyPension.Name = "txtMonthlyPension";
            this.txtMonthlyPension.ReadOnly = true;
            this.txtMonthlyPension.Size = new System.Drawing.Size(377, 36);
            this.txtMonthlyPension.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 35);
            this.label8.TabIndex = 4;
            this.label8.Text = "NID num : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 35);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pensioner Accounts Manage";
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
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1760, 109);
            this.panel1.TabIndex = 0;
            // 
            // dgvPensioners
            // 
            this.dgvPensioners.AllowUserToAddRows = false;
            this.dgvPensioners.AllowUserToDeleteRows = false;
            this.dgvPensioners.AllowUserToResizeColumns = false;
            this.dgvPensioners.AllowUserToResizeRows = false;
            this.dgvPensioners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPensioners.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPensioners.BackgroundColor = System.Drawing.Color.White;
            this.dgvPensioners.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPensioners.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPensioners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPensioners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pensioner_ID,
            this.Full_Name,
            this.NID_Num});
            this.dgvPensioners.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPensioners.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPensioners.EnableHeadersVisualStyles = false;
            this.dgvPensioners.GridColor = System.Drawing.Color.White;
            this.dgvPensioners.Location = new System.Drawing.Point(15, 225);
            this.dgvPensioners.Margin = new System.Windows.Forms.Padding(0);
            this.dgvPensioners.MultiSelect = false;
            this.dgvPensioners.Name = "dgvPensioners";
            this.dgvPensioners.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPensioners.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPensioners.RowHeadersVisible = false;
            this.dgvPensioners.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPensioners.RowTemplate.DividerHeight = 1;
            this.dgvPensioners.RowTemplate.Height = 30;
            this.dgvPensioners.RowTemplate.ReadOnly = true;
            this.dgvPensioners.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPensioners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPensioners.Size = new System.Drawing.Size(654, 230);
            this.dgvPensioners.TabIndex = 7;
            this.dgvPensioners.VirtualMode = true;
            this.dgvPensioners.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPensioners_CellMouseDoubleClick);
            // 
            // Pensioner_ID
            // 
            this.Pensioner_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pensioner_ID.DataPropertyName = "Pensioner_ID";
            this.Pensioner_ID.DividerWidth = 1;
            this.Pensioner_ID.HeaderText = "Pentioner ID";
            this.Pensioner_ID.MinimumWidth = 6;
            this.Pensioner_ID.Name = "Pensioner_ID";
            this.Pensioner_ID.ReadOnly = true;
            this.Pensioner_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Pensioner_ID.Width = 187;
            // 
            // Full_Name
            // 
            this.Full_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Full_Name.DataPropertyName = "Full_Name";
            this.Full_Name.DividerWidth = 1;
            this.Full_Name.HeaderText = "Pensioner Name";
            this.Full_Name.MinimumWidth = 6;
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.ReadOnly = true;
            this.Full_Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NID_Num
            // 
            this.NID_Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NID_Num.DataPropertyName = "NID_Num";
            this.NID_Num.DividerWidth = 1;
            this.NID_Num.HeaderText = "NID Number";
            this.NID_Num.MinimumWidth = 6;
            this.NID_Num.Name = "NID_Num";
            this.NID_Num.ReadOnly = true;
            this.NID_Num.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvPensionerAccounts
            // 
            this.dgvPensionerAccounts.AllowUserToAddRows = false;
            this.dgvPensionerAccounts.AllowUserToDeleteRows = false;
            this.dgvPensionerAccounts.AllowUserToResizeColumns = false;
            this.dgvPensionerAccounts.AllowUserToResizeRows = false;
            this.dgvPensionerAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPensionerAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPensionerAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvPensionerAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPensionerAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPensionerAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPensionerAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PensionerAccountId,
            this.dgvFull_Name,
            this.dgvNID_Num,
            this.Monthly_Pension,
            this.Payment_Method_Name});
            this.dgvPensionerAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPensionerAccounts.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPensionerAccounts.EnableHeadersVisualStyles = false;
            this.dgvPensionerAccounts.GridColor = System.Drawing.Color.White;
            this.dgvPensionerAccounts.Location = new System.Drawing.Point(763, 225);
            this.dgvPensionerAccounts.Margin = new System.Windows.Forms.Padding(0);
            this.dgvPensionerAccounts.MultiSelect = false;
            this.dgvPensionerAccounts.Name = "dgvPensionerAccounts";
            this.dgvPensionerAccounts.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPensionerAccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPensionerAccounts.RowHeadersVisible = false;
            this.dgvPensionerAccounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPensionerAccounts.RowTemplate.DividerHeight = 1;
            this.dgvPensionerAccounts.RowTemplate.Height = 30;
            this.dgvPensionerAccounts.RowTemplate.ReadOnly = true;
            this.dgvPensionerAccounts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPensionerAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPensionerAccounts.Size = new System.Drawing.Size(964, 504);
            this.dgvPensionerAccounts.TabIndex = 8;
            this.dgvPensionerAccounts.VirtualMode = true;
            this.dgvPensionerAccounts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPensionerAccounts_CellMouseDoubleClick);
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.AutoSize = true;
            this.btnSearchAccount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearchAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchAccount.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAccount.Location = new System.Drawing.Point(1610, 168);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(117, 45);
            this.btnSearchAccount.TabIndex = 10;
            this.btnSearchAccount.Text = "Search";
            this.btnSearchAccount.UseVisualStyleBackColor = false;
            // 
            // txtSearchPensionerAccount
            // 
            this.txtSearchPensionerAccount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearchPensionerAccount.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPensionerAccount.Location = new System.Drawing.Point(984, 168);
            this.txtSearchPensionerAccount.Name = "txtSearchPensionerAccount";
            this.txtSearchPensionerAccount.Size = new System.Drawing.Size(620, 40);
            this.txtSearchPensionerAccount.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(952, 801);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(328, 35);
            this.label10.TabIndex = 20;
            this.label10.Text = "Change Payment Method : ";
            // 
            // cmbNewPaymentMethod
            // 
            this.cmbNewPaymentMethod.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNewPaymentMethod.FormattingEnabled = true;
            this.cmbNewPaymentMethod.Location = new System.Drawing.Point(1296, 802);
            this.cmbNewPaymentMethod.Name = "cmbNewPaymentMethod";
            this.cmbNewPaymentMethod.Size = new System.Drawing.Size(249, 36);
            this.cmbNewPaymentMethod.TabIndex = 20;
            // 
            // btnUpdatePaymentMethod
            // 
            this.btnUpdatePaymentMethod.AutoSize = true;
            this.btnUpdatePaymentMethod.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdatePaymentMethod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePaymentMethod.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePaymentMethod.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePaymentMethod.Location = new System.Drawing.Point(1564, 792);
            this.btnUpdatePaymentMethod.Name = "btnUpdatePaymentMethod";
            this.btnUpdatePaymentMethod.Size = new System.Drawing.Size(141, 50);
            this.btnUpdatePaymentMethod.TabIndex = 20;
            this.btnUpdatePaymentMethod.Text = "Update";
            this.btnUpdatePaymentMethod.UseVisualStyleBackColor = false;
            this.btnUpdatePaymentMethod.Click += new System.EventHandler(this.btnUpdatePaymentMethod_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(938, 750);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(342, 35);
            this.label11.TabIndex = 20;
            this.label11.Text = "Previous Payment Method : ";
            // 
            // txtOldPaymentMethod
            // 
            this.txtOldPaymentMethod.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPaymentMethod.Location = new System.Drawing.Point(1296, 747);
            this.txtOldPaymentMethod.Name = "txtOldPaymentMethod";
            this.txtOldPaymentMethod.ReadOnly = true;
            this.txtOldPaymentMethod.Size = new System.Drawing.Size(249, 36);
            this.txtOldPaymentMethod.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(736, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 50);
            this.button3.TabIndex = 21;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PensionerAccountId
            // 
            this.PensionerAccountId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PensionerAccountId.DataPropertyName = "PensionerAccountID";
            this.PensionerAccountId.DividerWidth = 1;
            this.PensionerAccountId.HeaderText = "Account ID";
            this.PensionerAccountId.MinimumWidth = 6;
            this.PensionerAccountId.Name = "PensionerAccountId";
            this.PensionerAccountId.ReadOnly = true;
            this.PensionerAccountId.Width = 169;
            // 
            // dgvFull_Name
            // 
            this.dgvFull_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvFull_Name.DataPropertyName = "Full_Name";
            this.dgvFull_Name.DividerWidth = 1;
            this.dgvFull_Name.HeaderText = "Name";
            this.dgvFull_Name.MinimumWidth = 6;
            this.dgvFull_Name.Name = "dgvFull_Name";
            this.dgvFull_Name.ReadOnly = true;
            // 
            // dgvNID_Num
            // 
            this.dgvNID_Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNID_Num.DataPropertyName = "NID_Num";
            this.dgvNID_Num.DividerWidth = 1;
            this.dgvNID_Num.HeaderText = "NID Number";
            this.dgvNID_Num.MinimumWidth = 6;
            this.dgvNID_Num.Name = "dgvNID_Num";
            this.dgvNID_Num.ReadOnly = true;
            // 
            // Monthly_Pension
            // 
            this.Monthly_Pension.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Monthly_Pension.DataPropertyName = "Monthly_Pension";
            this.Monthly_Pension.DividerWidth = 1;
            this.Monthly_Pension.HeaderText = "Amount";
            this.Monthly_Pension.MinimumWidth = 6;
            this.Monthly_Pension.Name = "Monthly_Pension";
            this.Monthly_Pension.ReadOnly = true;
            this.Monthly_Pension.Width = 137;
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
            // Pensioner_Accounts
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1762, 886);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtOldPaymentMethod);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnUpdatePaymentMethod);
            this.Controls.Add(this.cmbNewPaymentMethod);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSearchAccount);
            this.Controls.Add(this.txtSearchPensionerAccount);
            this.Controls.Add(this.dgvPensionerAccounts);
            this.Controls.Add(this.dgvPensioners);
            this.Controls.Add(this.pnlEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Pensioner_Accounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Management";
            this.Load += new System.EventHandler(this.Pensioner_Accounts_Load);
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPensioners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPensionerAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMonthlyPension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPensioners;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pensioner_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn NID_Num;
        private System.Windows.Forms.DataGridView dgvPensionerAccounts;
        private System.Windows.Forms.Button btnSearchAccount;
        private System.Windows.Forms.TextBox txtSearchPensionerAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox txtPensionerName;
        private System.Windows.Forms.TextBox txtPensionerNID;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.DateTimePicker dtpPensionStartDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbNewPaymentMethod;
        private System.Windows.Forms.Button btnUpdatePaymentMethod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOldPaymentMethod;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PensionerAccountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFull_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNID_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monthly_Pension;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment_Method_Name;
    }

       
    
}