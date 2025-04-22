namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click (object sender, EventArgs e)
        {
            Person hugo = new Person(
                txtName.Text.Trim()
                ,int.Parse(TxtAge.Text.Trim())
                ,char.Parse(TxtSex.Text.Trim())
                ,TxtPhone.Text.Trim());

            TxtRes.Text += hugo.ToString();
            hugo.GetUp();
            hugo.GoToSchool();
        }
    }
}
