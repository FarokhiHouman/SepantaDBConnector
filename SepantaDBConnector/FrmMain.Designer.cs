namespace SepantaDBConnector
{
	partial class FrmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnCompany = new DevExpress.XtraBars.BarButtonItem();
			this.btnApplication = new DevExpress.XtraBars.BarButtonItem();
			this.btnConnection = new DevExpress.XtraBars.BarButtonItem();
			this.btnExit = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl1
			// 
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnCompany,
            this.btnApplication,
            this.btnConnection,
            this.btnExit});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 5;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl1.Size = new System.Drawing.Size(1089, 158);
			this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
			// 
			// btnCompany
			// 
			this.btnCompany.Caption = "1-Company";
			this.btnCompany.Id = 1;
			this.btnCompany.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCompany.ImageOptions.SvgImage")));
			this.btnCompany.Name = "btnCompany";
			this.btnCompany.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			this.btnCompany.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCompany_ItemClick);
			// 
			// btnApplication
			// 
			this.btnApplication.Caption = "2-Application";
			this.btnApplication.Id = 2;
			this.btnApplication.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnApplication.ImageOptions.SvgImage")));
			this.btnApplication.Name = "btnApplication";
			this.btnApplication.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnApplication_ItemClick);
			// 
			// btnConnection
			// 
			this.btnConnection.Caption = "3-Connection";
			this.btnConnection.Id = 3;
			this.btnConnection.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnConnection.ImageOptions.SvgImage")));
			this.btnConnection.Name = "btnConnection";
			this.btnConnection.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnConnection_ItemClick);
			// 
			// btnExit
			// 
			this.btnExit.Caption = "Exit";
			this.btnExit.Id = 4;
			this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
			this.btnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.LargeImage")));
			this.btnExit.Name = "btnExit";
			this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "DBConnector";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.btnCompany);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnApplication);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnConnection);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.ItemLinks.Add(this.btnExit);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			// 
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 764);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1089, 22);
			// 
			// ribbonPage2
			// 
			this.ribbonPage2.Name = "ribbonPage2";
			this.ribbonPage2.Text = "ribbonPage2";
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1089, 786);
			this.ControlBox = false;
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.ribbonControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.IconOptions.Image = global::SepantaDBConnector.Properties.Resources.SepantaDBConnector;
			this.IsMdiContainer = true;
			this.MaximizeBox = false;
			this.Name = "FrmMain";
			this.Ribbon = this.ribbonControl1;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "FrmMain2";
			this.Load += new System.EventHandler(this.FrmMain2_Load);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
		private DevExpress.XtraBars.BarButtonItem btnCompany;
		private DevExpress.XtraBars.BarButtonItem btnApplication;
		private DevExpress.XtraBars.BarButtonItem btnConnection;
		private DevExpress.XtraBars.BarButtonItem btnExit;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
	}
}