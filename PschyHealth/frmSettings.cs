﻿using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PschyHealth
{
    public partial class frmSettings : MetroForm
    {
        String criteria;
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
            //ucToolbar uc = new ucToolbar();
            //   uc.Dock = DockStyle.Fill;
            //this.Controls.Add(uc);
            //Load the Form At Position of Main Form
           // int WidthOfMain = Application.OpenForms["frmMainPage"].Width;
           // int HeightofMain = Application.OpenForms["frmMainPage"].Height;
           // int LocationMainX = Application.OpenForms["frmMainPage"].Location.X;
           // int locationMainy = Application.OpenForms["frmMainPage"].Location.Y;

            //Set the Location
           // this.Location = new Point(LocationMainX, locationMainy + 30);

            //Animate form
            AnimateWindow(this.Handle, 800, AW_SLIDE | AW_HOR_POSITIVE);

            //cMethods.fillDGV(dgvClients, "Clients", cmbClientCriteria);
        }
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }

        private void pbMic_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
