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
using System.IO;

namespace FTP_Client
{
    public partial class Dashboard : Form
    {
        Size currentSize;
        FTP ftp;

        string ipFTPServer;
        string user;
        string pass;
        string[] fileNames;
        int itemIndex = -1;

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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isSuccess = false;
            }
            return isSuccess;
        }
        private void ActivateForm(bool flag)    // true: login, otherwise false
        {
            if (!flag)
            {
                panelTools.Visible = true;
                panelListview.Visible = true;
                panelLogin.Visible = false;
                this.MinimumSize = currentSize;
                this.ClientSize = currentSize;
                this.MaximizeBox = true;
                this.FormBorderStyle = FormBorderStyle.Sizable;

            }
            else
            {
                panelTools.Visible = false;
                panelListview.Visible = false;
                panelLogin.Visible = true;
                this.MaximizeBox = false;
                this.MinimumSize = new Size(panelLogin.Width, panelLogin.Height);
                this.Size = new Size(panelLogin.Width, panelLogin.Height);
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }
        private void InitializeListView()
        {
            listviewListFile.Columns.Add("Name", 300);
            listviewListFile.Columns.Add("Date modified", 200);
            listviewListFile.Columns.Add("Type", 100);
            listviewListFile.Columns.Add("Size", 100);
            listviewListFile.View = View.Details;
        }
        private void RefreshFTPFileInfor(string directory)
        {
            listviewListFile.Items.Clear();
            fileNames = ftp.directoryListSimple(directory);
            /* Remove the last element (null) from the string array */
            fileNames = fileNames.Take(fileNames.Count() - 1).ToArray();
            foreach (var item in fileNames)
            {
                string fileName = Path.GetFileName(item);
                string fileExtension = Path.GetExtension(item).ToUpper();
                string fileSize = ftp.getFileSize(item);
                string fileModifiedDay = ftp.getFileCreatedDateTime(item);
                ListViewItem lvItem = new ListViewItem(new string[] { fileName, fileModifiedDay, fileExtension, fileSize });
                listviewListFile.Items.Add(lvItem);
            }
        }
        #endregion

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ActivateForm(true);
            InitializeListView();
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
                RefreshFTPFileInfor("/");
            }
            else
            {
                MessageBox.Show("Login failed!");
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

        private long GetFileSize(string filename)
        {
            FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(ipFTPServer + "/" + filename);
            request.Proxy = null;
            request.Credentials = new NetworkCredential(user, pass);
            request.Method = WebRequestMethods.Ftp.GetFileSize;

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            long size = response.ContentLength;
            response.Close();
            return size;
        }

        private void buttonUploadFile_Click(object sender, EventArgs e)
        {
            /* Upload file feature */
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != string.Empty)
            {
                string pathFile = openFileDialog.FileName;
                ftp.upload(Path.GetFileName(pathFile), pathFile);
                RefreshFTPFileInfor("/");
            }
        }

        private void buttonDownloadFile_Click(object sender, EventArgs e)
        {
            /* Download file feature */
            if (itemIndex == -1)
                return;

            string fileDownload = listviewListFile.Items[itemIndex].SubItems[0].Text;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = $"|*{Path.GetExtension(fileDownload)}";
            saveFileDialog.FileName = fileDownload;
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != string.Empty)
            {
                ftp.download(fileDownload, saveFileDialog.FileName);
            }

            itemIndex = -1;
        }

        private void buttonDeleteFile_Click(object sender, EventArgs e)
        {
            /* Delete file feature */
            if (itemIndex == -1)
                return;

            string fileDelete = listviewListFile.Items[itemIndex].SubItems[0].Text;
            DialogResult dialogResult = MessageBox.Show($"Do you want to delete file {fileDelete}", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    ftp.delete(fileDelete);
                    Console.WriteLine($"Deleted file: {fileDelete}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
                RefreshFTPFileInfor("/");
            }
            itemIndex = -1;
        }

        private void listviewListFile_Click(object sender, EventArgs e)
        {
            itemIndex = listviewListFile.SelectedItems[0].Index;
        }
    }
}
