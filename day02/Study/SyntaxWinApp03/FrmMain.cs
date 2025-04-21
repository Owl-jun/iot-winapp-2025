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

        private void Txt��������_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show(Txt��������.Text, "�Է°�");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPoint = Cmb��������.SelectedItem.ToString();
            MessageBox.Show(selectedPoint, "��������");
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            if (Txt��������.Text == "�ƴϿ�")
            {
                MessageBox.Show("�������̼�");
            }
            else
            {
                string PainPoint = Cmb��������.SelectedItem.ToString();
                switch (PainPoint)
                {
                    case "�Ӹ�":
                        MessageBox.Show("�Ű�� ����", "�����");
                        break;
                    case "��":
                        MessageBox.Show("�Ȱ� ����", "�����");
                        break;
                    case "��":
                        MessageBox.Show("�̺����İ� ����", "�����");
                        break;
                    case "��":
                        MessageBox.Show("�̺����İ� ����", "�����");
                        break;
                    case "����":
                        MessageBox.Show("���� ����", "�����");
                        break;
                    case "��":
                        MessageBox.Show("���� ����", "�����");
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
                MessageBox.Show("���" + cnum);
                if (++cnum >= 10)
                {
                    break;
                }
            }
        }
    }
}
