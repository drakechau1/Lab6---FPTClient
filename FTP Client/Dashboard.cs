using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FTP_Client;

namespace FTP_Client
{
    public partial class Dashboard : Form
    {
        Size currentSize;
        FTP ftp;

        string ipFTPServer;
        string user;
        string pass;

        public Dashboard()
        {
            InitializeComponent();
            currentSize = this.ClientSize;

            txtIPFTPServer.Text = @"ftp://127.0.0.1/";
            txtUsername.Text = "user1";
            txtPassword.Text = "user1";
        }

        #region Methods
        private bool Connect2FTPServer(string host, string user, string pass)
        {
            bool isSuccess = true;
            try
            {
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(host);
                ftpRequest.Credentials = new NetworkCredential(user, pass);
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                //Console.WriteLine("status code: " + ftpResponse.StatusCode);
                //Console.WriteLine("Description: " + ftpResponse.StatusDescription);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isSuccess = false;
            }
            return isSuccess;
        }
        #endregion

        private void ActivateForm(bool flag)    // true: login, otherwise false
        {
            if (!flag)
            {
                panelTools.Visible = true;
                panelListview.Visible = true;
                panelLogin.Visible = false;
                this.MinimumSize = currentSize;
                this.ClientSize = currentSize;
            }
            else
            {
                panelTools.Visible = false;
                panelListview.Visible = false;
                panelLogin.Visible = true;
                this.MinimumSize = new Size(panelLogin.Width, panelLogin.Height);
                this.Size = new Size(panelLogin.Width, panelLogin.Height);
            }
        }

        private void AvtivateListView()
        {
            listviewListFile.Columns.Add("Name", 300);
            listviewListFile.Columns.Add("Date modified", 200);
            listviewListFile.Columns.Add("Type", 100);
            listviewListFile.Columns.Add("Size", 100);
            listviewListFile.View = View.Details;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ActivateForm(true);
            AvtivateListView();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ipFTPServer = txtIPFTPServer.Text;
            user = txtUsername.Text;
            pass = txtPassword.Text;

            ftp = new FTP(ipFTPServer, user, pass);

            if (Connect2FTPServer(ipFTPServer, user, pass))
            {
                ActivateForm(false);
            }
            else
            {
                MessageBox.Show("Login failed!" );
            }
            
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to logout?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;
            else
                ActivateForm(true);
        }

        private void buttonUploadFile_Click(object sender, EventArgs e)
        {
            /* Upload file feature */
        }

        private void buttonDeleteFile_Click(object sender, EventArgs e)
        {
            /* Delete file feature */
        }

        private void listviewListFile_DoubleClick(object sender, EventArgs e)
        {
            /* Download file feature */
        }
    }
}
