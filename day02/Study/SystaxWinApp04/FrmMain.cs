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
                MessageBox.Show("���� ä�����̼�!!");
                return;
            }
            else
            {
                // TO DO
                LblResult.Text = "ó�� ��� : ";
                //TxtResult.Text = "�ٿ���?";

                string name = TxtName.Text.Trim();
                DateTime birth = DateTime.Parse(TxtAge.Text.Trim());
                int age = (DateTime.Now.Year - birth.Year);
                string gender = RdoMale.Checked ? "��" : "��";
                TxtResult.Text += "�̸� : " + name + "\r\n";
                TxtResult.Text += "���� : " + age + "\r\n";
                TxtResult.Text += "������� : " + birth + "\r\n";
                TxtResult.Text += "���� : " + gender + "\r\n";
                
                TxtResult.Text = $"���� {name} �̰�, {birth:yyyy-mm-dd} �� �¾ {age}�� {gender}�� �Դϴ�.";
            }
        }
    }
}
