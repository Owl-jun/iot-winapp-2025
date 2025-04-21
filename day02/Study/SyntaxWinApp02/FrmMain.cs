namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            int val = 2 ^ 5;    // XOR ¿¬»êÀÚ
            MessageBox.Show(((3 > 2)&&(10 < 9)).ToString());
        }
    }
}
