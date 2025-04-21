namespace SystaxWinApp04
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtAge.Text == "")
            {
                MessageBox.Show("값을 채워주이소!!");
                return;
            }
            else
            {
                // TO DO
                TxtResult.Text = "꾸에엥?";
            }
        }
    }
}
