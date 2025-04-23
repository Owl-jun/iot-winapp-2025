using SyntaxWinApp01.Properties;

namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            try
            {
                Person bojung = new Person(
                    TxtName.Text.Trim(),
                    Convert.ToInt32(NudAge.Value.ToString()),
                    Convert.ToChar(TxtGender.Text.Trim()),
                    TxtPhone.Text
                    );
                bojung.GetUp();
                bojung.GoToSchool();
                TxtRes.Text += bojung.ToString();
                if (bojung.Gender == 'M')
                {
                    if (bojung.Age > 50)
                    {
                        pictureBox1.Image = Resources.old_man;
                    }
                    else if (bojung.Age < 20)
                    {
                        pictureBox1.Image = Resources.boy;
                    }
                    else
                    {
                        pictureBox1.Image = Resources.man;
                    }
                }
                else
                {
                    if (bojung.Age > 50)
                    {
                        pictureBox1.Image = Resources.old_woman;
                    }
                    else if (bojung.Age < 20)
                    {
                        pictureBox1.Image = Resources.girl;
                    }
                    else
                    {
                        pictureBox1.Image = Resources.woman;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                    , "입력오류"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return;
            }
        }
    }
}
