namespace SepantaDBConnector.Company;
public partial class FrmCompany : Form {
    public FrmCompany() => InitializeComponent();
    public  string SelectedCompany                             { get; set; }
    public  string SelectedCompanyDesc                         { get; set; }
    private void   FrmCompany_Load(object sender, EventArgs e) => lstCompanies.DataSource = ClsRegEdit.GetAllCompanies();
    private void lstCompanies_SelectedIndexChanged(object sender, EventArgs e) {
        if (lstCompanies.SelectedIndex == -1)
            return;
        SelectedCompany            = lstCompanies.SelectedItem.ToString();
        txtCompanyDescription.Text = ClsRegEdit.GetCompanyDescription(companyName: SelectedCompany);
        SelectedCompanyDesc        = txtCompanyDescription.Text;
    }
    private void btnAdd_Click(object sender, EventArgs e) {
        FrmAddCompany frm = new();
        frm.ShowDialog();
        lstCompanies.DataSource = ClsRegEdit.GetAllCompanies();
    }
    private void btnRemove_Click(object sender, EventArgs e) {
        if (MessageBox.Show(text: Resources.AreYouSure, caption: string.Empty, buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Question) ==
            DialogResult.No)
            return;
        if (SelectedCompany is not null)
            ClsRegEdit.RemoveCompany(companyName: SelectedCompany);
        lstCompanies.DataSource = ClsRegEdit.GetAllCompanies();
    }
}