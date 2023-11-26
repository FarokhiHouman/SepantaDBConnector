namespace SepantaDBConnector.App
{
    partial class FrmApp
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
			this.lstCompanies = new System.Windows.Forms.ListBox();
			this.lstApp = new System.Windows.Forms.ListBox();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtAppDescription = new System.Windows.Forms.TextBox();
			this.txtAppVersion = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lstCompanies
			// 
			this.lstCompanies.FormattingEnabled = true;
			this.lstCompanies.Location = new System.Drawing.Point(12, 12);
			this.lstCompanies.Name = "lstCompanies";
			this.lstCompanies.Size = new System.Drawing.Size(254, 277);
			this.lstCompanies.TabIndex = 1;
			this.lstCompanies.SelectedIndexChanged += new System.EventHandler(this.lstCompanies_SelectedIndexChanged);
			// 
			// lstApp
			// 
			this.lstApp.FormattingEnabled = true;
			this.lstApp.Location = new System.Drawing.Point(272, 12);
			this.lstApp.Name = "lstApp";
			this.lstApp.Size = new System.Drawing.Size(254, 277);
			this.lstApp.TabIndex = 1;
			this.lstApp.SelectedIndexChanged += new System.EventHandler(this.lstApp_SelectedIndexChanged);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(678, 266);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 6;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(579, 266);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtAppDescription
			// 
			this.txtAppDescription.Enabled = false;
			this.txtAppDescription.Location = new System.Drawing.Point(532, 78);
			this.txtAppDescription.Multiline = true;
			this.txtAppDescription.Name = "txtAppDescription";
			this.txtAppDescription.Size = new System.Drawing.Size(272, 182);
			this.txtAppDescription.TabIndex = 5;
			// 
			// txtAppVersion
			// 
			this.txtAppVersion.Enabled = false;
			this.txtAppVersion.Location = new System.Drawing.Point(532, 28);
			this.txtAppVersion.Name = "txtAppVersion";
			this.txtAppVersion.Size = new System.Drawing.Size(272, 21);
			this.txtAppVersion.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(533, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Application Description :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(533, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Version :";
			// 
			// FrmApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(818, 305);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtAppVersion);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtAppDescription);
			this.Controls.Add(this.lstApp);
			this.Controls.Add(this.lstCompanies);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmApp";
			this.ShowInTaskbar = false;
			this.Text = "Applications";
			this.Load += new System.EventHandler(this.FrmApp_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private ListBox lstCompanies;
        private ListBox lstApp;
        private Button btnRemove;
        private Button btnAdd;
        private TextBox txtAppDescription;
        private TextBox txtAppVersion;
        private Label label1;
        private Label label2;
    }
}