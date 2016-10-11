﻿using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MetroFramework.Controls;


namespace PschyHealth
{
    public partial class frmClients : MetroForm

    {
        bool validFields = true;
        String correctSearch = "";
        String button = "";
        //Constants
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;

        Methods cMethods = new Methods();

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);


        protected override void OnLoad(EventArgs e)
        {
            cMethods.readTheme(msmClients);
            cMethods.readStyle(msmClients);
           //Load the Form At Position of Main Form
            //int WidthOfMain = Application.OpenForms["frmMainPage"].Width;
           // int HeightofMain = Application.OpenForms["frmMainPage"].Height;
            ////int LocationMainX = Application.OpenForms["frmMainPage"].Location.X;
           // int locationMainy = Application.OpenForms["frmMainPage"].Location.Y;

            //Set the Location
            //this.Location = new Point(LocationMainX, locationMainy + 30);

            //Animate form
            AnimateWindow(this.Handle, 800, AW_SLIDE | AW_HOR_POSITIVE);
            this.WindowState = FormWindowState.Maximized;
            ucToolbar uc = new ucToolbar();
            this.Controls.Add(uc);


            cMethods.fillDGV(dgvClients, "Clients", cmbClientCriteria);
        }
        public frmClients()
        {
            InitializeComponent();
            this.StyleManager = msmClients;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmClients_Load(object sender, EventArgs e)
        {
           ucToolbar uc = new ucToolbar();
           uc.Dock = DockStyle.Top;
           this.Controls.Add(uc);
        }

        private void dgvClients_SelectionChanged_1(object sender, EventArgs e)
        {
            cMethods.fillTextbox(groupBox1, dgvClients, "Client", false);
        }

        private void txtClientsSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtClientsSearch.Text == "")
                cMethods.fillDGV(dgvClients, "Clients");
            else if (cMethods.validString(txtClientsSearch.Text))
            {
                filter();
                correctSearch = txtClientsSearch.Text;
            }
            else
            {
                MessageBox.Show("Only numeric and alphabetic caracters are allowed");
                txtClientsSearch.Text = correctSearch;
                txtClientsSearch.Focus();
                txtClientsSearch.SelectionStart = txtClientsSearch.Text.Length;
            }
        }

        private void cmbClientCriteria_TextChanged(object sender, EventArgs e)
        {
            txtClientsSearch.Clear();
            cmbClientSymbol.SelectedIndex = -1;
            if (cmbClientCriteria.Text != "")
            {
                txtClientsSearch.Enabled = true;

            }
            else
            {
                txtClientsSearch.Enabled = false;
                txtClientsSearch.Text = "";
            }
            cMethods.fillDGV(dgvClients, "Clients");
        }

        private void pbMic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbClientSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientSymbol.Text != "")
                txtClientsSearch.Enabled = true;
            
        }
        private void filter()
        {
            if (txtClientsSearch.Text != "")
                if (!cmbClientSymbol.Visible)
                {
                    cMethods.filterDGV(dgvClients, "Clients", " WHERE " + cmbClientCriteria.Text + " LIKE '%" + txtClientsSearch.Text + "%'");
                }
                else
                {
                    cMethods.filterDGV(dgvClients, "Clients", " WHERE " + cmbClientCriteria.Text + " " + cmbClientSymbol.Text + " " + txtClientsSearch.Text);
                }
        }

        private void cmbClientSymbol_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbClientSymbol.SelectedIndex != -1)
                txtClientsSearch.Enabled = true;
            txtClientsSearch.Clear();
        }

        private void cmbClientSymbol_VisibleChanged(object sender, EventArgs e)
        {
            cmbClientSymbol.SelectedIndex = -1;
            if (cmbClientSymbol.Visible == true)
                txtClientsSearch.Enabled = false;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {

        }

        private void btnArchive_Click_1(object sender, EventArgs e)
        {
            btnConnfirm.Show();
            btnCanccel.Show();
            cMethods.fillTextbox(groupBox1, dgvClients, "Clients", false);
            btnAddExClient.Enabled = false;
            btnaddNewclient.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            button = "archive";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCanccel.Hide();
            btnConnfirm.Hide();
            btnAddExClient.Enabled = true; 
            btnaddNewclient.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAddExClient_Click(object sender, EventArgs e)
        {
            btnConnfirm.Show();
            btnCanccel.Show();
            cMethods.fillTextbox(groupBox1, dgvClients, "Client", false, false);
            btnAddExClient.Enabled = false;
            btnaddNewclient.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            button = "add";
        }

        private void addNewclient_Click(object sender, EventArgs e)
        {
            btnConnfirm.Show();
            btnCanccel.Show();
            cMethods.fillTextbox(groupBox1, dgvClients, "Client", true, true);
            btnAddExClient.Enabled = false;
            btnaddNewclient.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            button = "add";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnConnfirm.Show();
            btnCanccel.Show();
            cMethods.fillTextbox(groupBox1, dgvClients, "Client", true);
            btnAddExClient.Enabled = false;
            btnaddNewclient.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            button = "edit";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnConnfirm.Show();
            btnCanccel.Show();
            cMethods.fillTextbox(groupBox1, dgvClients, "Client", false);
            btnAddExClient.Enabled = false;
            btnaddNewclient.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            button = "delete";
        }

        private void btnArchiv_Click(object sender, EventArgs e)
        {
            btnConnfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvClients, "Clients", false);
            btnAddExClient.Enabled = false;
            btnaddNewclient.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            button = "archive";
        }

        private void btnConnfirm_Click(object sender, EventArgs e)
        {
            validFields = true;
            foreach (Control obj in groupBox1.Controls)
            {
                if (obj is MetroDateTime)
                {
                    if (obj.Text == "")
                    {
                        validFields = false;
                    }
                }
                if (obj is MetroTextBox)
                {
                    MetroTextBox txt = new MetroTextBox();
                    txt = obj as MetroTextBox;
                    if ((txt.WaterMarkColor == Color.Red) && (txt.Text == ""))
                    {
                        validFields = false;
                    }
                }
            }
            foreach (Control obj in gbDependants.Controls)
            {
                if (obj is MetroDateTime)
                {

                    if (obj.Text == "")
                    {
                        validFields = false;
                    }
                }
                if (obj is MetroTextBox)
                {
                    MetroTextBox txt = new MetroTextBox();
                    txt = obj as MetroTextBox;
                    if ((txt.WaterMarkColor == Color.Red) && (txt.Text == ""))
                    {
                        validFields = false;
                    }
                }
            }
            if (validFields)
            {
                String field, field2;
            String value, value2;
            if (dgvClients.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvClients.SelectedRows[0].Index;

                String rowID = dgvClients[0, selectedIndex].Value.ToString();
                cMethods.getFieldsAndValues(out field, out value, groupBox1, "Client");
                cMethods.getFieldsAndValues(out field2, out value2, gbDependants, "Client");
                if (button == "add")
                    cMethods.add("Clients", field + "," + field2, value + "," + value2);
                else if (button == "edit")
                    cMethods.edit("Clients", field, value, " ID = '" + dgvClients.Rows[selectedIndex].Cells["ID"].Value.ToString() + "'");
                else if (button == "delete")
                    cMethods.delete("Clients", "ID = '" + rowID + "'");
                else if (button == "archive")
                {

                    cMethods.Archive(dgvClients, "Clients", "ID", dgvClients.Rows[selectedIndex].Cells["ID"].Value.ToString());
                }

            }
            btnAddExClient.Enabled = true;
            btnaddNewclient.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnConnfirm.Hide();
            btnCanccel.Hide();
            filter();
            }
            else
            {
                MessageBox.Show("Invalid field data, please go through your inputs.");
            }
        }

        private void btnCanccel_Click(object sender, EventArgs e)
        {
            btnCanccel.Hide();
            btnConnfirm.Hide();
            btnAddExClient.Enabled = true;
            btnaddNewclient.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void txtClientID_Leave(object sender, EventArgs e)
        {
            if (!cMethods.isNumber(txtClientID.Text))
            {
                txtClientID.Text = "";
                txtClientID.WaterMarkColor = Color.Red;
                txtClientID.WaterMark = "Incorrect Number";
                validFields = cMethods.isNumber(txtClientID.Text);
            }
            else if (txtClientID.Text == "")
            {
                txtClientID.WaterMarkColor = Color.Red;
                txtClientID.WaterMark = "Please Enter an ID Number";
            }
        }

        private void txtClientAccount_Number_Leave(object sender, EventArgs e)
        {
            if (!cMethods.isNumber(txtClientAccount_Number.Text))
            {
                txtClientAccount_Number.Text = "";
                txtClientAccount_Number.WaterMarkColor = Color.Red;
                txtClientAccount_Number.WaterMark = "Incorrect Number";
                validFields = cMethods.isNumber(txtClientAccount_Number.Text);
            }
        }

        private void txtClientFirst_Name_Leave(object sender, EventArgs e)
        {
            if (!cMethods.isNumber(txtClientFirst_Name.Text))
            {
                txtClientFirst_Name.Text = "";
                txtClientFirst_Name.WaterMarkColor = Color.Red;
                txtClientFirst_Name.WaterMark = "Incorrect Name";
                validFields = cMethods.isNumber(txtClientFirst_Name.Text);
            }
            else if (txtClientFirst_Name.Text == "")
            {
                txtClientFirst_Name.WaterMarkColor = Color.Red;
                txtClientFirst_Name.WaterMark = "Please Enter a Name";
            }
        }

        private void txtClientSurname_Leave(object sender, EventArgs e)
        {
            if (!cMethods.isNumber(txtClientSurname.Text))
            {
                txtClientSurname.Text = "";
                txtClientSurname.WaterMarkColor = Color.Red;
                txtClientSurname.WaterMark = "Incorrect Surname";
                validFields = cMethods.isNumber(txtClientSurname.Text);
            }
            else if (txtClientSurname.Text == "")
            {
                txtClientSurname.WaterMarkColor = Color.Red;
                txtClientSurname.WaterMark = "Please Enter a Surname";
            }
        }

        private void txtClientCity_Code_Leave(object sender, EventArgs e)
        {

        }

        private void txtClientHome_Telephone_Number_Leave(object sender, EventArgs e)
        {

        }

        private void txtClientMobile_Cellphone_Number_Leave(object sender, EventArgs e)
        {

        }

        private void txtClientOccupation_Leave(object sender, EventArgs e)
        {

        }

        private void txtClientWork_Address_Leave(object sender, EventArgs e)
        {

        }

        private void txtClientMaritial_Status_Leave(object sender, EventArgs e)
        {

        }

        private void txtClientEmail_Leave(object sender, EventArgs e)
        {

        }

        private void Completed_payment_Leave(object sender, EventArgs e)
        {

        }

        private void txtClientAddress_Leave(object sender, EventArgs e)
        {

        }

        private void txtClientCity_Leave(object sender, EventArgs e)
        {

        }

        private void txtClientDependant_Full_Name_Leave(object sender, EventArgs e)
        {

        }

        private void txtClientDependantSurname_Leave(object sender, EventArgs e)
        {

        }

        private void txtClientDependant_Code_Leave(object sender, EventArgs e)
        {

        }

        private void txtClientReferal_Practice_Leave(object sender, EventArgs e)
        {

        }
    }
}
