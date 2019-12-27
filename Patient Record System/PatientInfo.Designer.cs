namespace Patient_Record_System
{
    partial class PatientInfo
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
            this.tbpPatientRegister = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.tbpPatientDetails = new System.Windows.Forms.TabPage();
            this.grbAppointments = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pVisitTime = new System.Windows.Forms.DateTimePicker();
            this.pVisitDate = new System.Windows.Forms.DateTimePicker();
            this.dgvVisits = new System.Windows.Forms.DataGridView();
            this.dgvtxtVisitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVisitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVisitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pInfo = new System.Windows.Forms.GroupBox();
            this.pBT = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gContact = new System.Windows.Forms.MaskedTextBox();
            this.gName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pStatus = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pContact = new System.Windows.Forms.MaskedTextBox();
            this.pAge = new System.Windows.Forms.ComboBox();
            this.pGender = new System.Windows.Forms.ComboBox();
            this.pEmail = new System.Windows.Forms.TextBox();
            this.pName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.lblHomePage = new System.Windows.Forms.LinkLabel();
            this.tbpPatientRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.tbpPatientDetails.SuspendLayout();
            this.grbAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).BeginInit();
            this.panel1.SuspendLayout();
            this.pInfo.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpPatientRegister
            // 
            this.tbpPatientRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.tbpPatientRegister.Controls.Add(this.label1);
            this.tbpPatientRegister.Controls.Add(this.dgvPatient);
            this.tbpPatientRegister.Controls.Add(this.btnSearch);
            this.tbpPatientRegister.Controls.Add(this.txtNameSearch);
            this.tbpPatientRegister.Location = new System.Drawing.Point(4, 25);
            this.tbpPatientRegister.Name = "tbpPatientRegister";
            this.tbpPatientRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPatientRegister.Size = new System.Drawing.Size(879, 600);
            this.tbpPatientRegister.TabIndex = 1;
            this.tbpPatientRegister.Text = "Patient Register";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Name";
            // 
            // dgvPatient
            // 
            this.dgvPatient.AllowUserToAddRows = false;
            this.dgvPatient.AllowUserToDeleteRows = false;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Location = new System.Drawing.Point(6, 68);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            this.dgvPatient.Size = new System.Drawing.Size(867, 291);
            this.dgvPatient.TabIndex = 28;
            this.dgvPatient.DoubleClick += new System.EventHandler(this.dgvPatient_DoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Maroon;
            this.btnSearch.Location = new System.Drawing.Point(787, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(68, 31);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(140, 22);
            this.txtNameSearch.TabIndex = 35;
            this.txtNameSearch.TextChanged += new System.EventHandler(this.txtSearchBar_TextChanged);
            // 
            // tbpPatientDetails
            // 
            this.tbpPatientDetails.AutoScroll = true;
            this.tbpPatientDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.tbpPatientDetails.Controls.Add(this.lblHomePage);
            this.tbpPatientDetails.Controls.Add(this.grbAppointments);
            this.tbpPatientDetails.Controls.Add(this.dgvVisits);
            this.tbpPatientDetails.Controls.Add(this.panel1);
            this.tbpPatientDetails.Controls.Add(this.pInfo);
            this.tbpPatientDetails.Location = new System.Drawing.Point(4, 25);
            this.tbpPatientDetails.Name = "tbpPatientDetails";
            this.tbpPatientDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPatientDetails.Size = new System.Drawing.Size(879, 600);
            this.tbpPatientDetails.TabIndex = 0;
            this.tbpPatientDetails.Text = "Patient Details";
            // 
            // grbAppointments
            // 
            this.grbAppointments.Controls.Add(this.label10);
            this.grbAppointments.Controls.Add(this.label7);
            this.grbAppointments.Controls.Add(this.pVisitTime);
            this.grbAppointments.Controls.Add(this.pVisitDate);
            this.grbAppointments.Location = new System.Drawing.Point(55, 298);
            this.grbAppointments.Name = "grbAppointments";
            this.grbAppointments.Size = new System.Drawing.Size(343, 100);
            this.grbAppointments.TabIndex = 34;
            this.grbAppointments.TabStop = false;
            this.grbAppointments.Text = "Appointments";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Visit Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Visit Date";
            // 
            // pVisitTime
            // 
            this.pVisitTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pVisitTime.Location = new System.Drawing.Point(96, 57);
            this.pVisitTime.Name = "pVisitTime";
            this.pVisitTime.ShowUpDown = true;
            this.pVisitTime.Size = new System.Drawing.Size(127, 22);
            this.pVisitTime.TabIndex = 1;
            // 
            // pVisitDate
            // 
            this.pVisitDate.CustomFormat = "";
            this.pVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pVisitDate.Location = new System.Drawing.Point(96, 28);
            this.pVisitDate.Name = "pVisitDate";
            this.pVisitDate.Size = new System.Drawing.Size(127, 22);
            this.pVisitDate.TabIndex = 0;
            // 
            // dgvVisits
            // 
            this.dgvVisits.AllowUserToAddRows = false;
            this.dgvVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtVisitID,
            this.dgvtxtVisitDate,
            this.dgvtxtVisitTime});
            this.dgvVisits.Location = new System.Drawing.Point(449, 298);
            this.dgvVisits.Name = "dgvVisits";
            this.dgvVisits.ReadOnly = true;
            this.dgvVisits.Size = new System.Drawing.Size(402, 228);
            this.dgvVisits.TabIndex = 27;
            this.dgvVisits.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvVisits_UserDeletingRow);
            // 
            // dgvtxtVisitID
            // 
            this.dgvtxtVisitID.DataPropertyName = "Id";
            this.dgvtxtVisitID.HeaderText = "Visit ID";
            this.dgvtxtVisitID.Name = "dgvtxtVisitID";
            this.dgvtxtVisitID.ReadOnly = true;
            this.dgvtxtVisitID.Visible = false;
            // 
            // dgvtxtVisitDate
            // 
            this.dgvtxtVisitDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvtxtVisitDate.DataPropertyName = "Visit Date";
            this.dgvtxtVisitDate.HeaderText = "Visit Date";
            this.dgvtxtVisitDate.Name = "dgvtxtVisitDate";
            this.dgvtxtVisitDate.ReadOnly = true;
            this.dgvtxtVisitDate.Width = 90;
            // 
            // dgvtxtVisitTime
            // 
            this.dgvtxtVisitTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvtxtVisitTime.DataPropertyName = "Time";
            this.dgvtxtVisitTime.HeaderText = "Visit Time";
            this.dgvtxtVisitTime.Name = "dgvtxtVisitTime";
            this.dgvtxtVisitTime.ReadOnly = true;
            this.dgvtxtVisitTime.Width = 92;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(74, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 53);
            this.panel1.TabIndex = 32;
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(166, 13);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(85, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(4, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pInfo
            // 
            this.pInfo.Controls.Add(this.pBT);
            this.pInfo.Controls.Add(this.label6);
            this.pInfo.Controls.Add(this.gContact);
            this.pInfo.Controls.Add(this.gName);
            this.pInfo.Controls.Add(this.label9);
            this.pInfo.Controls.Add(this.label19);
            this.pInfo.Controls.Add(this.pStatus);
            this.pInfo.Controls.Add(this.label16);
            this.pInfo.Controls.Add(this.pContact);
            this.pInfo.Controls.Add(this.pAge);
            this.pInfo.Controls.Add(this.pGender);
            this.pInfo.Controls.Add(this.pEmail);
            this.pInfo.Controls.Add(this.pName);
            this.pInfo.Controls.Add(this.label8);
            this.pInfo.Controls.Add(this.label5);
            this.pInfo.Controls.Add(this.label4);
            this.pInfo.Controls.Add(this.label3);
            this.pInfo.Controls.Add(this.label2);
            this.pInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pInfo.Location = new System.Drawing.Point(28, 18);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(823, 274);
            this.pInfo.TabIndex = 26;
            this.pInfo.TabStop = false;
            this.pInfo.Text = "Patient Information";
            // 
            // pBT
            // 
            this.pBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pBT.FormattingEnabled = true;
            this.pBT.Location = new System.Drawing.Point(597, 93);
            this.pBT.Name = "pBT";
            this.pBT.Size = new System.Drawing.Size(60, 24);
            this.pBT.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(533, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "BT";
            // 
            // gContact
            // 
            this.gContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gContact.Location = new System.Drawing.Point(187, 177);
            this.gContact.Mask = "\\050-0000000";
            this.gContact.Name = "gContact";
            this.gContact.Size = new System.Drawing.Size(100, 22);
            this.gContact.TabIndex = 6;
            // 
            // gName
            // 
            this.gName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gName.Location = new System.Drawing.Point(187, 149);
            this.gName.Name = "gName";
            this.gName.Size = new System.Drawing.Size(135, 22);
            this.gName.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(24, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Guardian Contact";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(24, 152);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 16);
            this.label19.TabIndex = 29;
            this.label19.Text = "Guardian Name";
            // 
            // pStatus
            // 
            this.pStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pStatus.FormattingEnabled = true;
            this.pStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widowed",
            "Divorced",
            "Dead"});
            this.pStatus.Location = new System.Drawing.Point(597, 33);
            this.pStatus.Name = "pStatus";
            this.pStatus.Size = new System.Drawing.Size(100, 24);
            this.pStatus.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(471, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 16);
            this.label16.TabIndex = 26;
            this.label16.Text = "Marital Status";
            // 
            // pContact
            // 
            this.pContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pContact.Location = new System.Drawing.Point(187, 63);
            this.pContact.Mask = "\\050-0000000";
            this.pContact.Name = "pContact";
            this.pContact.Size = new System.Drawing.Size(100, 22);
            this.pContact.TabIndex = 2;
            // 
            // pAge
            // 
            this.pAge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pAge.FormattingEnabled = true;
            this.pAge.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "52",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "",
            ""});
            this.pAge.Location = new System.Drawing.Point(597, 63);
            this.pAge.Name = "pAge";
            this.pAge.Size = new System.Drawing.Size(60, 24);
            this.pAge.TabIndex = 8;
            // 
            // pGender
            // 
            this.pGender.AutoCompleteCustomSource.AddRange(new string[] {
            "M",
            "F",
            "O"});
            this.pGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pGender.FormattingEnabled = true;
            this.pGender.Items.AddRange(new object[] {
            "M",
            "F",
            "O"});
            this.pGender.Location = new System.Drawing.Point(187, 91);
            this.pGender.Name = "pGender";
            this.pGender.Size = new System.Drawing.Size(100, 24);
            this.pGender.TabIndex = 3;
            // 
            // pEmail
            // 
            this.pEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pEmail.Location = new System.Drawing.Point(187, 121);
            this.pEmail.Name = "pEmail";
            this.pEmail.Size = new System.Drawing.Size(135, 22);
            this.pEmail.TabIndex = 4;
            // 
            // pName
            // 
            this.pName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pName.Location = new System.Drawing.Point(187, 35);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(135, 22);
            this.pName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(24, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(526, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(24, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(24, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(24, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient Name";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbpPatientDetails);
            this.tabControl.Controls.Add(this.tbpPatientRegister);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(887, 629);
            this.tabControl.TabIndex = 36;
            // 
            // lblHomePage
            // 
            this.lblHomePage.AutoSize = true;
            this.lblHomePage.LinkColor = System.Drawing.Color.Black;
            this.lblHomePage.Location = new System.Drawing.Point(25, 566);
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Size = new System.Drawing.Size(81, 16);
            this.lblHomePage.TabIndex = 35;
            this.lblHomePage.TabStop = true;
            this.lblHomePage.Text = "Home Page";
            this.lblHomePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHomePage_LinkClicked);
            // 
            // PatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(911, 653);
            this.Controls.Add(this.tabControl);
            this.Name = "PatientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Deets";
            this.Load += new System.EventHandler(this.PatientInfo_Load);
            this.tbpPatientRegister.ResumeLayout(false);
            this.tbpPatientRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.tbpPatientDetails.ResumeLayout(false);
            this.tbpPatientDetails.PerformLayout();
            this.grbAppointments.ResumeLayout(false);
            this.grbAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pInfo.ResumeLayout(false);
            this.pInfo.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpPatientRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.TabPage tbpPatientDetails;
        private System.Windows.Forms.GroupBox grbAppointments;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker pVisitTime;
        private System.Windows.Forms.DateTimePicker pVisitDate;
        private System.Windows.Forms.DataGridView dgvVisits;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVisitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVisitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVisitTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox pInfo;
        private System.Windows.Forms.ComboBox pBT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox gContact;
        private System.Windows.Forms.TextBox gName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox pStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox pContact;
        private System.Windows.Forms.ComboBox pAge;
        private System.Windows.Forms.ComboBox pGender;
        private System.Windows.Forms.TextBox pEmail;
        private System.Windows.Forms.TextBox pName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.LinkLabel lblHomePage;
    }
}