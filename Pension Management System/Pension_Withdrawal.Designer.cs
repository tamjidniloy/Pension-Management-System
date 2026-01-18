namespace Pension_Management_System
{
    partial class Pension_Withdrawal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.PensionerAccountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pensioner_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Current_Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment_Method_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NID_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.txtPensionerID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtWithdrawAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNIDnum = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtPaymentMethod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCash = new System.Windows.Forms.Panel();
            this.btnWithdrawCash = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBank = new System.Windows.Forms.Panel();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.txtBankAccount = new System.Windows.Forms.TextBox();
            this.btnTransferBank = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlMFS = new System.Windows.Forms.Panel();
            this.txtMFSPhone = new System.Windows.Forms.TextBox();
            this.btnTransferMFS = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.pnlEmployee.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCash.SuspendLayout();
            this.pnlBank.SuspendLayout();
            this.pnlMFS.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(152, 155);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(379, 36);
            this.txtSearch.TabIndex = 1;
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AllowUserToResizeColumns = false;
            this.dgvAccounts.AllowUserToResizeRows = false;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.NullValue = null;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PensionerAccountId,
            this.Pensioner_Id,
            this.Full_Name,
            this.Current_Balance,
            this.Payment_Method_Name,
            this.NID_Num});
            this.dgvAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounts.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgvAccounts.EnableHeadersVisualStyles = false;
            this.dgvAccounts.GridColor = System.Drawing.Color.White;
            this.dgvAccounts.Location = new System.Drawing.Point(36, 242);
            this.dgvAccounts.Margin = new System.Windows.Forms.Padding(0);
            this.dgvAccounts.MultiSelect = false;
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAccounts.RowTemplate.DividerHeight = 1;
            this.dgvAccounts.RowTemplate.Height = 30;
            this.dgvAccounts.RowTemplate.ReadOnly = true;
            this.dgvAccounts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(952, 633);
            this.dgvAccounts.TabIndex = 4;
            this.dgvAccounts.VirtualMode = true;
            this.dgvAccounts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAccounts_CellMouseDoubleClick);
            // 
            // PensionerAccountId
            // 
            this.PensionerAccountId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PensionerAccountId.DataPropertyName = "PensionerAccountId";
            this.PensionerAccountId.DividerWidth = 1;
            this.PensionerAccountId.HeaderText = "Account Num";
            this.PensionerAccountId.MinimumWidth = 6;
            this.PensionerAccountId.Name = "PensionerAccountId";
            this.PensionerAccountId.ReadOnly = true;
            this.PensionerAccountId.Width = 200;
            // 
            // Pensioner_Id
            // 
            this.Pensioner_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pensioner_Id.DataPropertyName = "Pensioner_Id";
            this.Pensioner_Id.DividerWidth = 1;
            this.Pensioner_Id.HeaderText = "Pensioner ID";
            this.Pensioner_Id.MinimumWidth = 6;
            this.Pensioner_Id.Name = "Pensioner_Id";
            this.Pensioner_Id.ReadOnly = true;
            this.Pensioner_Id.Width = 188;
            // 
            // Full_Name
            // 
            this.Full_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Full_Name.DataPropertyName = "Full_Name";
            this.Full_Name.DividerWidth = 1;
            this.Full_Name.HeaderText = "Full Name";
            this.Full_Name.MinimumWidth = 6;
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.ReadOnly = true;
            this.Full_Name.Width = 158;
            // 
            // Current_Balance
            // 
            this.Current_Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Current_Balance.DataPropertyName = "Current_Balance";
            this.Current_Balance.DividerWidth = 1;
            this.Current_Balance.HeaderText = "Balance";
            this.Current_Balance.MinimumWidth = 6;
            this.Current_Balance.Name = "Current_Balance";
            this.Current_Balance.ReadOnly = true;
            this.Current_Balance.Width = 133;
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
            // NID_Num
            // 
            this.NID_Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NID_Num.DataPropertyName = "NID_Num";
            this.NID_Num.DividerWidth = 1;
            this.NID_Num.HeaderText = "NID Num";
            this.NID_Num.MinimumWidth = 6;
            this.NID_Num.Name = "NID_Num";
            this.NID_Num.ReadOnly = true;
            this.NID_Num.Width = 148;
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.BackColor = System.Drawing.Color.LightYellow;
            this.pnlEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployee.Controls.Add(this.txtPensionerID);
            this.pnlEmployee.Controls.Add(this.label13);
            this.pnlEmployee.Controls.Add(this.txtWithdrawAmount);
            this.pnlEmployee.Controls.Add(this.label9);
            this.pnlEmployee.Controls.Add(this.txtAccountId);
            this.pnlEmployee.Controls.Add(this.txtName);
            this.pnlEmployee.Controls.Add(this.txtNIDnum);
            this.pnlEmployee.Controls.Add(this.txtBalance);
            this.pnlEmployee.Controls.Add(this.txtPaymentMethod);
            this.pnlEmployee.Controls.Add(this.label8);
            this.pnlEmployee.Controls.Add(this.label7);
            this.pnlEmployee.Controls.Add(this.label6);
            this.pnlEmployee.Controls.Add(this.label5);
            this.pnlEmployee.Controls.Add(this.label4);
            this.pnlEmployee.Location = new System.Drawing.Point(1036, 211);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(690, 403);
            this.pnlEmployee.TabIndex = 6;
            // 
            // txtPensionerID
            // 
            this.txtPensionerID.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPensionerID.Location = new System.Drawing.Point(271, 65);
            this.txtPensionerID.Name = "txtPensionerID";
            this.txtPensionerID.ReadOnly = true;
            this.txtPensionerID.Size = new System.Drawing.Size(380, 36);
            this.txtPensionerID.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(176, 35);
            this.label13.TabIndex = 18;
            this.label13.Text = "Pensioner ID :";
            // 
            // txtWithdrawAmount
            // 
            this.txtWithdrawAmount.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWithdrawAmount.Location = new System.Drawing.Point(353, 337);
            this.txtWithdrawAmount.Name = "txtWithdrawAmount";
            this.txtWithdrawAmount.Size = new System.Drawing.Size(237, 40);
            this.txtWithdrawAmount.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(315, 35);
            this.label9.TabIndex = 16;
            this.label9.Text = "Enter Withdraw Amount :";
            // 
            // txtAccountId
            // 
            this.txtAccountId.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountId.Location = new System.Drawing.Point(271, 11);
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.ReadOnly = true;
            this.txtAccountId.Size = new System.Drawing.Size(380, 36);
            this.txtAccountId.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(271, 114);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(380, 36);
            this.txtName.TabIndex = 8;
            // 
            // txtNIDnum
            // 
            this.txtNIDnum.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIDnum.Location = new System.Drawing.Point(271, 170);
            this.txtNIDnum.Name = "txtNIDnum";
            this.txtNIDnum.ReadOnly = true;
            this.txtNIDnum.Size = new System.Drawing.Size(380, 36);
            this.txtNIDnum.TabIndex = 7;
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(271, 225);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(380, 36);
            this.txtBalance.TabIndex = 6;
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentMethod.Location = new System.Drawing.Point(271, 281);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.ReadOnly = true;
            this.txtPaymentMethod.Size = new System.Drawing.Size(380, 36);
            this.txtPaymentMethod.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 35);
            this.label8.TabIndex = 4;
            this.label8.Text = "Payment Method :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 35);
            this.label7.TabIndex = 3;
            this.label7.Text = "Current Balance :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 35);
            this.label6.TabIndex = 2;
            this.label6.Text = "NID num :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 35);
            this.label5.TabIndex = 1;
            this.label5.Text = "Full Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Account Num :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(895, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pension Withdrawal Management ";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Tomato;
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
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1760, 113);
            this.panel1.TabIndex = 0;
            // 
            // pnlCash
            // 
            this.pnlCash.BackColor = System.Drawing.Color.LightYellow;
            this.pnlCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCash.Controls.Add(this.btnWithdrawCash);
            this.pnlCash.Location = new System.Drawing.Point(1036, 620);
            this.pnlCash.Name = "pnlCash";
            this.pnlCash.Size = new System.Drawing.Size(690, 60);
            this.pnlCash.TabIndex = 7;
            // 
            // btnWithdrawCash
            // 
            this.btnWithdrawCash.AutoSize = true;
            this.btnWithdrawCash.BackColor = System.Drawing.Color.LightGreen;
            this.btnWithdrawCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdrawCash.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrawCash.Location = new System.Drawing.Point(234, 3);
            this.btnWithdrawCash.Name = "btnWithdrawCash";
            this.btnWithdrawCash.Size = new System.Drawing.Size(212, 51);
            this.btnWithdrawCash.TabIndex = 12;
            this.btnWithdrawCash.Text = "Withdraw";
            this.btnWithdrawCash.UseVisualStyleBackColor = false;
            this.btnWithdrawCash.Click += new System.EventHandler(this.btnWithdrawCash_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1195, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pensioner Account Info";
            // 
            // pnlBank
            // 
            this.pnlBank.BackColor = System.Drawing.Color.LightYellow;
            this.pnlBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBank.Controls.Add(this.cmbBank);
            this.pnlBank.Controls.Add(this.txtBankAccount);
            this.pnlBank.Controls.Add(this.btnTransferBank);
            this.pnlBank.Controls.Add(this.label11);
            this.pnlBank.Controls.Add(this.label10);
            this.pnlBank.Location = new System.Drawing.Point(1013, 656);
            this.pnlBank.Name = "pnlBank";
            this.pnlBank.Size = new System.Drawing.Size(690, 192);
            this.pnlBank.TabIndex = 8;
            // 
            // cmbBank
            // 
            this.cmbBank.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(281, 17);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(226, 41);
            this.cmbBank.TabIndex = 19;
            // 
            // txtBankAccount
            // 
            this.txtBankAccount.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankAccount.Location = new System.Drawing.Point(281, 69);
            this.txtBankAccount.Name = "txtBankAccount";
            this.txtBankAccount.Size = new System.Drawing.Size(391, 40);
            this.txtBankAccount.TabIndex = 18;
            // 
            // btnTransferBank
            // 
            this.btnTransferBank.AutoSize = true;
            this.btnTransferBank.BackColor = System.Drawing.Color.LightGreen;
            this.btnTransferBank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransferBank.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferBank.Location = new System.Drawing.Point(235, 127);
            this.btnTransferBank.Name = "btnTransferBank";
            this.btnTransferBank.Size = new System.Drawing.Size(212, 51);
            this.btnTransferBank.TabIndex = 13;
            this.btnTransferBank.Text = "Withdraw";
            this.btnTransferBank.UseVisualStyleBackColor = false;
            this.btnTransferBank.Click += new System.EventHandler(this.btnTransferBank_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(251, 35);
            this.label11.TabIndex = 5;
            this.label11.Text = "Bank Account Num :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 35);
            this.label10.TabIndex = 4;
            this.label10.Text = "Select Bank :";
            // 
            // pnlMFS
            // 
            this.pnlMFS.BackColor = System.Drawing.Color.LightYellow;
            this.pnlMFS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMFS.Controls.Add(this.txtMFSPhone);
            this.pnlMFS.Controls.Add(this.btnTransferMFS);
            this.pnlMFS.Controls.Add(this.label12);
            this.pnlMFS.Location = new System.Drawing.Point(1036, 635);
            this.pnlMFS.Name = "pnlMFS";
            this.pnlMFS.Size = new System.Drawing.Size(690, 198);
            this.pnlMFS.TabIndex = 9;
            // 
            // txtMFSPhone
            // 
            this.txtMFSPhone.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMFSPhone.Location = new System.Drawing.Point(244, 20);
            this.txtMFSPhone.Name = "txtMFSPhone";
            this.txtMFSPhone.Size = new System.Drawing.Size(391, 40);
            this.txtMFSPhone.TabIndex = 18;
            // 
            // btnTransferMFS
            // 
            this.btnTransferMFS.AutoSize = true;
            this.btnTransferMFS.BackColor = System.Drawing.Color.LightGreen;
            this.btnTransferMFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransferMFS.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferMFS.Location = new System.Drawing.Point(217, 82);
            this.btnTransferMFS.Name = "btnTransferMFS";
            this.btnTransferMFS.Size = new System.Drawing.Size(212, 51);
            this.btnTransferMFS.TabIndex = 13;
            this.btnTransferMFS.Text = "Withdraw";
            this.btnTransferMFS.UseVisualStyleBackColor = false;
            this.btnTransferMFS.Click += new System.EventHandler(this.btnTransferMFS_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 35);
            this.label12.TabIndex = 5;
            this.label12.Text = "Phone Number :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.Color.Orange;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(979, 148);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 45);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(549, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 45);
            this.button2.TabIndex = 17;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pension_Withdrawal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1762, 884);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pnlMFS);
            this.Controls.Add(this.pnlBank);
            this.Controls.Add(this.pnlCash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlEmployee);
            this.Controls.Add(this.dgvAccounts);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Name = "Pension_Withdrawal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Management";
            this.Load += new System.EventHandler(this.Pension_Withdrawal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCash.ResumeLayout(false);
            this.pnlCash.PerformLayout();
            this.pnlBank.ResumeLayout(false);
            this.pnlBank.PerformLayout();
            this.pnlMFS.ResumeLayout(false);
            this.pnlMFS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPaymentMethod;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtAccountId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNIDnum;
        private System.Windows.Forms.Panel pnlBank;
        private System.Windows.Forms.Button btnWithdrawCash;
        private System.Windows.Forms.TextBox txtWithdrawAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTransferBank;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBankAccount;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.Panel pnlMFS;
        private System.Windows.Forms.TextBox txtMFSPhone;
        private System.Windows.Forms.Button btnTransferMFS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn PensionerAccountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pensioner_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Current_Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment_Method_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn NID_Num;
        private System.Windows.Forms.TextBox txtPensionerID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
    }
}