namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        private string filePath = "sample.rtf";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // string filePath = "sample.txt"; // 파일 저장
            DlgSave.FileName = "";
            DlgSave.Filter = "RTF파일 (*.rtf)|*.rtf|txt파일 (*.txt)|*.txt";
            DlgSave.Title = "파일 열기";
            if (DlgSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fullPath = DlgSave.FileName;
                    string ext = Path.GetExtension(fullPath);
                    if (ext == ".rtf")
                    {
                        Rtb01.SaveFile(fullPath, RichTextBoxStreamType.RichText);
                    }
                    else if (ext == ".txt")
                    {
                        Rtb01.SaveFile(fullPath, RichTextBoxStreamType.PlainText);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"저장 실패 : {ex.Message}", "파일 저장"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            // string filePath = "sample.txt"; // 읽어올 파일
            DlgOpen.FileName = "";
            DlgOpen.Filter = "RTF파일 (*.rtf)|*.rtf|txt파일 (*.txt)|*.txt";
            DlgOpen.Title = "파일 열기";

            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fullPath = DlgOpen.FileName;
                    string ext = Path.GetExtension(fullPath);
                    if (ext == ".rtf")
                    {
                        Rtb01.LoadFile(DlgOpen.FileName, RichTextBoxStreamType.RichText);
                    }
                    else if (ext == ".txt")
                    {
                        Rtb01.LoadFile(DlgOpen.FileName, RichTextBoxStreamType.PlainText);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"읽기 실패 : {ex.Message}", "파일 읽기",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            if (Rtb01.SelectionLength > 0)
            {
                if (DlgColor.ShowDialog() == DialogResult.OK)
                {
                    Rtb01.SelectionColor = DlgColor.Color;
                    BtnRed.BackColor = DlgColor.Color;
                    BtnRed.ForeColor = DlgColor.Color;
                }
            }
        }
        private void BtnBold_Click(object sender, EventArgs e)
        {
            try
            {
                Font currFont = Rtb01.SelectionFont;
                if (currFont == null)
                {
                    // currFont = Rtb01.Font;
                    MessageBox.Show("선택한 텍스트에 적용된 폰트가 일치하지 않습니다.", "경고");
                    return;
                }

                FontStyle newStyle = currFont.Bold
                    ? currFont.Style & ~FontStyle.Bold
                    : currFont.Style | FontStyle.Bold;

                Rtb01.SelectionFont = new Font(currFont, newStyle);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류: {ex.Message}");
            }
        }

    }
}
