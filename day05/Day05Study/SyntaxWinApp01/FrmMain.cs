namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            RtbMsg.Text += "1. �������� ���� \r\n";
        }
        private void FrmMain_Load(object sender, EventArgs e) {
            RtbMsg.Text += "2. ���ε� ���� \r\n";
        }
        private void FrmMain_Activated(object sender, EventArgs e) {
            RtbMsg.Text += "3. ����Ƽ����Ʈ ���� \r\n";
        }
        private void FrmMain_Shown(object sender, EventArgs e) {
            RtbMsg.Text += "4. ����� ���� \r\n";
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) { }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e) { }

    }
}
