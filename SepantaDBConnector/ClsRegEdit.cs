namespace SepantaDBConnector;
public static class ClsRegEdit {
    public static bool SepantaExist() {
        var regKeys =
            Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true)!.
                     GetSubKeyNames();
        return regKeys.Any(predicate: regKey => regKey == Resources.reg_Sepanta);
    }
    public static string[] GetAllCompanies() =>
        Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true).
                 OpenSubKey(name: Resources.reg_Sepanta, writable: true).GetSubKeyNames();
    public static string GetCompanyDescription(string companyName) =>
        Convert.ToString(value: Registry.CurrentUser.
                                         OpenSubKey(name: Resources.reg_Software, writable: true).
                                         OpenSubKey(name: Resources.reg_Sepanta,  writable: true).
                                         OpenSubKey(name: companyName,            writable: true).
                                         GetValue(name: Resources.reg_Description)
                        );
    public static bool CreateCompany(string companyName, string companyDesc) {
        if (ClsRegEdit.CompanyExist(companyName: companyName))
            return false;
        Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true).
                 OpenSubKey(name: Resources.reg_Sepanta, writable: true).
                 CreateSubKey(subkey: companyName).SetValue(name: Resources.reg_Description,
                                                            value: companyDesc,
                                                            valueKind: RegistryValueKind.String
                                                           );
        return true;
    }
    private static bool CompanyExist(string companyName) =>
        ClsRegEdit.GetAllCompanies().Any(predicate: company => company == companyName);
    public static void RemoveCompany(string companyName) {
        if (ClsRegEdit.CompanyExist(companyName: companyName))
            Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true).
                     OpenSubKey(name: Resources.reg_Sepanta, writable: true).
                     DeleteSubKeyTree(subkey: companyName);
    }
    public static string[] GetAllApplication(string companyName) =>
        Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true).
                 OpenSubKey(name: Resources.reg_Sepanta, writable: true).
                 OpenSubKey(name: companyName, writable: true).GetSubKeyNames();
    public static bool AppExist(string appName, string companyName) =>
        ClsRegEdit.GetAllApplication(companyName: companyName).Any(predicate: s => s == appName);
    public static bool AddApplication(
        string companyName, string appName, string version,
        string desc) {
        if (!ClsRegEdit.AppExist(appName: appName, companyName: companyName)) {
            Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true).
                     OpenSubKey(name: Resources.reg_Sepanta, writable: true).
                     OpenSubKey(name: companyName, writable: true).CreateSubKey(subkey: appName).
                     SetValue(name: Resources.reg_Description, value: desc,
                              valueKind: RegistryValueKind.String
                             );
            Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true).
                     OpenSubKey(name: Resources.reg_Sepanta, writable: true).
                     OpenSubKey(name: companyName, writable: true).CreateSubKey(subkey: appName).
                     SetValue(name: Resources.reg_Version, value: version,
                              valueKind: RegistryValueKind.String
                             );
            return true;
        }
        return false;
    }
    public static bool RemoveApplication(string selectedCompany, string selectedApplication) {
        if (!ClsRegEdit.AppExist(appName: selectedApplication, companyName: selectedCompany))
            return false;
        Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true).
                 OpenSubKey(name: Resources.reg_Sepanta, writable: true).
                 OpenSubKey(name: selectedCompany,       writable: true).
                 DeleteSubKeyTree(subkey: selectedApplication);
        return true;
    }
    public static string GetAppVersion(string selectedCompany, string selectedApplication) =>
        Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true).
                 OpenSubKey(name: Resources.reg_Sepanta, writable: true).
                 OpenSubKey(name: selectedCompany,       writable: true).
                 OpenSubKey(name: selectedApplication,   writable: true).
                 GetValue(name: Resources.reg_Version).ToString();
    public static string GetAppDesc(string selectedCompany, string selectedApplication) =>
        Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true).
                 OpenSubKey(name: Resources.reg_Sepanta, writable: true).
                 OpenSubKey(name: selectedCompany,       writable: true).
                 OpenSubKey(name: selectedApplication,   writable: true).
                 GetValue(name: Resources.reg_Description).ToString();
    public static bool AppHasConnection(string app, string company) =>
        Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true).
                 OpenSubKey(name: Resources.reg_Sepanta, writable: true).
                 OpenSubKey(name: company, writable: true).OpenSubKey(name: app, writable: true).
                 GetValueNames().Any(predicate: value => value == Resources.reg_CentralConnection);
}