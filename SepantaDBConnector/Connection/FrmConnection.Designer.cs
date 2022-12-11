namespace SepantaDBConnector.Connection
{
    partial class FrmConnection
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
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbApplication = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateConnection = new System.Windows.Forms.Button();
            this.btnDeleteConnection = new System.Windows.Forms.Button();
            this.grpApps = new System.Windows.Forms.GroupBox();
            this.grpDataSource = new System.Windows.Forms.GroupBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.cmbServerType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.txtSqlPassword = new System.Windows.Forms.TextBox();
            this.txtSqlUsername = new System.Windows.Forms.TextBox();
            this.rdbSqlAuth = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbWindowsAuth = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.grpDataase = new System.Windows.Forms.GroupBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnSaveConnection = new System.Windows.Forms.Button();
            this.grpTestSaveBtn = new System.Windows.Forms.GroupBox();
            this.grpApps.SuspendLayout();
            this.grpDataSource.SuspendLayout();
            this.grpLogin.SuspendLayout();
            this.grpDataase.SuspendLayout();
            this.grpTestSaveBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCompany
            // 
            this.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(102, 19);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(220, 21);
            this.cmbCompany.TabIndex = 0;
            this.cmbCompany.SelectedIndexChanged += new System.EventHandler(this.cmbCompany_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company :";
            // 
            // cmbApplication
            // 
            this.cmbApplication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApplication.FormattingEnabled = true;
            this.cmbApplication.Location = new System.Drawing.Point(102, 46);
            this.cmbApplication.Name = "cmbApplication";
            this.cmbApplication.Size = new System.Drawing.Size(220, 21);
            this.cmbApplication.TabIndex = 1;
            this.cmbApplication.SelectedIndexChanged += new System.EventHandler(this.cmbApplication_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Application :";
            // 
            // btnCreateConnection
            // 
            this.btnCreateConnection.Enabled = false;
            this.btnCreateConnection.Location = new System.Drawing.Point(102, 73);
            this.btnCreateConnection.Name = "btnCreateConnection";
            this.btnCreateConnection.Size = new System.Drawing.Size(107, 23);
            this.btnCreateConnection.TabIndex = 2;
            this.btnCreateConnection.Text = "Create connection";
            this.btnCreateConnection.UseVisualStyleBackColor = true;
            this.btnCreateConnection.Click += new System.EventHandler(this.btnCreateConnection_Click);
            // 
            // btnDeleteConnection
            // 
            this.btnDeleteConnection.Enabled = false;
            this.btnDeleteConnection.Location = new System.Drawing.Point(215, 73);
            this.btnDeleteConnection.Name = "btnDeleteConnection";
            this.btnDeleteConnection.Size = new System.Drawing.Size(107, 23);
            this.btnDeleteConnection.TabIndex = 3;
            this.btnDeleteConnection.Text = "Delete connection";
            this.btnDeleteConnection.UseVisualStyleBackColor = true;
            this.btnDeleteConnection.Click += new System.EventHandler(this.btnDeleteConnection_Click);
            // 
            // grpApps
            // 
            this.grpApps.Controls.Add(this.cmbCompany);
            this.grpApps.Controls.Add(this.btnCreateConnection);
            this.grpApps.Controls.Add(this.btnDeleteConnection);
            this.grpApps.Controls.Add(this.cmbApplication);
            this.grpApps.Controls.Add(this.label1);
            this.grpApps.Controls.Add(this.label2);
            this.grpApps.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpApps.Location = new System.Drawing.Point(0, 0);
            this.grpApps.Name = "grpApps";
            this.grpApps.Size = new System.Drawing.Size(385, 110);
            this.grpApps.TabIndex = 0;
            this.grpApps.TabStop = false;
            // 
            // grpDataSource
            // 
            this.grpDataSource.Controls.Add(this.txtServerName);
            this.grpDataSource.Controls.Add(this.cmbServerType);
            this.grpDataSource.Controls.Add(this.label4);
            this.grpDataSource.Controls.Add(this.label3);
            this.grpDataSource.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDataSource.Enabled = false;
            this.grpDataSource.Location = new System.Drawing.Point(0, 110);
            this.grpDataSource.Name = "grpDataSource";
            this.grpDataSource.Size = new System.Drawing.Size(385, 80);
            this.grpDataSource.TabIndex = 1;
            this.grpDataSource.TabStop = false;
            this.grpDataSource.Text = "Data Source";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(102, 46);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(220, 20);
            this.txtServerName.TabIndex = 1;
            this.txtServerName.TextChanged += new System.EventHandler(this.txtServerName_TextChanged);
            // 
            // cmbServerType
            // 
            this.cmbServerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServerType.FormattingEnabled = true;
            this.cmbServerType.Items.AddRange(new object[] {
            "Microsoft SQL Server (SqlClient)"});
            this.cmbServerType.Location = new System.Drawing.Point(102, 19);
            this.cmbServerType.Name = "cmbServerType";
            this.cmbServerType.Size = new System.Drawing.Size(220, 21);
            this.cmbServerType.TabIndex = 0;
            this.cmbServerType.SelectedIndexChanged += new System.EventHandler(this.cmbServerType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Server name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server type :";
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.txtSqlPassword);
            this.grpLogin.Controls.Add(this.txtSqlUsername);
            this.grpLogin.Controls.Add(this.rdbSqlAuth);
            this.grpLogin.Controls.Add(this.label6);
            this.grpLogin.Controls.Add(this.rdbWindowsAuth);
            this.grpLogin.Controls.Add(this.label5);
            this.grpLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpLogin.Enabled = false;
            this.grpLogin.Location = new System.Drawing.Point(0, 190);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(385, 140);
            this.grpLogin.TabIndex = 2;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            // 
            // txtSqlPassword
            // 
            this.txtSqlPassword.Location = new System.Drawing.Point(102, 100);
            this.txtSqlPassword.Name = "txtSqlPassword";
            this.txtSqlPassword.PasswordChar = '*';
            this.txtSqlPassword.Size = new System.Drawing.Size(220, 20);
            this.txtSqlPassword.TabIndex = 3;
            this.txtSqlPassword.TextChanged += new System.EventHandler(this.txtSqlUsername_TextChanged);
            // 
            // txtSqlUsername
            // 
            this.txtSqlUsername.Location = new System.Drawing.Point(102, 74);
            this.txtSqlUsername.Name = "txtSqlUsername";
            this.txtSqlUsername.Size = new System.Drawing.Size(220, 20);
            this.txtSqlUsername.TabIndex = 2;
            this.txtSqlUsername.TextChanged += new System.EventHandler(this.txtSqlUsername_TextChanged);
            // 
            // rdbSqlAuth
            // 
            this.rdbSqlAuth.AutoSize = true;
            this.rdbSqlAuth.Checked = true;
            this.rdbSqlAuth.Location = new System.Drawing.Point(34, 42);
            this.rdbSqlAuth.Name = "rdbSqlAuth";
            this.rdbSqlAuth.Size = new System.Drawing.Size(170, 17);
            this.rdbSqlAuth.TabIndex = 1;
            this.rdbSqlAuth.TabStop = true;
            this.rdbSqlAuth.Text = "Use SQLServer Authentication";
            this.rdbSqlAuth.UseVisualStyleBackColor = true;
            this.rdbSqlAuth.CheckedChanged += new System.EventHandler(this.LoginTypeChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password :";
            // 
            // rdbWindowsAuth
            // 
            this.rdbWindowsAuth.AutoSize = true;
            this.rdbWindowsAuth.Location = new System.Drawing.Point(34, 19);
            this.rdbWindowsAuth.Name = "rdbWindowsAuth";
            this.rdbWindowsAuth.Size = new System.Drawing.Size(162, 17);
            this.rdbWindowsAuth.TabIndex = 0;
            this.rdbWindowsAuth.Text = "Use Windows Authentication";
            this.rdbWindowsAuth.UseVisualStyleBackColor = true;
            this.rdbWindowsAuth.CheckedChanged += new System.EventHandler(this.LoginTypeChange);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "User name :";
            // 
            // grpDataase
            // 
            this.grpDataase.Controls.Add(this.txtDatabaseName);
            this.grpDataase.Controls.Add(this.label7);
            this.grpDataase.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDataase.Enabled = false;
            this.grpDataase.Location = new System.Drawing.Point(0, 330);
            this.grpDataase.Name = "grpDataase";
            this.grpDataase.Size = new System.Drawing.Size(385, 84);
            this.grpDataase.TabIndex = 3;
            this.grpDataase.TabStop = false;
            this.grpDataase.Text = "Connect to database";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(102, 38);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(220, 20);
            this.txtDatabaseName.TabIndex = 0;
            this.txtDatabaseName.TextChanged += new System.EventHandler(this.txtDatabaseName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Database name :";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(12, 19);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(103, 23);
            this.btnTestConnection.TabIndex = 0;
            this.btnTestConnection.Text = "Test connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnSaveConnection
            // 
            this.btnSaveConnection.Enabled = false;
            this.btnSaveConnection.Location = new System.Drawing.Point(270, 19);
            this.btnSaveConnection.Name = "btnSaveConnection";
            this.btnSaveConnection.Size = new System.Drawing.Size(103, 23);
            this.btnSaveConnection.TabIndex = 1;
            this.btnSaveConnection.Text = "Save connection";
            this.btnSaveConnection.UseVisualStyleBackColor = true;
            this.btnSaveConnection.Click += new System.EventHandler(this.btnSaveConnection_Click);
            // 
            // grpTestSaveBtn
            // 
            this.grpTestSaveBtn.Controls.Add(this.btnSaveConnection);
            this.grpTestSaveBtn.Controls.Add(this.btnTestConnection);
            this.grpTestSaveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTestSaveBtn.Enabled = false;
            this.grpTestSaveBtn.Location = new System.Drawing.Point(0, 414);
            this.grpTestSaveBtn.Name = "grpTestSaveBtn";
            this.grpTestSaveBtn.Size = new System.Drawing.Size(385, 57);
            this.grpTestSaveBtn.TabIndex = 4;
            this.grpTestSaveBtn.TabStop = false;
            // 
            // FrmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 471);
            this.Controls.Add(this.grpTestSaveBtn);
            this.Controls.Add(this.grpDataase);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.grpDataSource);
            this.Controls.Add(this.grpApps);
            this.Name = "FrmConnection";
            this.Text = "Connection setting";
            this.Load += new System.EventHandler(this.FrmConnection_Load);
            this.grpApps.ResumeLayout(false);
            this.grpApps.PerformLayout();
            this.grpDataSource.ResumeLayout(false);
            this.grpDataSource.PerformLayout();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpDataase.ResumeLayout(false);
            this.grpDataase.PerformLayout();
            this.grpTestSaveBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cmbCompany;
        private Label label1;
        private ComboBox cmbApplication;
        private Label label2;
        private Button btnCreateConnection;
        private Button btnDeleteConnection;
        private GroupBox grpApps;
        private GroupBox grpDataSource;
        private TextBox txtServerName;
        private ComboBox cmbServerType;
        private Label label4;
        private Label label3;
        private GroupBox grpLogin;
        private TextBox txtSqlPassword;
        private TextBox txtSqlUsername;
        private RadioButton rdbSqlAuth;
        private Label label6;
        private RadioButton rdbWindowsAuth;
        private Label label5;
        private GroupBox grpDataase;
        private TextBox txtDatabaseName;
        private Label label7;
        private Button btnTestConnection;
        private Button btnSaveConnection;
        private GroupBox grpTestSaveBtn;
    }
}