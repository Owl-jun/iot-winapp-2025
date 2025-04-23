using System.Linq;

namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            string[] fruits = { "사과", "바나나", "딸기", "망고", "블루베리" };
            CboArray.Items.AddRange(fruits);

            List<string> lFruits = new List<string>()
            {
                "검치", "검둘치","검삼치","검사치","검오치"
            };
            CboList.DataSource = lFruits;

            Dictionary<string, string> dCountry = new Dictionary<string, string>()
            {
                {"KR","대한민국" },
                {"US","미국" },
                {"JP","일본" },
                {"CN","중국" },
                {"UK","영국" }
            };
            CmbDict.DataSource = new BindingSource(dCountry,null);
            CmbDict.DisplayMember = "Value";
            CmbDict.ValueMember = "Key";
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            TxtRes.Text += CboArray.SelectedItem + ", 입고 일자 : " 
                + Cal01.SelectionStart.ToString("yyyy-MM-dd") + "\r\n"
                + "원산지 : " + CmbDict.SelectedItem + 
                " 담당자 : " + CboList.SelectedItem +  "\r\n";
        }

        private void CboArray_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CboList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}
