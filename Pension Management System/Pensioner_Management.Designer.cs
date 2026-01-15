namespace Pension_Management_System
{
    partial class Pensioner_Management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvPensioners = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlPensioner = new System.Windows.Forms.Panel();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.dtpRetirement = new System.Windows.Forms.DateTimePicker();
            this.txtLastSalary = new System.Windows.Forms.TextBox();
            this.txtServiceYears = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtNID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPensionerId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pensioner_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NID_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Of_Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retirement_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service_Years = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPensioners)).BeginInit();
            this.pnlPensioner.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 191);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(580, 40);
            this.txtSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pensioner List";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(614, 188);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 45);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvPensioners
            // 
            this.dgvPensioners.AllowUserToAddRows = false;
            this.dgvPensioners.AllowUserToDeleteRows = false;
            this.dgvPensioners.AllowUserToResizeColumns = false;
            this.dgvPensioners.AllowUserToResizeRows = false;
            this.dgvPensioners.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvPensioners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPensioners.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPensioners.BackgroundColor = System.Drawing.Color.White;
            this.dgvPensioners.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPensioners.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPensioners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPensioners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pensioner_ID,
            this.Full_Name,
            this.NID_Num,
            this.Phone_Num,
            this.Email,
            this.Date_Of_Birth,
            this.Retirement_Date,
            this.Service_Years,
            this.Last_Salary});
            this.dgvPensioners.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPensioners.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPensioners.EnableHeadersVisualStyles = false;
            this.dgvPensioners.GridColor = System.Drawing.Color.White;
            this.dgvPensioners.Location = new System.Drawing.Point(13, 236);
            this.dgvPensioners.Margin = new System.Windows.Forms.Padding(0);
            this.dgvPensioners.MultiSelect = false;
            this.dgvPensioners.Name = "dgvPensioners";
            this.dgvPensioners.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPensioners.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPensioners.RowHeadersVisible = false;
            this.dgvPensioners.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPensioners.RowTemplate.DividerHeight = 1;
            this.dgvPensioners.RowTemplate.Height = 30;
            this.dgvPensioners.RowTemplate.ReadOnly = true;
            this.dgvPensioners.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPensioners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPensioners.Size = new System.Drawing.Size(952, 562);
            this.dgvPensioners.TabIndex = 4;
            this.dgvPensioners.VirtualMode = true;
            this.dgvPensioners.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPensioners_CellMouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1184, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 49);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pensioner Information";
            // 
            // pnlPensioner
            // 
            this.pnlPensioner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlPensioner.BackColor = System.Drawing.Color.LightYellow;
            this.pnlPensioner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPensioner.Controls.Add(this.dtpDOB);
            this.pnlPensioner.Controls.Add(this.dtpRetirement);
            this.pnlPensioner.Controls.Add(this.txtLastSalary);
            this.pnlPensioner.Controls.Add(this.txtServiceYears);
            this.pnlPensioner.Controls.Add(this.txtEmail);
            this.pnlPensioner.Controls.Add(this.txtPhone);
            this.pnlPensioner.Controls.Add(this.txtNID);
            this.pnlPensioner.Controls.Add(this.txtName);
            this.pnlPensioner.Controls.Add(this.label12);
            this.pnlPensioner.Controls.Add(this.label11);
            this.pnlPensioner.Controls.Add(this.label10);
            this.pnlPensioner.Controls.Add(this.label9);
            this.pnlPensioner.Controls.Add(this.label8);
            this.pnlPensioner.Controls.Add(this.label7);
            this.pnlPensioner.Controls.Add(this.label6);
            this.pnlPensioner.Controls.Add(this.label5);
            this.pnlPensioner.Controls.Add(this.btnRefresh);
            this.pnlPensioner.Controls.Add(this.btnDelete);
            this.pnlPensioner.Controls.Add(this.btnSave);
            this.pnlPensioner.Controls.Add(this.txtPensionerId);
            this.pnlPensioner.Controls.Add(this.label4);
            this.pnlPensioner.Location = new System.Drawing.Point(1021, 191);
            this.pnlPensioner.Name = "pnlPensioner";
            this.pnlPensioner.Size = new System.Drawing.Size(729, 607);
            this.pnlPensioner.TabIndex = 6;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(258, 269);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(410, 36);
            this.dtpDOB.TabIndex = 30;
            // 
            // dtpRetirement
            // 
            this.dtpRetirement.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRetirement.Location = new System.Drawing.Point(258, 319);
            this.dtpRetirement.Name = "dtpRetirement";
            this.dtpRetirement.Size = new System.Drawing.Size(417, 36);
            this.dtpRetirement.TabIndex = 29;
            // 
            // txtLastSalary
            // 
            this.txtLastSalary.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastSalary.Location = new System.Drawing.Point(258, 422);
            this.txtLastSalary.Name = "txtLastSalary";
            this.txtLastSalary.Size = new System.Drawing.Size(410, 36);
            this.txtLastSalary.TabIndex = 28;
            // 
            // txtServiceYears
            // 
            this.txtServiceYears.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceYears.Location = new System.Drawing.Point(258, 372);
            this.txtServiceYears.Name = "txtServiceYears";
            this.txtServiceYears.Size = new System.Drawing.Size(410, 36);
            this.txtServiceYears.TabIndex = 27;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(258, 222);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(410, 36);
            this.txtEmail.TabIndex = 26;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(258, 172);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(410, 36);
            this.txtPhone.TabIndex = 25;
            // 
            // txtNID
            // 
            this.txtNID.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNID.Location = new System.Drawing.Point(258, 122);
            this.txtNID.Name = "txtNID";
            this.txtNID.Size = new System.Drawing.Size(410, 36);
            this.txtNID.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(258, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(410, 36);
            this.txtName.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 35);
            this.label12.TabIndex = 22;
            this.label12.Text = "Email : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 35);
            this.label11.TabIndex = 21;
            this.label11.Text = "Service Year : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 35);
            this.label10.TabIndex = 20;
            this.label10.Text = "Last Salary : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 35);
            this.label9.TabIndex = 19;
            this.label9.Text = "Date of Birth : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 35);
            this.label8.TabIndex = 18;
            this.label8.Text = "Phone num : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 35);
            this.label7.TabIndex = 17;
            this.label7.Text = "NID num : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 35);
            this.label6.TabIndex = 16;
            this.label6.Text = "Retirement Date : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 35);
            this.label5.TabIndex = 15;
            this.label5.Text = "Name : ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.Color.Orange;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(340, 525);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 45);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(558, 525);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 45);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(135, 525);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPensionerId
            // 
            this.txtPensionerId.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPensionerId.Location = new System.Drawing.Point(258, 22);
            this.txtPensionerId.Name = "txtPensionerId";
            this.txtPensionerId.ReadOnly = true;
            this.txtPensionerId.Size = new System.Drawing.Size(410, 36);
            this.txtPensionerId.TabIndex = 11;
            this.txtPensionerId.Text = "ID Auto Generated";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pensioner ID : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(644, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pensioner Management";
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
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1760, 113);
            this.panel1.TabIndex = 0;
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
            this.Full_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Full_Name.DataPropertyName = "Full_Name";
            this.Full_Name.DividerWidth = 1;
            this.Full_Name.HeaderText = "Name";
            this.Full_Name.MinimumWidth = 6;
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.ReadOnly = true;
            this.Full_Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Full_Name.Width = 112;
            // 
            // NID_Num
            // 
            this.NID_Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NID_Num.DataPropertyName = "NID_Num";
            this.NID_Num.DividerWidth = 1;
            this.NID_Num.HeaderText = "NID Number";
            this.NID_Num.MinimumWidth = 6;
            this.NID_Num.Name = "NID_Num";
            this.NID_Num.ReadOnly = true;
            this.NID_Num.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NID_Num.Width = 187;
            // 
            // Phone_Num
            // 
            this.Phone_Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Phone_Num.DataPropertyName = "Phone_Num";
            this.Phone_Num.DividerWidth = 1;
            this.Phone_Num.HeaderText = "Phone Number";
            this.Phone_Num.MinimumWidth = 6;
            this.Phone_Num.Name = "Phone_Num";
            this.Phone_Num.ReadOnly = true;
            this.Phone_Num.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Phone_Num.Width = 218;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.DataPropertyName = "Email";
            this.Email.DividerWidth = 1;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Email.Width = 106;
            // 
            // Date_Of_Birth
            // 
            this.Date_Of_Birth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Date_Of_Birth.DataPropertyName = "Date_Of_Birth";
            this.Date_Of_Birth.DividerWidth = 1;
            this.Date_Of_Birth.HeaderText = "DOB";
            this.Date_Of_Birth.MinimumWidth = 6;
            this.Date_Of_Birth.Name = "Date_Of_Birth";
            this.Date_Of_Birth.ReadOnly = true;
            this.Date_Of_Birth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Date_Of_Birth.Width = 96;
            // 
            // Retirement_Date
            // 
            this.Retirement_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Retirement_Date.DataPropertyName = "Retirement_Date";
            this.Retirement_Date.DividerWidth = 1;
            this.Retirement_Date.HeaderText = "Retirement Date";
            this.Retirement_Date.MinimumWidth = 6;
            this.Retirement_Date.Name = "Retirement_Date";
            this.Retirement_Date.ReadOnly = true;
            this.Retirement_Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Retirement_Date.Width = 233;
            // 
            // Service_Years
            // 
            this.Service_Years.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Service_Years.DataPropertyName = "Service_Years";
            this.Service_Years.DividerWidth = 1;
            this.Service_Years.HeaderText = "Service Years";
            this.Service_Years.MinimumWidth = 6;
            this.Service_Years.Name = "Service_Years";
            this.Service_Years.ReadOnly = true;
            this.Service_Years.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Service_Years.Width = 193;
            // 
            // Last_Salary
            // 
            this.Last_Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Last_Salary.DataPropertyName = "Last_Salary";
            this.Last_Salary.DividerWidth = 1;
            this.Last_Salary.HeaderText = "Last Salary";
            this.Last_Salary.MinimumWidth = 6;
            this.Last_Salary.Name = "Last_Salary";
            this.Last_Salary.ReadOnly = true;
            this.Last_Salary.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Last_Salary.Width = 164;
            // 
            // Pensioner_Management
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1762, 822);
            this.Controls.Add(this.pnlPensioner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPensioners);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Name = "Pensioner_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Management";
            this.Load += new System.EventHandler(this.Pensioner_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPensioners)).EndInit();
            this.pnlPensioner.ResumeLayout(false);
            this.pnlPensioner.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvPensioners;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlPensioner;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPensionerId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastSalary;
        private System.Windows.Forms.TextBox txtServiceYears;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtNID;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.DateTimePicker dtpRetirement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pensioner_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn NID_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Of_Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retirement_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_Years;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Salary;
    }

        
    
}