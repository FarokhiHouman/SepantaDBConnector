using DevExpress.XtraEditors;

namespace SepantaDBConnector.Connection;

public partial class FrmConnection : XtraForm
{
	private SqlConnectionStringBuilder _connectionStringBuilder;

	public FrmConnection()
	{
		InitializeComponent();
	}

	public string SelectedCompany     { get; set; }
	public string SelectedApplication { get; set; }

	private void FrmConnection_Load(object sender, EventArgs e)
	{
		cmbCompany.DataSource = ClsRegEdit.GetAllCompanies();
	}

	private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
	{
		cmbApplication.DataSource   = ClsRegEdit.GetAllApplication(companyName: cmbCompany.Text);
		SelectedCompany             = cmbCompany.Text;
		btnCreateConnection.Enabled = cmbApplication.SelectedIndex != -1;
	}

	private void btnCreateConnection_Click(object sender, EventArgs e)
	{
		grpDataSource.Enabled = true;
	}

	private void txtServerName_TextChanged(object sender, EventArgs e)
	{
		grpLogin.Enabled = (cmbServerType.SelectedIndex != -1) && (txtServerName.Text.Length > 0);
	}

	private void cmbServerType_SelectedIndexChanged(object sender, EventArgs e)
	{
		txtServerName_TextChanged(sender: sender, e: e);
	}

	private void LoginTypeChange(object sender, EventArgs e)
	{
		txtSqlPassword.Enabled = rdbSqlAuth.Checked;
		txtSqlUsername.Enabled = rdbSqlAuth.Checked;
		grpDataase.Enabled     = rdbWindowsAuth.Checked;
	}

	private void txtSqlUsername_TextChanged(object sender, EventArgs e)
	{
		grpDataase.Enabled = (txtSqlUsername.Text.Length > 0) && (txtSqlPassword.Text.Length > 0);
	}

	private void txtDatabaseName_TextChanged(object sender, EventArgs e)
	{
		grpTestSaveBtn.Enabled = txtDatabaseName.Text.Length > 0;
	}

	private void btnTestConnection_Click(object sender, EventArgs e)
	{
		_connectionStringBuilder = new() { DataSource = txtServerName.Text };
		if (rdbSqlAuth.Checked)
		{
			_connectionStringBuilder.IntegratedSecurity = false;
			_connectionStringBuilder.InitialCatalog     = txtDatabaseName.Text;
			_connectionStringBuilder.UserID             = txtSqlUsername.Text;
			_connectionStringBuilder.Password           = txtSqlPassword.Text;
		}
		else
		{
			_connectionStringBuilder.IntegratedSecurity = true;
			_connectionStringBuilder.InitialCatalog     = txtDatabaseName.Text;
		}

		using SqlConnection sqlConnection = new(connectionString: _connectionStringBuilder.ConnectionString);
		try
		{
			sqlConnection.Open();
			MessageBox.Show(text: Resources.Con_TestSucseeded, caption: Resources.SepantaConnection,
				buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Asterisk);
			btnSaveConnection.Enabled = true;
		}
		catch (SqlException ex)
		{
			MessageBox.Show(text: ex.Message, caption: ex.Number.ToString());
			btnSaveConnection.Enabled = false;
		}
	}

	private void btnSaveConnection_Click(object sender, EventArgs e)
	{
		try
		{
			_connectionStringBuilder = new() { DataSource = txtServerName.Text };
			if (rdbSqlAuth.Checked)
			{
				_connectionStringBuilder.IntegratedSecurity = false;
				_connectionStringBuilder.InitialCatalog     = txtDatabaseName.Text;
				_connectionStringBuilder.UserID             = txtSqlUsername.Text;
				_connectionStringBuilder.Password           = txtSqlPassword.Text;
			}
			else
			{
				_connectionStringBuilder.IntegratedSecurity = true;
				_connectionStringBuilder.InitialCatalog     = txtDatabaseName.Text;
			}

			Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true)
				.OpenSubKey(name: Resources.reg_Sepanta, writable: true)
				.OpenSubKey(name: SelectedCompany,       writable: true)
				.OpenSubKey(name: SelectedApplication,   writable: true)
				.SetValue(name: Resources.reg_CentralConnection, value: _connectionStringBuilder.ConnectionString);
			MessageBox.Show(text: Resources.ConnectionSaved, caption: Resources.SepantaConnection,
				buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Asterisk);
		}
		catch (Exception)
		{
			MessageBox.Show(text: Resources.ConnectionNotSaved, caption: Resources.SepantaConnection,
				buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}
	}

	private void cmbApplication_SelectedIndexChanged(object sender, EventArgs e)
	{
		SelectedApplication = cmbApplication.Text;
		SelectedCompany     = cmbCompany.Text;
		if ((SelectedApplication == string.Empty) || (SelectedCompany == string.Empty)) return;
		if (!ClsRegEdit.AppHasConnection(app: SelectedApplication, company: SelectedCompany))
		{
			grpDataase.Enabled = grpLogin.Enabled =
				grpDataSource.Enabled = grpTestSaveBtn.Enabled = btnDeleteConnection.Enabled = false;
			btnCreateConnection.Enabled = true;
		}
		else
		{
			grpDataase.Enabled = grpLogin.Enabled =
				grpDataSource.Enabled = grpTestSaveBtn.Enabled = btnDeleteConnection.Enabled = true;
			btnCreateConnection.Enabled = false;
			_connectionStringBuilder = new()
			{
				ConnectionString = ClsRegEdit.GetConeectionString(app: SelectedApplication, company: SelectedCompany)
			};
			cmbServerType.SelectedIndex = 0;
			txtServerName.Text          = _connectionStringBuilder.DataSource;
			rdbSqlAuth.Checked          = !_connectionStringBuilder.IntegratedSecurity;
			rdbWindowsAuth.Checked      = _connectionStringBuilder.IntegratedSecurity;
			txtDatabaseName.Text        = _connectionStringBuilder.InitialCatalog;
			if (_connectionStringBuilder.IntegratedSecurity) return;
			txtSqlUsername.Text = _connectionStringBuilder.UserID;
			txtSqlPassword.Text = _connectionStringBuilder.Password;
		}
	}

	private void btnDeleteConnection_Click(object sender, EventArgs e)
	{
		try
		{
			ClsRegEdit.RemoveConnection(app: SelectedApplication, company: SelectedCompany);
			FrmConnection_Load(sender: sender, e: e);
		}
		catch (Exception exception)
		{
			MessageBox.Show(text: exception.Message, caption: "", buttons: MessageBoxButtons.OK,
				icon: MessageBoxIcon.Warning);
		}
	}
}