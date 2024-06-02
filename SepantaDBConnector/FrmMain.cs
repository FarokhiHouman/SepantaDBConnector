using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace SepantaDBConnector;

public partial class FrmMain : RibbonForm
{
	public FrmMain()
	{
		InitializeComponent();
	}

	private void btnCompany_ItemClick(object sender, ItemClickEventArgs e)
	{
		FrmCompany frm = new();
		frm.MdiParent = this;
		frm.Show();
	}

	private void btnApplication_ItemClick(object sender, ItemClickEventArgs e)
	{
		FrmApp frm = new();
		frm.MdiParent = this;
		frm.Show();
	}

	private void btnConnection_ItemClick(object sender, ItemClickEventArgs e)
	{
		FrmConnection frm = new();
		frm.MdiParent = this;
		frm.Show();
	}

	private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
	{
		Close();
	}

	private void FrmMain2_Load(object sender, EventArgs e)
	{
		if (!ClsRegEdit.SepantaExist())
			Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true)
				?.CreateSubKey(subkey: Resources.reg_Sepanta);
	}
}