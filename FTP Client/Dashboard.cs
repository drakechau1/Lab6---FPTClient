using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP_Client
{
    public partial class Dashboard : Form
    {
        //private const int MIN_HEIGHT_FORM = 1029;
        //private const int MIN_WIDTH_FROM = 1231;
        Size currentSize;

        public Dashboard()
        {
            InitializeComponent();
            currentSize = this.ClientSize;
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
            ActivateForm(false);
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
