
namespace FTP_Client
{
    partial class Dashboard
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.txtIPFTPServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTools = new System.Windows.Forms.Panel();
            this.buttonDownloadFile = new System.Windows.Forms.Button();
            this.buttonDeleteFile = new System.Windows.Forms.Button();
            this.buttonUploadFile = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelListview = new System.Windows.Forms.Panel();
            this.listviewListFile = new System.Windows.Forms.ListView();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.panelTools.SuspendLayout();
            this.panelListview.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.txtIPFTPServer);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.txtUsername);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(1213, 463);
            this.panelLogin.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Location = new System.Drawing.Point(220, 290);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(198, 44);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // txtIPFTPServer
            // 
            this.txtIPFTPServer.Location = new System.Drawing.Point(220, 138);
            this.txtIPFTPServer.Name = "txtIPFTPServer";
            this.txtIPFTPServer.Size = new System.Drawing.Size(766, 30);
            this.txtIPFTPServer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP FTP Server";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(665, 219);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(321, 30);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(220, 219);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(394, 30);
            this.txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(660, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTools.Controls.Add(this.labelSize);
            this.panelTools.Controls.Add(this.labelTotal);
            this.panelTools.Controls.Add(this.buttonDownloadFile);
            this.panelTools.Controls.Add(this.buttonDeleteFile);
            this.panelTools.Controls.Add(this.buttonUploadFile);
            this.panelTools.Controls.Add(this.buttonLogout);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTools.Location = new System.Drawing.Point(0, 463);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(1213, 100);
            this.panelTools.TabIndex = 1;
            // 
            // buttonDownloadFile
            // 
            this.buttonDownloadFile.Location = new System.Drawing.Point(198, 28);
            this.buttonDownloadFile.Name = "buttonDownloadFile";
            this.buttonDownloadFile.Size = new System.Drawing.Size(131, 44);
            this.buttonDownloadFile.TabIndex = 2;
            this.buttonDownloadFile.Text = "Download";
            this.buttonDownloadFile.UseVisualStyleBackColor = true;
            this.buttonDownloadFile.Click += new System.EventHandler(this.buttonDownloadFile_Click);
            // 
            // buttonDeleteFile
            // 
            this.buttonDeleteFile.Location = new System.Drawing.Point(346, 28);
            this.buttonDeleteFile.Name = "buttonDeleteFile";
            this.buttonDeleteFile.Size = new System.Drawing.Size(131, 44);
            this.buttonDeleteFile.TabIndex = 3;
            this.buttonDeleteFile.Text = "Delete";
            this.buttonDeleteFile.UseVisualStyleBackColor = true;
            this.buttonDeleteFile.Click += new System.EventHandler(this.buttonDeleteFile_Click);
            // 
            // buttonUploadFile
            // 
            this.buttonUploadFile.Location = new System.Drawing.Point(50, 28);
            this.buttonUploadFile.Name = "buttonUploadFile";
            this.buttonUploadFile.Size = new System.Drawing.Size(131, 44);
            this.buttonUploadFile.TabIndex = 1;
            this.buttonUploadFile.Text = "Upload";
            this.buttonUploadFile.UseVisualStyleBackColor = true;
            this.buttonUploadFile.Click += new System.EventHandler(this.buttonUploadFile_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Location = new System.Drawing.Point(1046, 28);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(113, 44);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panelListview
            // 
            this.panelListview.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelListview.Controls.Add(this.listviewListFile);
            this.panelListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelListview.Location = new System.Drawing.Point(0, 563);
            this.panelListview.Name = "panelListview";
            this.panelListview.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panelListview.Size = new System.Drawing.Size(1213, 419);
            this.panelListview.TabIndex = 2;
            // 
            // listviewListFile
            // 
            this.listviewListFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listviewListFile.FullRowSelect = true;
            this.listviewListFile.HideSelection = false;
            this.listviewListFile.Location = new System.Drawing.Point(10, 0);
            this.listviewListFile.MultiSelect = false;
            this.listviewListFile.Name = "listviewListFile";
            this.listviewListFile.Size = new System.Drawing.Size(1193, 409);
            this.listviewListFile.TabIndex = 0;
            this.listviewListFile.UseCompatibleStateImageBehavior = false;
            this.listviewListFile.Click += new System.EventHandler(this.listviewListFile_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(524, 38);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(62, 25);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(676, 38);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(57, 25);
            this.labelSize.TabIndex = 5;
            this.labelSize.Text = "Size:";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1213, 982);
            this.Controls.Add(this.panelListview);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.panelLogin);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTP Client";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            this.panelListview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Panel panelListview;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox txtIPFTPServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonDeleteFile;
        private System.Windows.Forms.Button buttonUploadFile;
        private System.Windows.Forms.ListView listviewListFile;
        private System.Windows.Forms.Button buttonDownloadFile;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelTotal;
    }
}

