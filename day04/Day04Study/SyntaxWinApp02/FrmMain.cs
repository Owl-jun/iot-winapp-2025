using System.Linq;

namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            string[] fruits = { "���", "�ٳ���", "����", "����", "��纣��" };
            CboArray.Items.AddRange(fruits);

            List<string> lFruits = new List<string>()
            {
                "��ġ", "�˵�ġ","�˻�ġ","�˻�ġ","�˿�ġ"
            };
            CboList.DataSource = lFruits;

            Dictionary<string, string> dCountry = new Dictionary<string, string>()
            {
                {"KR","���ѹα�" },
                {"US","�̱�" },
                {"JP","�Ϻ�" },
                {"CN","�߱�" },
                {"UK","����" }
            };
            CmbDict.DataSource = new BindingSource(dCountry,null);
            CmbDict.DisplayMember = "Value";
            CmbDict.ValueMember = "Key";
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            TxtRes.Text += CboArray.SelectedItem + ", �԰� ���� : " 
                + Cal01.SelectionStart.ToString("yyyy-MM-dd") + "\r\n"
                + "������ : " + CmbDict.SelectedItem + 
                " ����� : " + CboList.SelectedItem +  "\r\n";
        }

        private void CboArray_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CboList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}
