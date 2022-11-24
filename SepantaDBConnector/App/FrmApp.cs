namespace SepantaDBConnector.App;
public partial class FrmApp : Form {
    public FrmApp() => InitializeComponent();
    public string SelectedCompany     { get; set; }
    public string SelectedApplication { get; set; }
    private void FrmApp_Load(object sender, EventArgs e) {
        lstCompanies.DataSource = ClsRegEdit.GetAllCompanies();
        lstApp.DataSource       = ClsRegEdit.GetAllApplication(companyName: SelectedCompany);
    }
    private void lstCompanies_SelectedIndexChanged(object sender, EventArgs e) {
        SelectedCompany   = lstCompanies.SelectedItem.ToString();
        lstApp.DataSource = ClsRegEdit.GetAllApplication(companyName: SelectedCompany);
    }
    private void btnAdd_Click(object sender, EventArgs e) {
        if (lstCompanies.SelectedIndex == -1) {
            MessageBox.Show(text: Resources.NameEmpty, caption: string.Empty,
                            buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error
                           );
            btnAdd.Focus();
            return;
        }
        FrmAddApp frm = new(companyName: lstCompanies.SelectedItem.ToString());
        frm.ShowDialog();
        FrmApp_Load(sender: sender, e: e);
    }
    private void btnRemove_Click(object sender, EventArgs e) {
        if (SelectedApplication == string.Empty) {
            MessageBox.Show(text: Resources.NameEmpty, caption: "",
                            buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error
                           );
            return;
        }
        if (MessageBox.Show(text: Resources.AreYouSure, caption: "",
                            buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Question
                           ) == DialogResult.No)
            return;
        if (!ClsRegEdit.RemoveApplication(selectedCompany: SelectedCompany,
                                          selectedApplication: SelectedApplication
                                         ))
            return;
        FrmApp_Load(sender: sender, e: e);
    }
    private void lstApp_SelectedIndexChanged(object sender, EventArgs e) {
        SelectedApplication = lstApp.SelectedItem.ToString();
        txtAppVersion.Text = ClsRegEdit.GetAppVersion(selectedCompany: SelectedCompany,
                                                      selectedApplication: SelectedApplication
                                                     );
        txtAppDescription.Text = ClsRegEdit.GetAppDesc(selectedCompany: SelectedCompany,
                                                       selectedApplication: SelectedApplication
                                                      );
    }
}