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
            // string filePath = "sample.txt"; // ���� ����
            DlgSave.FileName = "";
            DlgSave.Filter = "RTF���� (*.rtf)|*.rtf|txt���� (*.txt)|*.txt";
            DlgSave.Title = "���� ����";
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
                    MessageBox.Show($"���� ���� : {ex.Message}", "���� ����"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            // string filePath = "sample.txt"; // �о�� ����
            DlgOpen.FileName = "";
            DlgOpen.Filter = "RTF���� (*.rtf)|*.rtf|txt���� (*.txt)|*.txt";
            DlgOpen.Title = "���� ����";

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
                    MessageBox.Show($"�б� ���� : {ex.Message}", "���� �б�",
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
                    MessageBox.Show("������ �ؽ�Ʈ�� ����� ��Ʈ�� ��ġ���� �ʽ��ϴ�.", "���");
                    return;
                }

                FontStyle newStyle = currFont.Bold
                    ? currFont.Style & ~FontStyle.Bold
                    : currFont.Style | FontStyle.Bold;

                Rtb01.SelectionFont = new Font(currFont, newStyle);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"����: {ex.Message}");
            }
        }

    }
}
