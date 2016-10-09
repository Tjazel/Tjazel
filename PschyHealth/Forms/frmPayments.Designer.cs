﻿namespace PschyHealth.Forms
{
    partial class frmPayments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.dgvPayments = new MetroFramework.Controls.MetroGrid();
            this.cmbPaymentsMethod = new MetroFramework.Controls.MetroComboBox();
            this.txtPaymentsAmount = new MetroFramework.Controls.MetroTextBox();
            this.btnAfbetaal = new MetroFramework.Controls.MetroButton();
            this.cmbPaymentsClient_Name = new MetroFramework.Controls.MetroComboBox();
            this.dgvConsultations = new MetroFramework.Controls.MetroGrid();
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            this.msmPayments = new MetroFramework.Components.MetroStyleManager(this.components);
            this.txtPaymentsConsultation = new MetroFramework.Controls.MetroTextBox();
            this.txtPaymentsDate = new MetroFramework.Controls.MetroDateTime();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbPaymentsDescription = new MetroFramework.Controls.MetroComboBox();
            this.cmbPaymentsClient_Surname = new MetroFramework.Controls.MetroComboBox();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnArchiv = new MetroFramework.Controls.MetroButton();
            this.btnPaymentsAdd = new MetroFramework.Controls.MetroButton();
            this.btnPaymentsUpdate = new MetroFramework.Controls.MetroButton();
            this.btnPaymentsDelete = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmPayments)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbBack
            // 
            this.pbBack.Image = global::PschyHealth.Properties.Resources.Circled_Chevron_Right_48px_111;
            this.pbBack.Location = new System.Drawing.Point(2, 29);
            this.pbBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(28, 22);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 45;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToResizeRows = false;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayments.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPayments.EnableHeadersVisualStyles = false;
            this.dgvPayments.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPayments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPayments.Location = new System.Drawing.Point(692, 80);
            this.dgvPayments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPayments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPayments.RowTemplate.Height = 24;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(335, 377);
            this.dgvPayments.TabIndex = 46;
            this.dgvPayments.UseStyleColors = true;
            // 
            // cmbPaymentsMethod
            // 
            this.cmbPaymentsMethod.FormattingEnabled = true;
            this.cmbPaymentsMethod.ItemHeight = 23;
            this.cmbPaymentsMethod.Items.AddRange(new object[] {
            "Member",
            "Medical Aid"});
            this.cmbPaymentsMethod.Location = new System.Drawing.Point(133, 126);
            this.cmbPaymentsMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPaymentsMethod.Name = "cmbPaymentsMethod";
            this.cmbPaymentsMethod.Size = new System.Drawing.Size(121, 29);
            this.cmbPaymentsMethod.TabIndex = 48;
            this.cmbPaymentsMethod.UseSelectable = true;
            this.cmbPaymentsMethod.UseStyleColors = true;
            this.cmbPaymentsMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPayments_Method_Of_Payments_SelectedIndexChanged);
            // 
            // txtPaymentsAmount
            // 
            // 
            // 
            // 
            this.txtPaymentsAmount.CustomButton.Image = null;
            this.txtPaymentsAmount.CustomButton.Location = new System.Drawing.Point(76, 2);
            this.txtPaymentsAmount.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPaymentsAmount.CustomButton.Name = "";
            this.txtPaymentsAmount.CustomButton.Size = new System.Drawing.Size(11, 12);
            this.txtPaymentsAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaymentsAmount.CustomButton.TabIndex = 1;
            this.txtPaymentsAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaymentsAmount.CustomButton.UseSelectable = true;
            this.txtPaymentsAmount.CustomButton.Visible = false;
            this.txtPaymentsAmount.ForeColor = System.Drawing.Color.Snow;
            this.txtPaymentsAmount.Lines = new string[0];
            this.txtPaymentsAmount.Location = new System.Drawing.Point(129, 202);
            this.txtPaymentsAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPaymentsAmount.MaxLength = 32767;
            this.txtPaymentsAmount.Name = "txtPaymentsAmount";
            this.txtPaymentsAmount.PasswordChar = '\0';
            this.txtPaymentsAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPaymentsAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaymentsAmount.SelectedText = "";
            this.txtPaymentsAmount.SelectionLength = 0;
            this.txtPaymentsAmount.SelectionStart = 0;
            this.txtPaymentsAmount.Size = new System.Drawing.Size(120, 20);
            this.txtPaymentsAmount.TabIndex = 50;
            this.txtPaymentsAmount.UseSelectable = true;
            this.txtPaymentsAmount.UseStyleColors = true;
            this.txtPaymentsAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaymentsAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAfbetaal
            // 
            this.btnAfbetaal.Location = new System.Drawing.Point(334, 487);
            this.btnAfbetaal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAfbetaal.Name = "btnAfbetaal";
            this.btnAfbetaal.Size = new System.Drawing.Size(73, 42);
            this.btnAfbetaal.TabIndex = 53;
            this.btnAfbetaal.Text = "Down paid";
            this.btnAfbetaal.UseSelectable = true;
            this.btnAfbetaal.UseStyleColors = true;
            this.btnAfbetaal.Click += new System.EventHandler(this.btnAfbetaal_Click);
            // 
            // cmbPaymentsClient_Name
            // 
            this.cmbPaymentsClient_Name.FormattingEnabled = true;
            this.cmbPaymentsClient_Name.ItemHeight = 23;
            this.cmbPaymentsClient_Name.Location = new System.Drawing.Point(133, 35);
            this.cmbPaymentsClient_Name.Name = "cmbPaymentsClient_Name";
            this.cmbPaymentsClient_Name.Size = new System.Drawing.Size(121, 29);
            this.cmbPaymentsClient_Name.TabIndex = 57;
            this.cmbPaymentsClient_Name.UseSelectable = true;
            this.cmbPaymentsClient_Name.UseStyleColors = true;
            this.cmbPaymentsClient_Name.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            // 
            // dgvConsultations
            // 
            this.dgvConsultations.AllowUserToResizeRows = false;
            this.dgvConsultations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvConsultations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvConsultations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvConsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultations.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvConsultations.EnableHeadersVisualStyles = false;
            this.dgvConsultations.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvConsultations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvConsultations.Location = new System.Drawing.Point(315, 80);
            this.dgvConsultations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvConsultations.Name = "dgvConsultations";
            this.dgvConsultations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultations.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvConsultations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvConsultations.RowTemplate.Height = 24;
            this.dgvConsultations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultations.Size = new System.Drawing.Size(354, 377);
            this.dgvConsultations.TabIndex = 58;
            this.dgvConsultations.UseStyleColors = true;
            this.dgvConsultations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultations_CellContentClick);
            this.dgvConsultations.SelectionChanged += new System.EventHandler(this.dgvConsultations_SelectionChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(120, 487);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(91, 42);
            this.btnConfirm.TabIndex = 60;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.UseStyleColors = true;
            this.btnConfirm.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // msmPayments
            // 
            this.msmPayments.Owner = this;
            // 
            // txtPaymentsConsultation
            // 
            // 
            // 
            // 
            this.txtPaymentsConsultation.CustomButton.Image = null;
            this.txtPaymentsConsultation.CustomButton.Location = new System.Drawing.Point(76, 2);
            this.txtPaymentsConsultation.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPaymentsConsultation.CustomButton.Name = "";
            this.txtPaymentsConsultation.CustomButton.Size = new System.Drawing.Size(11, 12);
            this.txtPaymentsConsultation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaymentsConsultation.CustomButton.TabIndex = 1;
            this.txtPaymentsConsultation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaymentsConsultation.CustomButton.UseSelectable = true;
            this.txtPaymentsConsultation.CustomButton.Visible = false;
            this.txtPaymentsConsultation.Enabled = false;
            this.txtPaymentsConsultation.ForeColor = System.Drawing.Color.Snow;
            this.txtPaymentsConsultation.Lines = new string[0];
            this.txtPaymentsConsultation.Location = new System.Drawing.Point(129, 167);
            this.txtPaymentsConsultation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPaymentsConsultation.MaxLength = 32767;
            this.txtPaymentsConsultation.Name = "txtPaymentsConsultation";
            this.txtPaymentsConsultation.PasswordChar = '\0';
            this.txtPaymentsConsultation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPaymentsConsultation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaymentsConsultation.SelectedText = "";
            this.txtPaymentsConsultation.SelectionLength = 0;
            this.txtPaymentsConsultation.SelectionStart = 0;
            this.txtPaymentsConsultation.Size = new System.Drawing.Size(120, 20);
            this.txtPaymentsConsultation.TabIndex = 64;
            this.txtPaymentsConsultation.UseSelectable = true;
            this.txtPaymentsConsultation.UseStyleColors = true;
            this.txtPaymentsConsultation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaymentsConsultation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPaymentsConsultation.EnabledChanged += new System.EventHandler(this.txtPaymentsConsultation_EnabledChanged);
            // 
            // txtPaymentsDate
            // 
            this.txtPaymentsDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtPaymentsDate.Location = new System.Drawing.Point(129, 239);
            this.txtPaymentsDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPaymentsDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtPaymentsDate.Name = "txtPaymentsDate";
            this.txtPaymentsDate.Size = new System.Drawing.Size(121, 30);
            this.txtPaymentsDate.TabIndex = 66;
            this.txtPaymentsDate.UseStyleColors = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.cmbPaymentsDescription);
            this.groupBox1.Controls.Add(this.cmbPaymentsClient_Name);
            this.groupBox1.Controls.Add(this.cmbPaymentsMethod);
            this.groupBox1.Controls.Add(this.txtPaymentsAmount);
            this.groupBox1.Controls.Add(this.cmbPaymentsClient_Surname);
            this.groupBox1.Controls.Add(this.txtPaymentsDate);
            this.groupBox1.Controls.Add(this.txtPaymentsConsultation);
            this.groupBox1.Location = new System.Drawing.Point(2, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 394);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment information";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(69, 239);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(43, 19);
            this.metroLabel7.TabIndex = 83;
            this.metroLabel7.Text = "Date :";
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(55, 202);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(63, 19);
            this.metroLabel6.TabIndex = 82;
            this.metroLabel6.Text = "Amount :";
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(34, 167);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(88, 19);
            this.metroLabel5.TabIndex = 81;
            this.metroLabel5.Text = "Consultation :";
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(0, 126);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(132, 19);
            this.metroLabel4.TabIndex = 80;
            this.metroLabel4.Text = "Method 0f payment :";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(52, 97);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 79;
            this.metroLabel3.Text = "Payment :";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 66);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(103, 19);
            this.metroLabel2.TabIndex = 78;
            this.metroLabel2.Text = "Client surname :";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 35);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 77;
            this.metroLabel1.Text = "Client name :";
            this.metroLabel1.UseStyleColors = true;
            // 
            // cmbPaymentsDescription
            // 
            this.cmbPaymentsDescription.FormattingEnabled = true;
            this.cmbPaymentsDescription.ItemHeight = 23;
            this.cmbPaymentsDescription.Items.AddRange(new object[] {
            "Payment",
            "Discount",
            "Writtem down"});
            this.cmbPaymentsDescription.Location = new System.Drawing.Point(133, 97);
            this.cmbPaymentsDescription.Name = "cmbPaymentsDescription";
            this.cmbPaymentsDescription.Size = new System.Drawing.Size(121, 29);
            this.cmbPaymentsDescription.TabIndex = 75;
            this.cmbPaymentsDescription.UseSelectable = true;
            this.cmbPaymentsDescription.UseStyleColors = true;
            // 
            // cmbPaymentsClient_Surname
            // 
            this.cmbPaymentsClient_Surname.FormattingEnabled = true;
            this.cmbPaymentsClient_Surname.ItemHeight = 23;
            this.cmbPaymentsClient_Surname.Location = new System.Drawing.Point(133, 66);
            this.cmbPaymentsClient_Surname.Name = "cmbPaymentsClient_Surname";
            this.cmbPaymentsClient_Surname.Size = new System.Drawing.Size(121, 29);
            this.cmbPaymentsClient_Surname.TabIndex = 67;
            this.cmbPaymentsClient_Surname.UseSelectable = true;
            this.cmbPaymentsClient_Surname.UseStyleColors = true;
            this.cmbPaymentsClient_Surname.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentsClient_Surname_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(23, 487);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 42);
            this.btnClear.TabIndex = 74;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.UseStyleColors = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnArchiv
            // 
            this.btnArchiv.Location = new System.Drawing.Point(411, 487);
            this.btnArchiv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnArchiv.Name = "btnArchiv";
            this.btnArchiv.Size = new System.Drawing.Size(91, 42);
            this.btnArchiv.TabIndex = 111;
            this.btnArchiv.Text = "Archive";
            this.btnArchiv.UseSelectable = true;
            this.btnArchiv.UseStyleColors = true;
            this.btnArchiv.Click += new System.EventHandler(this.btnArchiv_Click);
            // 
            // btnPaymentsAdd
            // 
            this.btnPaymentsAdd.Location = new System.Drawing.Point(23, 555);
            this.btnPaymentsAdd.Name = "btnPaymentsAdd";
            this.btnPaymentsAdd.Size = new System.Drawing.Size(91, 42);
            this.btnPaymentsAdd.TabIndex = 112;
            this.btnPaymentsAdd.Text = "Add";
            this.btnPaymentsAdd.UseSelectable = true;
            this.btnPaymentsAdd.UseStyleColors = true;
            this.btnPaymentsAdd.Click += new System.EventHandler(this.btnPaymentsAdd_Click);
            // 
            // btnPaymentsUpdate
            // 
            this.btnPaymentsUpdate.Location = new System.Drawing.Point(120, 555);
            this.btnPaymentsUpdate.Name = "btnPaymentsUpdate";
            this.btnPaymentsUpdate.Size = new System.Drawing.Size(91, 42);
            this.btnPaymentsUpdate.TabIndex = 113;
            this.btnPaymentsUpdate.Text = "Update";
            this.btnPaymentsUpdate.UseSelectable = true;
            this.btnPaymentsUpdate.UseStyleColors = true;
            this.btnPaymentsUpdate.Click += new System.EventHandler(this.btnPaymentsUpdate_Click);
            // 
            // btnPaymentsDelete
            // 
            this.btnPaymentsDelete.Location = new System.Drawing.Point(217, 555);
            this.btnPaymentsDelete.Name = "btnPaymentsDelete";
            this.btnPaymentsDelete.Size = new System.Drawing.Size(91, 42);
            this.btnPaymentsDelete.TabIndex = 114;
            this.btnPaymentsDelete.Text = "Delete";
            this.btnPaymentsDelete.UseSelectable = true;
            this.btnPaymentsDelete.UseStyleColors = true;
            this.btnPaymentsDelete.Click += new System.EventHandler(this.btnPaymentsDelete_Click);
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 634);
            this.Controls.Add(this.btnPaymentsDelete);
            this.Controls.Add(this.btnPaymentsUpdate);
            this.Controls.Add(this.btnPaymentsAdd);
            this.Controls.Add(this.btnArchiv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dgvConsultations);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.btnAfbetaal);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPayments";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Load += new System.EventHandler(this.frmPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmPayments)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBack;
        private MetroFramework.Controls.MetroGrid dgvPayments;
        private MetroFramework.Controls.MetroComboBox cmbPaymentsMethod;
        private MetroFramework.Controls.MetroTextBox txtPaymentsAmount;
        private MetroFramework.Controls.MetroButton btnAfbetaal;
        private MetroFramework.Controls.MetroComboBox cmbPaymentsClient_Name;
        private MetroFramework.Controls.MetroGrid dgvConsultations;
        private MetroFramework.Controls.MetroButton btnConfirm;
        private MetroFramework.Components.MetroStyleManager msmPayments;
        private MetroFramework.Controls.MetroDateTime txtPaymentsDate;
        private MetroFramework.Controls.MetroTextBox txtPaymentsConsultation;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox cmbPaymentsClient_Surname;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroComboBox cmbPaymentsDescription;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnArchiv;
        private MetroFramework.Controls.MetroButton btnPaymentsDelete;
        private MetroFramework.Controls.MetroButton btnPaymentsUpdate;
        private MetroFramework.Controls.MetroButton btnPaymentsAdd;
    }
}