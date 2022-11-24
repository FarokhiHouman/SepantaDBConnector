namespace SepantaDBConnector;
public partial class FrmMain : Form {
    public FrmMain() => InitializeComponent();
    private void companyToolStripMenuItem_Click(object sender, EventArgs e) {
        FrmCompany frm = new();
        frm.MdiParent = this;
        frm.Show();
    }
    private void FrmMain_Load(object sender, EventArgs e) {
        if (!ClsRegEdit.SepantaExist())
            Registry.CurrentUser.OpenSubKey(name: Resources.reg_Software, writable: true)?.
                     CreateSubKey(subkey: Resources.reg_Sepanta);
    }
    private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Close();
    private void applicationToolStripMenuItem_Click(object sender, EventArgs e) {
        FrmApp frm = new();
        frm.MdiParent = this;
        frm.Show();
    }
    private void connectionToolStripMenuItem_Click(object sender, EventArgs e) {
        FrmConnection frm = new();
        frm.MdiParent = this;
        frm.Show();
    }
}