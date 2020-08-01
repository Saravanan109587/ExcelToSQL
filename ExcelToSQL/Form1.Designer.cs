namespace ExcelToSQL
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_server = new MetroFramework.Controls.MetroPanel();
            this.txt_server = new MetroFramework.Controls.MetroTextBox();
            this.lbl_server = new MetroFramework.Controls.MetroLabel();
            this.chk_windowsAuth = new MetroFramework.Controls.MetroCheckBox();
            this.pnl_credential = new MetroFramework.Controls.MetroPanel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.lbl_pass = new MetroFramework.Controls.MetroLabel();
            this.lbl_username = new MetroFramework.Controls.MetroLabel();
            this.btn_connect = new MetroFramework.Controls.MetroButton();
            this.cmb_databases = new MetroFramework.Controls.MetroComboBox();
            this.lbl_selectDB = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.pnl_server.SuspendLayout();
            this.pnl_credential.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_server
            // 
            this.pnl_server.Controls.Add(this.chk_windowsAuth);
            this.pnl_server.Controls.Add(this.lbl_server);
            this.pnl_server.Controls.Add(this.txt_server);
            this.pnl_server.HorizontalScrollbarBarColor = true;
            this.pnl_server.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_server.HorizontalScrollbarSize = 10;
            this.pnl_server.Location = new System.Drawing.Point(24, 24);
            this.pnl_server.Name = "pnl_server";
            this.pnl_server.Size = new System.Drawing.Size(307, 69);
            this.pnl_server.TabIndex = 2;
            this.pnl_server.VerticalScrollbarBarColor = true;
            this.pnl_server.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_server.VerticalScrollbarSize = 10;
            // 
            // txt_server
            // 
            // 
            // 
            // 
            this.txt_server.CustomButton.Image = null;
            this.txt_server.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txt_server.CustomButton.Name = "";
            this.txt_server.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_server.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_server.CustomButton.TabIndex = 1;
            this.txt_server.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_server.CustomButton.UseSelectable = true;
            this.txt_server.CustomButton.Visible = false;
            this.txt_server.Lines = new string[] {
        "127.0.0.1"};
            this.txt_server.Location = new System.Drawing.Point(134, 14);
            this.txt_server.MaxLength = 32767;
            this.txt_server.Name = "txt_server";
            this.txt_server.PasswordChar = '\0';
            this.txt_server.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_server.SelectedText = "";
            this.txt_server.SelectionLength = 0;
            this.txt_server.SelectionStart = 0;
            this.txt_server.ShortcutsEnabled = true;
            this.txt_server.Size = new System.Drawing.Size(168, 23);
            this.txt_server.TabIndex = 0;
            this.txt_server.Text = "127.0.0.1";
            this.txt_server.UseSelectable = true;
            this.txt_server.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_server.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_server
            // 
            this.lbl_server.AutoSize = true;
            this.lbl_server.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_server.Location = new System.Drawing.Point(3, 14);
            this.lbl_server.Name = "lbl_server";
            this.lbl_server.Size = new System.Drawing.Size(125, 19);
            this.lbl_server.TabIndex = 3;
            this.lbl_server.Text = "Server Name/IP :";
            // 
            // chk_windowsAuth
            // 
            this.chk_windowsAuth.AutoSize = true;
            this.chk_windowsAuth.Checked = true;
            this.chk_windowsAuth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_windowsAuth.Location = new System.Drawing.Point(179, 43);
            this.chk_windowsAuth.Name = "chk_windowsAuth";
            this.chk_windowsAuth.Size = new System.Drawing.Size(123, 15);
            this.chk_windowsAuth.TabIndex = 3;
            this.chk_windowsAuth.Text = "Use Windows Auth";
            this.chk_windowsAuth.UseSelectable = true;
            // 
            // pnl_credential
            // 
            this.pnl_credential.Controls.Add(this.lbl_pass);
            this.pnl_credential.Controls.Add(this.lbl_username);
            this.pnl_credential.Controls.Add(this.metroTextBox1);
            this.pnl_credential.Controls.Add(this.metroTextBox2);
            this.pnl_credential.HorizontalScrollbarBarColor = true;
            this.pnl_credential.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_credential.HorizontalScrollbarSize = 10;
            this.pnl_credential.Location = new System.Drawing.Point(58, 99);
            this.pnl_credential.Name = "pnl_credential";
            this.pnl_credential.Size = new System.Drawing.Size(273, 69);
            this.pnl_credential.TabIndex = 3;
            this.pnl_credential.VerticalScrollbarBarColor = true;
            this.pnl_credential.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_credential.VerticalScrollbarSize = 10;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(97, 39);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(168, 23);
            this.metroTextBox1.TabIndex = 4;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(97, 3);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(168, 23);
            this.metroTextBox2.TabIndex = 5;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_pass.Location = new System.Drawing.Point(2, 39);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(89, 19);
            this.lbl_pass.TabIndex = 4;
            this.lbl_pass.Text = "Password   :";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_username.Location = new System.Drawing.Point(3, 3);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(91, 19);
            this.lbl_username.TabIndex = 5;
            this.lbl_username.Text = "User Name :";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(337, 28);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(106, 29);
            this.btn_connect.TabIndex = 4;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseSelectable = true;
            // 
            // cmb_databases
            // 
            this.cmb_databases.FormattingEnabled = true;
            this.cmb_databases.ItemHeight = 23;
            this.cmb_databases.Location = new System.Drawing.Point(18, 22);
            this.cmb_databases.Name = "cmb_databases";
            this.cmb_databases.Size = new System.Drawing.Size(212, 29);
            this.cmb_databases.TabIndex = 5;
            this.cmb_databases.UseSelectable = true;
            // 
            // lbl_selectDB
            // 
            this.lbl_selectDB.AutoSize = true;
            this.lbl_selectDB.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_selectDB.Location = new System.Drawing.Point(18, 0);
            this.lbl_selectDB.Name = "lbl_selectDB";
            this.lbl_selectDB.Size = new System.Drawing.Size(179, 19);
            this.lbl_selectDB.TabIndex = 4;
            this.lbl_selectDB.Text = "select database to export";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lbl_selectDB);
            this.metroPanel1.Controls.Add(this.cmb_databases);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(459, 25);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(244, 57);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(12, 268);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(935, 238);
            this.metroGrid1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 518);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.pnl_credential);
            this.Controls.Add(this.pnl_server);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_server.ResumeLayout(false);
            this.pnl_server.PerformLayout();
            this.pnl_credential.ResumeLayout(false);
            this.pnl_credential.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnl_server;
        private MetroFramework.Controls.MetroLabel lbl_server;
        private MetroFramework.Controls.MetroTextBox txt_server;
        private MetroFramework.Controls.MetroCheckBox chk_windowsAuth;
        private MetroFramework.Controls.MetroPanel pnl_credential;
        private MetroFramework.Controls.MetroLabel lbl_pass;
        private MetroFramework.Controls.MetroLabel lbl_username;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroButton btn_connect;
        private MetroFramework.Controls.MetroComboBox cmb_databases;
        private MetroFramework.Controls.MetroLabel lbl_selectDB;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
    }
}

