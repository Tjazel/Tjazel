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
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
using System.Data.SqlTypes;



namespace PschyHealth
{
    public partial class frmEmail : MetroForm
    {
       
        Methods cMethods = new Methods();
       // private readonly IWin32Window owner;

        public frmEmail()
        {
            InitializeComponent();
            this.StyleManager = msmEmail;
        }
        protected override void OnLoad(EventArgs e)
        {
            cMethods.readTheme(msmEmail);

        }
        


        private void frmEmail_Load(object sender, EventArgs e)
        {
           


           
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
           
          
        }

        private void frmEmail_Shown(object sender, EventArgs e)
        {

          
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source = jarvisdevelopment.database.windows.net; Initial Catalog = JarvisDev; User ID = ProjectJarvis; Password =JarvisProject2016;");
            try
            {
                MessageBox.Show("may take a while");
                cn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
            cmb1.Visible = true;
            
            SqlCommand cm = new SqlCommand("SELECT First_Name FROM Clients", cn);
            //SqlCommand dm = new SqlCommand("SELECT Surname FROM Clients", cn);
            try
            {
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    cmb1.Items.Add(dr["First_Name"]);
                    //String sEmail = dr.GetString(27);
                }
                dr.Close();
                dr.Dispose();
                cn.Close();
            }
             catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

            //    SqlDataAdapter daCm = new SqlDataAdapter(cm);
            //    DataTable dtCm = new DataTable();
            //    daCm.Fill(dtCm);
            //    //dgv.Rows[i].Cells["Surname"].
            //    SqlDataAdapter daDm = new SqlDataAdapter(dm);
            //    DataTable dtDm = new DataTable();
            //    daDm.Fill(dtDm);
            //    for(int i=0;i<dtCm.Rows.Count;i++)
            //    {
            //        if (dtCm.Rows[i].Cells == cmb1.SelectedItem)
            //        {
            //            txtTo.Text= Convert.ToString(dtDm.Rows[i]);

            //        }
            //    }
            //    cn.Close();



            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    cn.Close();
            //}
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source = jarvisdevelopment.database.windows.net; Initial Catalog = JarvisDev; User ID = ProjectJarvis; Password =JarvisProject2016;");
            String query = "SELECT*FROM Clients where First_Name ='" + cmb1.Text + "';";
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader rd;

            try
            {
                cn.Open();
                rd = cmd.ExecuteReader();

                while(rd.Read())
                {
                    string sEmail = rd.GetString(26);
                    txtTo.Text = sEmail;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);       
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 1000000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("jaco.vanzyl@creative-sound.net", "P@ssw0rd");
                MailMessage msg = new MailMessage();
                if(!String.IsNullOrEmpty(txtTo.Text))
                {
                    msg.To.Add(txtTo.Text);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(Owner, "Empty field!", "Please enter an e-mail adress in the given textbox", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                msg.To.Add(txtTo.Text);
                if (!String.IsNullOrEmpty(txtCC.Text))
                    msg.To.Add(new MailAddress(txtCC.Text));

                msg.From = new MailAddress("jaco.vanzyl@creative-sound.net");
                msg.Subject = txtSubject.Text;
                msg.Body = txtMessage.Text;
                client.Send(msg);
                MessageBox.Show("Succes");

               



            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter an email adress in the provided field!");
            }

            txtMessage.Clear();
            txtSubject.Clear();
            txtTo.Clear();
            txtCC.Clear();

        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}