namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            string[] fruits = { "���", "�ٳ���", "����", "����", "��纣��" };
            CboArray.Items.AddRange(fruits);

            List<string> lFruits = new List<string>();
            foreach (string item in fruits)
            {
                lFruits.Add(item);
            }
            CboList.Items.AddRange(lFruits.ToArray());
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            TxtRes.Text += CboArray.SelectedItem + ", �԰� ���� : " 
                + Cal01.SelectionStart.ToString("yyyy-MM-dd") + "\r\n";

        }

        private void CboArray_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CboList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}
