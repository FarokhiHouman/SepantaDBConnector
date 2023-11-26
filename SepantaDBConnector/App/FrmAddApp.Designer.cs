namespace SepantaDBConnector.App
{
    partial class FrmAddApp
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtApplicationDesc = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtApplicationName = new System.Windows.Forms.TextBox();
			this.txtVersion = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(185, 315);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(58, 315);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 3;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Application Description :";
			// 
			// txtApplicationDesc
			// 
			this.txtApplicationDesc.Location = new System.Drawing.Point(29, 138);
			this.txtApplicationDesc.Multiline = true;
			this.txtApplicationDesc.Name = "txtApplicationDesc";
			this.txtApplicationDesc.Size = new System.Drawing.Size(274, 160);
			this.txtApplicationDesc.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Application Name :";
			// 
			// txtApplicationName
			// 
			this.txtApplicationName.Location = new System.Drawing.Point(29, 36);
			this.txtApplicationName.Name = "txtApplicationName";
			this.txtApplicationName.Size = new System.Drawing.Size(274, 21);
			this.txtApplicationName.TabIndex = 0;
			// 
			// txtVersion
			// 
			this.txtVersion.Location = new System.Drawing.Point(29, 89);
			this.txtVersion.Name = "txtVersion";
			this.txtVersion.Size = new System.Drawing.Size(274, 21);
			this.txtVersion.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Version :";
			// 
			// FrmAddApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 370);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtApplicationDesc);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtVersion);
			this.Controls.Add(this.txtApplicationName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmAddApp";
			this.ShowInTaskbar = false;
			this.Text = "FrmAddApp";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnOk;
        private Label label2;
        private TextBox txtApplicationDesc;
        private Label label1;
        private TextBox txtApplicationName;
        private TextBox txtVersion;
        private Label label3;
    }
}