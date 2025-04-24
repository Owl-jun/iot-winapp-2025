namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            RtbMsg.Text += "1. Æû»ý¼ºÀÚ ½ÇÇà \r\n";
        }
        private void FrmMain_Load(object sender, EventArgs e) {
            RtbMsg.Text += "2. Æû·Îµå ½ÇÇà \r\n";
        }
        private void FrmMain_Activated(object sender, EventArgs e) {
            RtbMsg.Text += "3. Æû¾×Æ¼º£ÀÌÆ® ½ÇÇà \r\n";
        }
        private void FrmMain_Shown(object sender, EventArgs e) {
            RtbMsg.Text += "4. Æû¼î¿î ½ÇÇà \r\n";
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) { }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e) { }

    }
}
