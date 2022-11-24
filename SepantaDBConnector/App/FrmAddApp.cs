namespace SepantaDBConnector.App;
public partial class FrmAddApp : Form
{
	public FrmAddApp(
		string companyName)
	{
		InitializeComponent();
		CompanyName = companyName;
		Text        = Resources.Add + @" To " + CompanyName;
	}
	public new string CompanyName { get; set; }
	private void btnCancel_Click(
		object    sender,
		EventArgs e) =>
		Close();
	private void btnOk_Click(
		object    sender,
		EventArgs e)
	{
		if (!ClsRegEdit.AddApplication(companyName: CompanyName,
									   appName: txtApplicationName.Text,
									   version: txtVersion.Text,
									   desc: txtApplicationDesc.Text
									  ))
			return;
		MessageBox.Show(text: Resources.CreatedSucces,
						caption: Resources.Created,
						buttons: MessageBoxButtons.OK,
						icon: MessageBoxIcon.Asterisk
					   );
		Close();
	}
}