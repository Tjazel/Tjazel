﻿namespace PschyHealth
{
    partial class frmAddressBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbAccCriteria = new MetroFramework.Controls.MetroComboBox();
            this.txtAccSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.mtxb_Remarks = new MetroFramework.Controls.MetroTextBox();
            this.mtxb_Zip = new MetroFramework.Controls.MetroTextBox();
            this.mtxb_Address3 = new MetroFramework.Controls.MetroTextBox();
            this.mtxb_Address2 = new MetroFramework.Controls.MetroTextBox();
            this.mtxb_Address1 = new MetroFramework.Controls.MetroTextBox();
            this.mtxb_Internet = new MetroFramework.Controls.MetroTextBox();
            this.mtxb_Email = new MetroFramework.Controls.MetroTextBox();
            this.mtxb_Cell = new MetroFramework.Controls.MetroTextBox();
            this.mtxb_Fax = new MetroFramework.Controls.MetroTextBox();
            this.mtxb_Tel = new MetroFramework.Controls.MetroTextBox();
            this.mtxb_Contact = new MetroFramework.Controls.MetroTextBox();
            this.mtxb_Name = new MetroFramework.Controls.MetroTextBox();
            this.mtxb_Number = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblBack = new MetroFramework.Controls.MetroLabel();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.msmAdBook = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnArchive = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmAdBook)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbAccCriteria);
            this.groupBox3.Controls.Add(this.txtAccSearch);
            this.groupBox3.Controls.Add(this.metroLabel17);
            this.groupBox3.Location = new System.Drawing.Point(491, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 71);
            this.groupBox3.TabIndex = 95;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Address Book";
            // 
            // cmbAccCriteria
            // 
            this.cmbAccCriteria.FormattingEnabled = true;
            this.cmbAccCriteria.ItemHeight = 23;
            this.cmbAccCriteria.Items.AddRange(new object[] {
            "Name",
            "Email",
            "Tel"});
            this.cmbAccCriteria.Location = new System.Drawing.Point(78, 23);
            this.cmbAccCriteria.Name = "cmbAccCriteria";
            this.cmbAccCriteria.Size = new System.Drawing.Size(141, 29);
            this.cmbAccCriteria.TabIndex = 3;
            this.cmbAccCriteria.UseSelectable = true;
            this.cmbAccCriteria.UseStyleColors = true;
            // 
            // txtAccSearch
            // 
            // 
            // 
            // 
            this.txtAccSearch.CustomButton.Image = null;
            this.txtAccSearch.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.txtAccSearch.CustomButton.Name = "";
            this.txtAccSearch.CustomButton.Size = new System.Drawing.Size(20, 22);
            this.txtAccSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccSearch.CustomButton.TabIndex = 1;
            this.txtAccSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccSearch.CustomButton.UseSelectable = true;
            this.txtAccSearch.CustomButton.Visible = false;
            this.txtAccSearch.Lines = new string[0];
            this.txtAccSearch.Location = new System.Drawing.Point(254, 23);
            this.txtAccSearch.MaxLength = 32767;
            this.txtAccSearch.Name = "txtAccSearch";
            this.txtAccSearch.PasswordChar = '\0';
            this.txtAccSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccSearch.SelectedText = "";
            this.txtAccSearch.SelectionLength = 0;
            this.txtAccSearch.SelectionStart = 0;
            this.txtAccSearch.Size = new System.Drawing.Size(141, 29);
            this.txtAccSearch.TabIndex = 2;
            this.txtAccSearch.UseSelectable = true;
            this.txtAccSearch.UseStyleColors = true;
            this.txtAccSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(17, 27);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(55, 19);
            this.metroLabel17.TabIndex = 0;
            this.metroLabel17.Text = "Criteria:";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.Location = new System.Drawing.Point(491, 180);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(480, 397);
            this.metroGrid1.TabIndex = 94;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mtxb_Remarks
            // 
            // 
            // 
            // 
            this.mtxb_Remarks.CustomButton.Image = null;
            this.mtxb_Remarks.CustomButton.Location = new System.Drawing.Point(165, 2);
            this.mtxb_Remarks.CustomButton.Name = "";
            this.mtxb_Remarks.CustomButton.Size = new System.Drawing.Size(85, 92);
            this.mtxb_Remarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxb_Remarks.CustomButton.TabIndex = 1;
            this.mtxb_Remarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxb_Remarks.CustomButton.UseSelectable = true;
            this.mtxb_Remarks.CustomButton.Visible = false;
            this.mtxb_Remarks.Lines = new string[0];
            this.mtxb_Remarks.Location = new System.Drawing.Point(93, 459);
            this.mtxb_Remarks.MaxLength = 32767;
            this.mtxb_Remarks.Multiline = true;
            this.mtxb_Remarks.Name = "mtxb_Remarks";
            this.mtxb_Remarks.PasswordChar = '\0';
            this.mtxb_Remarks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxb_Remarks.SelectedText = "";
            this.mtxb_Remarks.SelectionLength = 0;
            this.mtxb_Remarks.SelectionStart = 0;
            this.mtxb_Remarks.Size = new System.Drawing.Size(336, 118);
            this.mtxb_Remarks.TabIndex = 90;
            this.mtxb_Remarks.UseSelectable = true;
            this.mtxb_Remarks.UseStyleColors = true;
            this.mtxb_Remarks.WaterMark = "Enter Additional Remarks";
            this.mtxb_Remarks.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxb_Remarks.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxb_Zip
            // 
            // 
            // 
            // 
            this.mtxb_Zip.CustomButton.Image = null;
            this.mtxb_Zip.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.mtxb_Zip.CustomButton.Name = "";
            this.mtxb_Zip.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.mtxb_Zip.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxb_Zip.CustomButton.TabIndex = 1;
            this.mtxb_Zip.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxb_Zip.CustomButton.UseSelectable = true;
            this.mtxb_Zip.CustomButton.Visible = false;
            this.mtxb_Zip.Lines = new string[0];
            this.mtxb_Zip.Location = new System.Drawing.Point(93, 428);
            this.mtxb_Zip.MaxLength = 32767;
            this.mtxb_Zip.Name = "mtxb_Zip";
            this.mtxb_Zip.PasswordChar = '\0';
            this.mtxb_Zip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxb_Zip.SelectedText = "";
            this.mtxb_Zip.SelectionLength = 0;
            this.mtxb_Zip.SelectionStart = 0;
            this.mtxb_Zip.Size = new System.Drawing.Size(336, 23);
            this.mtxb_Zip.TabIndex = 89;
            this.mtxb_Zip.UseSelectable = true;
            this.mtxb_Zip.UseStyleColors = true;
            this.mtxb_Zip.WaterMark = "Enter Zip Code";
            this.mtxb_Zip.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxb_Zip.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxb_Address3
            // 
            // 
            // 
            // 
            this.mtxb_Address3.CustomButton.Image = null;
            this.mtxb_Address3.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.mtxb_Address3.CustomButton.Name = "";
            this.mtxb_Address3.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.mtxb_Address3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxb_Address3.CustomButton.TabIndex = 1;
            this.mtxb_Address3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxb_Address3.CustomButton.UseSelectable = true;
            this.mtxb_Address3.CustomButton.Visible = false;
            this.mtxb_Address3.Lines = new string[0];
            this.mtxb_Address3.Location = new System.Drawing.Point(93, 397);
            this.mtxb_Address3.MaxLength = 32767;
            this.mtxb_Address3.Name = "mtxb_Address3";
            this.mtxb_Address3.PasswordChar = '\0';
            this.mtxb_Address3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxb_Address3.SelectedText = "";
            this.mtxb_Address3.SelectionLength = 0;
            this.mtxb_Address3.SelectionStart = 0;
            this.mtxb_Address3.Size = new System.Drawing.Size(336, 23);
            this.mtxb_Address3.TabIndex = 88;
            this.mtxb_Address3.UseSelectable = true;
            this.mtxb_Address3.UseStyleColors = true;
            this.mtxb_Address3.WaterMark = "Enter Address 3";
            this.mtxb_Address3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxb_Address3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxb_Address2
            // 
            // 
            // 
            // 
            this.mtxb_Address2.CustomButton.Image = null;
            this.mtxb_Address2.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.mtxb_Address2.CustomButton.Name = "";
            this.mtxb_Address2.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.mtxb_Address2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxb_Address2.CustomButton.TabIndex = 1;
            this.mtxb_Address2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxb_Address2.CustomButton.UseSelectable = true;
            this.mtxb_Address2.CustomButton.Visible = false;
            this.mtxb_Address2.Lines = new string[0];
            this.mtxb_Address2.Location = new System.Drawing.Point(93, 366);
            this.mtxb_Address2.MaxLength = 32767;
            this.mtxb_Address2.Name = "mtxb_Address2";
            this.mtxb_Address2.PasswordChar = '\0';
            this.mtxb_Address2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxb_Address2.SelectedText = "";
            this.mtxb_Address2.SelectionLength = 0;
            this.mtxb_Address2.SelectionStart = 0;
            this.mtxb_Address2.Size = new System.Drawing.Size(336, 23);
            this.mtxb_Address2.TabIndex = 87;
            this.mtxb_Address2.UseSelectable = true;
            this.mtxb_Address2.UseStyleColors = true;
            this.mtxb_Address2.WaterMark = "Enter Address 2";
            this.mtxb_Address2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxb_Address2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxb_Address1
            // 
            // 
            // 
            // 
            this.mtxb_Address1.CustomButton.Image = null;
            this.mtxb_Address1.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.mtxb_Address1.CustomButton.Name = "";
            this.mtxb_Address1.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.mtxb_Address1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxb_Address1.CustomButton.TabIndex = 1;
            this.mtxb_Address1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxb_Address1.CustomButton.UseSelectable = true;
            this.mtxb_Address1.CustomButton.Visible = false;
            this.mtxb_Address1.Lines = new string[0];
            this.mtxb_Address1.Location = new System.Drawing.Point(93, 335);
            this.mtxb_Address1.MaxLength = 32767;
            this.mtxb_Address1.Name = "mtxb_Address1";
            this.mtxb_Address1.PasswordChar = '\0';
            this.mtxb_Address1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxb_Address1.SelectedText = "";
            this.mtxb_Address1.SelectionLength = 0;
            this.mtxb_Address1.SelectionStart = 0;
            this.mtxb_Address1.Size = new System.Drawing.Size(336, 23);
            this.mtxb_Address1.TabIndex = 86;
            this.mtxb_Address1.UseSelectable = true;
            this.mtxb_Address1.UseStyleColors = true;
            this.mtxb_Address1.WaterMark = "Enter Address 1";
            this.mtxb_Address1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxb_Address1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxb_Internet
            // 
            // 
            // 
            // 
            this.mtxb_Internet.CustomButton.Image = null;
            this.mtxb_Internet.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.mtxb_Internet.CustomButton.Name = "";
            this.mtxb_Internet.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.mtxb_Internet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxb_Internet.CustomButton.TabIndex = 1;
            this.mtxb_Internet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxb_Internet.CustomButton.UseSelectable = true;
            this.mtxb_Internet.CustomButton.Visible = false;
            this.mtxb_Internet.Lines = new string[0];
            this.mtxb_Internet.Location = new System.Drawing.Point(93, 304);
            this.mtxb_Internet.MaxLength = 32767;
            this.mtxb_Internet.Name = "mtxb_Internet";
            this.mtxb_Internet.PasswordChar = '\0';
            this.mtxb_Internet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxb_Internet.SelectedText = "";
            this.mtxb_Internet.SelectionLength = 0;
            this.mtxb_Internet.SelectionStart = 0;
            this.mtxb_Internet.Size = new System.Drawing.Size(336, 23);
            this.mtxb_Internet.TabIndex = 85;
            this.mtxb_Internet.UseSelectable = true;
            this.mtxb_Internet.UseStyleColors = true;
            this.mtxb_Internet.WaterMark = "Enter Website URL";
            this.mtxb_Internet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxb_Internet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxb_Email
            // 
            // 
            // 
            // 
            this.mtxb_Email.CustomButton.Image = null;
            this.mtxb_Email.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.mtxb_Email.CustomButton.Name = "";
            this.mtxb_Email.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.mtxb_Email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxb_Email.CustomButton.TabIndex = 1;
            this.mtxb_Email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxb_Email.CustomButton.UseSelectable = true;
            this.mtxb_Email.CustomButton.Visible = false;
            this.mtxb_Email.Lines = new string[0];
            this.mtxb_Email.Location = new System.Drawing.Point(93, 273);
            this.mtxb_Email.MaxLength = 32767;
            this.mtxb_Email.Name = "mtxb_Email";
            this.mtxb_Email.PasswordChar = '\0';
            this.mtxb_Email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxb_Email.SelectedText = "";
            this.mtxb_Email.SelectionLength = 0;
            this.mtxb_Email.SelectionStart = 0;
            this.mtxb_Email.Size = new System.Drawing.Size(336, 23);
            this.mtxb_Email.TabIndex = 84;
            this.mtxb_Email.UseSelectable = true;
            this.mtxb_Email.UseStyleColors = true;
            this.mtxb_Email.WaterMark = "Enter Email Address";
            this.mtxb_Email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxb_Email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxb_Cell
            // 
            // 
            // 
            // 
            this.mtxb_Cell.CustomButton.Image = null;
            this.mtxb_Cell.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.mtxb_Cell.CustomButton.Name = "";
            this.mtxb_Cell.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.mtxb_Cell.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxb_Cell.CustomButton.TabIndex = 1;
            this.mtxb_Cell.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxb_Cell.CustomButton.UseSelectable = true;
            this.mtxb_Cell.CustomButton.Visible = false;
            this.mtxb_Cell.Lines = new string[0];
            this.mtxb_Cell.Location = new System.Drawing.Point(93, 242);
            this.mtxb_Cell.MaxLength = 32767;
            this.mtxb_Cell.Name = "mtxb_Cell";
            this.mtxb_Cell.PasswordChar = '\0';
            this.mtxb_Cell.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxb_Cell.SelectedText = "";
            this.mtxb_Cell.SelectionLength = 0;
            this.mtxb_Cell.SelectionStart = 0;
            this.mtxb_Cell.Size = new System.Drawing.Size(336, 23);
            this.mtxb_Cell.TabIndex = 83;
            this.mtxb_Cell.UseSelectable = true;
            this.mtxb_Cell.UseStyleColors = true;
            this.mtxb_Cell.WaterMark = "Enter Cell Number";
            this.mtxb_Cell.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxb_Cell.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxb_Fax
            // 
            // 
            // 
            // 
            this.mtxb_Fax.CustomButton.Image = null;
            this.mtxb_Fax.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.mtxb_Fax.CustomButton.Name = "";
            this.mtxb_Fax.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.mtxb_Fax.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxb_Fax.CustomButton.TabIndex = 1;
            this.mtxb_Fax.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxb_Fax.CustomButton.UseSelectable = true;
            this.mtxb_Fax.CustomButton.Visible = false;
            this.mtxb_Fax.Lines = new string[0];
            this.mtxb_Fax.Location = new System.Drawing.Point(93, 211);
            this.mtxb_Fax.MaxLength = 32767;
            this.mtxb_Fax.Name = "mtxb_Fax";
            this.mtxb_Fax.PasswordChar = '\0';
            this.mtxb_Fax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxb_Fax.SelectedText = "";
            this.mtxb_Fax.SelectionLength = 0;
            this.mtxb_Fax.SelectionStart = 0;
            this.mtxb_Fax.Size = new System.Drawing.Size(336, 23);
            this.mtxb_Fax.TabIndex = 82;
            this.mtxb_Fax.UseSelectable = true;
            this.mtxb_Fax.UseStyleColors = true;
            this.mtxb_Fax.WaterMark = "Enter Fax Number";
            this.mtxb_Fax.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxb_Fax.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxb_Tel
            // 
            // 
            // 
            // 
            this.mtxb_Tel.CustomButton.Image = null;
            this.mtxb_Tel.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.mtxb_Tel.CustomButton.Name = "";
            this.mtxb_Tel.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.mtxb_Tel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxb_Tel.CustomButton.TabIndex = 1;
            this.mtxb_Tel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxb_Tel.CustomButton.UseSelectable = true;
            this.mtxb_Tel.CustomButton.Visible = false;
            this.mtxb_Tel.Lines = new string[0];
            this.mtxb_Tel.Location = new System.Drawing.Point(93, 180);
            this.mtxb_Tel.MaxLength = 32767;
            this.mtxb_Tel.Name = "mtxb_Tel";
            this.mtxb_Tel.PasswordChar = '\0';
            this.mtxb_Tel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxb_Tel.SelectedText = "";
            this.mtxb_Tel.SelectionLength = 0;
            this.mtxb_Tel.SelectionStart = 0;
            this.mtxb_Tel.Size = new System.Drawing.Size(336, 23);
            this.mtxb_Tel.TabIndex = 81;
            this.mtxb_Tel.UseSelectable = true;
            this.mtxb_Tel.UseStyleColors = true;
            this.mtxb_Tel.WaterMark = "Enter Tel Number";
            this.mtxb_Tel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxb_Tel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxb_Contact
            // 
            // 
            // 
            // 
            this.mtxb_Contact.CustomButton.Image = null;
            this.mtxb_Contact.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.mtxb_Contact.CustomButton.Name = "";
            this.mtxb_Contact.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.mtxb_Contact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxb_Contact.CustomButton.TabIndex = 1;
            this.mtxb_Contact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxb_Contact.CustomButton.UseSelectable = true;
            this.mtxb_Contact.CustomButton.Visible = false;
            this.mtxb_Contact.Lines = new string[0];
            this.mtxb_Contact.Location = new System.Drawing.Point(93, 149);
            this.mtxb_Contact.MaxLength = 32767;
            this.mtxb_Contact.Name = "mtxb_Contact";
            this.mtxb_Contact.PasswordChar = '\0';
            this.mtxb_Contact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxb_Contact.SelectedText = "";
            this.mtxb_Contact.SelectionLength = 0;
            this.mtxb_Contact.SelectionStart = 0;
            this.mtxb_Contact.Size = new System.Drawing.Size(336, 23);
            this.mtxb_Contact.TabIndex = 80;
            this.mtxb_Contact.UseSelectable = true;
            this.mtxb_Contact.UseStyleColors = true;
            this.mtxb_Contact.WaterMark = "Enter Contact";
            this.mtxb_Contact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxb_Contact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxb_Name
            // 
            // 
            // 
            // 
            this.mtxb_Name.CustomButton.Image = null;
            this.mtxb_Name.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.mtxb_Name.CustomButton.Name = "";
            this.mtxb_Name.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.mtxb_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxb_Name.CustomButton.TabIndex = 1;
            this.mtxb_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxb_Name.CustomButton.UseSelectable = true;
            this.mtxb_Name.CustomButton.Visible = false;
            this.mtxb_Name.Lines = new string[0];
            this.mtxb_Name.Location = new System.Drawing.Point(93, 118);
            this.mtxb_Name.MaxLength = 32767;
            this.mtxb_Name.Name = "mtxb_Name";
            this.mtxb_Name.PasswordChar = '\0';
            this.mtxb_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxb_Name.SelectedText = "";
            this.mtxb_Name.SelectionLength = 0;
            this.mtxb_Name.SelectionStart = 0;
            this.mtxb_Name.Size = new System.Drawing.Size(336, 23);
            this.mtxb_Name.TabIndex = 79;
            this.mtxb_Name.UseSelectable = true;
            this.mtxb_Name.UseStyleColors = true;
            this.mtxb_Name.WaterMark = "Enter Name";
            this.mtxb_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxb_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxb_Number
            // 
            // 
            // 
            // 
            this.mtxb_Number.CustomButton.Image = null;
            this.mtxb_Number.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.mtxb_Number.CustomButton.Name = "";
            this.mtxb_Number.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.mtxb_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxb_Number.CustomButton.TabIndex = 1;
            this.mtxb_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxb_Number.CustomButton.UseSelectable = true;
            this.mtxb_Number.CustomButton.Visible = false;
            this.mtxb_Number.Lines = new string[0];
            this.mtxb_Number.Location = new System.Drawing.Point(93, 86);
            this.mtxb_Number.MaxLength = 32767;
            this.mtxb_Number.Name = "mtxb_Number";
            this.mtxb_Number.PasswordChar = '\0';
            this.mtxb_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxb_Number.SelectedText = "";
            this.mtxb_Number.SelectionLength = 0;
            this.mtxb_Number.SelectionStart = 0;
            this.mtxb_Number.Size = new System.Drawing.Size(120, 23);
            this.mtxb_Number.TabIndex = 78;
            this.mtxb_Number.UseSelectable = true;
            this.mtxb_Number.UseStyleColors = true;
            this.mtxb_Number.WaterMark = "Number";
            this.mtxb_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxb_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(25, 463);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(62, 19);
            this.metroLabel13.TabIndex = 77;
            this.metroLabel13.Text = "Remarks:";
            this.metroLabel13.UseStyleColors = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(56, 432);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(31, 19);
            this.metroLabel12.TabIndex = 76;
            this.metroLabel12.Text = "Zip:";
            this.metroLabel12.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(17, 401);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(70, 19);
            this.metroLabel11.TabIndex = 75;
            this.metroLabel11.Text = "Address 3:";
            this.metroLabel11.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(17, 370);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(70, 19);
            this.metroLabel10.TabIndex = 74;
            this.metroLabel10.Text = "Address 2:";
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(19, 339);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(68, 19);
            this.metroLabel9.TabIndex = 73;
            this.metroLabel9.Text = "Address 1:";
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(31, 308);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(56, 19);
            this.metroLabel8.TabIndex = 72;
            this.metroLabel8.Text = "Internet:";
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(43, 277);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(44, 19);
            this.metroLabel7.TabIndex = 71;
            this.metroLabel7.Text = "Email:";
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(53, 246);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(34, 19);
            this.metroLabel6.TabIndex = 70;
            this.metroLabel6.Text = "Cell:";
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(56, 215);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(31, 19);
            this.metroLabel5.TabIndex = 69;
            this.metroLabel5.Text = "Fax:";
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(60, 184);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(27, 19);
            this.metroLabel4.TabIndex = 68;
            this.metroLabel4.Text = "Tel:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(30, 153);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 19);
            this.metroLabel3.TabIndex = 67;
            this.metroLabel3.Text = "Contact:";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(39, 122);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 66;
            this.metroLabel2.Text = "Name:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 65;
            this.metroLabel1.Text = "Number:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBack.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBack.Location = new System.Drawing.Point(57, 50);
            this.lblBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(48, 25);
            this.lblBack.TabIndex = 98;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // pbBack
            // 
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = global::PschyHealth.Properties.Resources.Circled_Chevron_Right_48px_111;
            this.pbBack.Location = new System.Drawing.Point(25, 48);
            this.pbBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(28, 22);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 97;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(478, 48);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(119, 25);
            this.metroLabel14.TabIndex = 99;
            this.metroLabel14.Text = "Addressbook";
            // 
            // msmAdBook
            // 
            this.msmAdBook.Owner = this;
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(781, 593);
            this.btnArchive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(91, 42);
            this.btnArchive.TabIndex = 119;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseSelectable = true;
            this.btnArchive.UseStyleColors = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(686, 593);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 42);
            this.btnDelete.TabIndex = 118;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.UseStyleColors = true;
            this.btnDelete.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(590, 593);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 42);
            this.btnUpdate.TabIndex = 117;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.UseStyleColors = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(491, 593);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 42);
            this.btnAdd.TabIndex = 116;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.UseStyleColors = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(194, 593);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 42);
            this.btnCancel.TabIndex = 121;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(93, 593);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(91, 42);
            this.btnConfirm.TabIndex = 120;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.UseStyleColors = true;
            // 
            // frmAddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 653);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.mtxb_Remarks);
            this.Controls.Add(this.mtxb_Zip);
            this.Controls.Add(this.mtxb_Address3);
            this.Controls.Add(this.mtxb_Address2);
            this.Controls.Add(this.mtxb_Address1);
            this.Controls.Add(this.mtxb_Internet);
            this.Controls.Add(this.mtxb_Email);
            this.Controls.Add(this.mtxb_Cell);
            this.Controls.Add(this.mtxb_Fax);
            this.Controls.Add(this.mtxb_Tel);
            this.Controls.Add(this.mtxb_Contact);
            this.Controls.Add(this.mtxb_Name);
            this.Controls.Add(this.mtxb_Number);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmAddressBook";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.frmAddressBook_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmAdBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroComboBox cmbAccCriteria;
        private MetroFramework.Controls.MetroTextBox txtAccSearch;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox mtxb_Remarks;
        private MetroFramework.Controls.MetroTextBox mtxb_Zip;
        private MetroFramework.Controls.MetroTextBox mtxb_Address3;
        private MetroFramework.Controls.MetroTextBox mtxb_Address2;
        private MetroFramework.Controls.MetroTextBox mtxb_Address1;
        private MetroFramework.Controls.MetroTextBox mtxb_Internet;
        private MetroFramework.Controls.MetroTextBox mtxb_Email;
        private MetroFramework.Controls.MetroTextBox mtxb_Cell;
        private MetroFramework.Controls.MetroTextBox mtxb_Fax;
        private MetroFramework.Controls.MetroTextBox mtxb_Tel;
        private MetroFramework.Controls.MetroTextBox mtxb_Contact;
        private MetroFramework.Controls.MetroTextBox mtxb_Name;
        private MetroFramework.Controls.MetroTextBox mtxb_Number;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblBack;
        private System.Windows.Forms.PictureBox pbBack;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Components.MetroStyleManager msmAdBook;
        private MetroFramework.Controls.MetroButton btnArchive;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnConfirm;
    }
}