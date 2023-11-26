namespace SepantaDBConnector;

public static class ClsRegEdit
{
#region Mthods
#region Other
	public static bool SepantaExist()
	{
		string[] regKeys = Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true)!.GetSubKeyNames();
		return regKeys.Any(predicate: regKey => regKey == Resources.reg_Sepanta);
	}
	public static string[] GetAllCompanies()
	{
		return Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true).OpenSubKey(name: Resources.reg_Sepanta, writable: true).GetSubKeyNames();
	}
	public static string GetCompanyDescription(string companyName)
	{
		return Convert.ToString(value: Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true)
.OpenSubKey(name: Resources.reg_Sepanta, writable: true)
.OpenSubKey(name: companyName,           writable: true)
.GetValue(name: Resources.reg_Description));
	}
	public static bool CreateCompany(string companyName, string companyDesc)
	{
		if (CompanyExist(companyName: companyName)) return false;
		Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true)
				.OpenSubKey(name: Resources.reg_Sepanta, writable: true)
				.CreateSubKey(subkey: companyName)
				.SetValue(name: Resources.reg_Description, value: companyDesc, valueKind: RegistryValueKind.String);
		return true;
	}
	private static bool CompanyExist(string companyName)
	{
		return GetAllCompanies().Any(predicate: company => company == companyName);
	}
	public static void RemoveCompany(string companyName)
	{
		if (CompanyExist(companyName: companyName)) Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true).OpenSubKey(name: Resources.reg_Sepanta, writable: true).DeleteSubKeyTree(subkey: companyName);
	}
	public static string[] GetAllApplication(string companyName)
	{
		try
		{
			return Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true).OpenSubKey(name: Resources.reg_Sepanta, writable: true).OpenSubKey(name: companyName, writable: true).GetSubKeyNames();
		}
		catch (Exception e)
		{
			MessageBox.Show(text: e.Message, caption: @"Error");
			return null;
		}
	}
	public static bool AppExist(string appName, string companyName)
	{
		return GetAllApplication(companyName: companyName).Any(predicate: s => s == appName);
	}
	public static bool AddApplication(string companyName, string appName, string version, string desc)
	{
		if (AppExist(appName: appName, companyName: companyName)) return false;
		Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true)
				.OpenSubKey(name: Resources.reg_Sepanta, writable: true)
				.OpenSubKey(name: companyName,           writable: true)
				.CreateSubKey(subkey: appName)
				.SetValue(name: Resources.reg_Description, value: desc, valueKind: RegistryValueKind.String);
		Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true)
				.OpenSubKey(name: Resources.reg_Sepanta, writable: true)
				.OpenSubKey(name: companyName,           writable: true)
				.CreateSubKey(subkey: appName)
				.SetValue(name: Resources.reg_Version, value: version, valueKind: RegistryValueKind.String);
		return true;
	}
	public static bool RemoveApplication(string selectedCompany, string selectedApplication)
	{
		if (!AppExist(appName: selectedApplication, companyName: selectedCompany)) return false;
		Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true).OpenSubKey(name: Resources.reg_Sepanta, writable: true).OpenSubKey(name: selectedCompany, writable: true).DeleteSubKeyTree(subkey: selectedApplication);
		return true;
	}
	public static string GetAppVersion(string selectedCompany, string selectedApplication)
	{
		return Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true)
.OpenSubKey(name: Resources.reg_Sepanta, writable: true)
.OpenSubKey(name: selectedCompany,       writable: true)
.OpenSubKey(name: selectedApplication,   writable: true)
.GetValue(name: Resources.reg_Version)
.ToString();
	}
	public static string GetAppDesc(string selectedCompany, string selectedApplication)
	{
		return Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true)
.OpenSubKey(name: Resources.reg_Sepanta, writable: true)
.OpenSubKey(name: selectedCompany,       writable: true)
.OpenSubKey(name: selectedApplication,   writable: true)
.GetValue(name: Resources.reg_Description)
.ToString();
	}
	public static bool AppHasConnection(string app, string company)
	{
		string[] values = Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true)
								  .OpenSubKey(name: Resources.reg_Sepanta, writable: true)
								  .OpenSubKey(name: company,               writable: true)
								  .OpenSubKey(name: app,                   writable: true)
								  .GetValueNames();
		return values.Any(predicate: value => value == Resources.reg_CentralConnection);
	}
	public static string GetConeectionString(string app, string company)
	{
		return Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true)
.OpenSubKey(name: Resources.reg_Sepanta, writable: true)
.OpenSubKey(name: company,               writable: true)
.OpenSubKey(name: app,                   writable: true)
.GetValue(name: Resources.reg_CentralConnection)
.ToString();
	}
	public static bool RemoveConnection(string app, string company)
	{
		try
		{
			Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true)
					.OpenSubKey(name: Resources.reg_Sepanta, writable: true)
					.OpenSubKey(name: company,               writable: true)
					.OpenSubKey(name: app,                   writable: true)
					.DeleteValue(name: Resources.reg_CentralConnection);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}
#endregion
#endregion
}