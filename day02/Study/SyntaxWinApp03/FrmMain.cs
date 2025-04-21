namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void Txt통증여부_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show(Txt통증여부.Text, "입력값");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPoint = Cmb통증부위.SelectedItem.ToString();
            MessageBox.Show(selectedPoint, "통증부위");
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            if (Txt통증여부.Text == "아니오")
            {
                MessageBox.Show("집에가이소");
            }
            else
            {
                string PainPoint = Cmb통증부위.SelectedItem.ToString();
                switch (PainPoint)
                {
                    case "머리":
                        MessageBox.Show("신경과 ㄱㄱ", "진료과");
                        break;
                    case "눈":
                        MessageBox.Show("안과 ㄱㄱ", "진료과");
                        break;
                    case "코":
                        MessageBox.Show("이비인후과 ㄱㄱ", "진료과");
                        break;
                    case "목":
                        MessageBox.Show("이비인후과 ㄱㄱ", "진료과");
                        break;
                    case "가슴":
                        MessageBox.Show("내과 ㄱㄱ", "진료과");
                        break;
                    case "배":
                        MessageBox.Show("내과 ㄱㄱ", "진료과");
                        break;
                    default:
                        break;
                }
            }
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            for (int x = 2; x < 10; ++x)
            {
                for (int y = 1; y < 10; ++y)
                {
                    var res = x + " * " + y + " = " + (x * y).ToString();
                    TxtDisplay.AppendText(res + " ");
                }
                TxtDisplay.AppendText(Environment.NewLine);
            }
        }

        int cnum = 0;
        private void BtnWhile_Click(object sender, EventArgs e)
        {
            while(true)
            {
                MessageBox.Show("계속" + cnum);
                if (++cnum >= 10)
                {
                    break;
                }
            }
        }
    }
}
