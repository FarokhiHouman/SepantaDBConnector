namespace SepantaDBConnector.Company;
public partial class FrmAddCompany : Form {
    public FrmAddCompany() {
        InitializeComponent();
        txtCompanyName.Focus();
    }
    private void btnCancel_Click(object sender, EventArgs e) => Close();
    private void btnOk_Click(object sender, EventArgs e) {
        if (txtCompanyName.Text.Trim() == "") {
            MessageBox.Show(text: Resources.NameEmpty, caption: Resources.CantCreate,
                            buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Hand
                           );
            txtCompanyName.Focus();
        }
        else {
            if (ClsRegEdit.CreateCompany(companyName: txtCompanyName.Text,
                                         companyDesc: txtCompanyDesc.Text
                                        )) {
                MessageBox.Show(text: Resources.CreatedSucces,
                                caption: Resources.Created + txtCompanyName.Text,
                                buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Asterisk
                               );
                Close();
            }
            else {
                MessageBox.Show(text: Resources.CantCreate + txtCompanyName,
                                caption: Resources.CantCreate, buttons: MessageBoxButtons.OK,
                                icon: MessageBoxIcon.Asterisk
                               );
                txtCompanyName.Focus();
            }
        }
    }
}