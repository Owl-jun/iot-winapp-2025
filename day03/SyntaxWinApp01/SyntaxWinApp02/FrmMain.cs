using SyntaxWinApp02.Properties;
using System.Reflection;


namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            switch (CboList.SelectedIndex)
            {
                case 0: // computer
                    Computer Com = new Computer();
                    Pic01.Image = Resources.computer_case;
                    break;
                case 1: // notebook
                    Pic01.Image = Resources.laptop;
                    break;
                case 2: // server
                    Pic01.Image = Resources.server;
                    break;
                default:
                    break;
            }
        }
    }
}
