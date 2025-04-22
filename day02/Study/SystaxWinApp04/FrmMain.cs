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
                LblResult.Text = "처리 결과 : ";
                //TxtResult.Text = "꾸에엥?";

                string name = TxtName.Text.Trim();
                DateTime birth = DateTime.Parse(TxtAge.Text.Trim());
                int age = (DateTime.Now.Year - birth.Year);
                string gender = RdoMale.Checked ? "남" : "여";
                TxtResult.Text += "이름 : " + name + "\r\n";
                TxtResult.Text += "나이 : " + age + "\r\n";
                TxtResult.Text += "생년월일 : " + birth + "\r\n";
                TxtResult.Text += "성별 : " + gender + "\r\n";
                
                TxtResult.Text = $"저는 {name} 이고, {birth:yyyy-mm-dd} 에 태어난 {age}살 {gender}자 입니다.";
            }
        }
    }
}
