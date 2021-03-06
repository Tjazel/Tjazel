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
using MetroFramework.Controls;

namespace PschyHealth
{
    public partial class frmLogin : MetroForm
    {
        string path = Environment.GetFolderPath(
          Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment";
        Methods cMethods = new Methods();
        frmForgotPassword frmForgotPassword = new frmForgotPassword();

        public frmLogin()
        {
            InitializeComponent();
            this.StyleManager = msmLogin;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           // cMethods.readTheme(msmLogin);
            cMethods.CheckFolder(path + @"\Styles");
            cMethods.CheckFolder(path + @"\Styles\TileColors");
            cMethods.CheckFile(path + @"\Styles\TileColors\tileColors");
            cMethods.CheckFolder(path + @"\Styles\Theme");
            cMethods.CheckFile(path + @"\Styles\Theme\theme");
            cMethods.CheckFolder(path + @"\Styles\style");
            cMethods.CheckFile(path + @"\Styles\style\style");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    //Uncomment om die kode te gebruik ir login..... Ctrl + K, Ctrl + U
        //    Boolean loginCorrect = false;
        //    bool admin = true;
        //    loginCorrect = cMethods.checkLogin(mtxb_Username.Text, mtxb_Password.Text, out admin);
        //    if ((loginCorrect) && (admin))
        {
            frmMainPage f1 = new frmMainPage();
            f1.Show();
            this.Hide();
        }
        //    else if (loginCorrect)
        //    {
        //        frmMainPage f1 = new frmMainPage();
        //        f1.Show();
        //        this.Hide();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Input data incorrect, please try again.");
        //    }
        //}

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmForgotPassword.Show();
           
        }


    }
}
