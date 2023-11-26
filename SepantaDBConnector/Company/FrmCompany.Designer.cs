namespace SepantaDBConnector.Company
{
    partial class FrmCompany
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtCompanyDescription = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstCompanies
			// 
			this.lstCompanies.FormattingEnabled = true;
			this.lstCompanies.Location = new System.Drawing.Point(12, 12);
			this.lstCompanies.Name = "lstCompanies";
			this.lstCompanies.Size = new System.Drawing.Size(254, 277);
			this.lstCompanies.TabIndex = 0;
			this.lstCompanies.SelectedIndexChanged += new System.EventHandler(this.lstCompanies_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(272, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Company Description";
			// 
			// txtCompanyDescription
			// 
			this.txtCompanyDescription.Enabled = false;
			this.txtCompanyDescription.Location = new System.Drawing.Point(275, 28);
			this.txtCompanyDescription.Multiline = true;
			this.txtCompanyDescription.Name = "txtCompanyDescription";
			this.txtCompanyDescription.Size = new System.Drawing.Size(272, 224);
			this.txtCompanyDescription.TabIndex = 2;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(292, 258);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(413, 258);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 3;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// FrmCompany
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(561, 298);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtCompanyDescription);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstCompanies);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmCompany";
			this.ShowInTaskbar = false;
			this.Text = "Companies";
			this.Load += new System.EventHandler(this.FrmCompany_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private ListBox lstCompanies;
        private Label label1;
        private TextBox txtCompanyDescription;
        private Button btnAdd;
        private Button btnRemove;
    }
}