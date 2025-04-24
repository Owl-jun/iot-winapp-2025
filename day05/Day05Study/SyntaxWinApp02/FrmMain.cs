using System.Linq;

namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            TxtTest.Font = new Font("ÇÑÄÄ ¸»¶û¸»¶û", 16, FontStyle.Italic);
        }
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            Func<int, int, int> add = (x, y) => x + y;
            TxtLog.Text += add(10, 5).ToString();
            
            Action<string> sayHi = name => { MessageBox.Show($"{name} ÀÔ´Ï´Ù.\r\n"); };
            sayHi("¤»¤»");

            
            List<int> resList = new List<int>();
            List<int> numbers = [4, 10, 1, 5, 9, 8, 6, 2, 3, 7];

            // LINQ
            resList.AddRange(from int n in numbers
                             where n % 2 == 0
                             orderby n
                             select n);

            TxtLog.Text = string.Join(", ",resList);


            var resList2 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
            TxtLog.Text += "\r\n";
            TxtLog.Text += string.Join(", ", resList2);
        }
    }
}
