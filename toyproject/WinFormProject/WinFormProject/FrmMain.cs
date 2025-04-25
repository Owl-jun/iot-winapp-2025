using System.Diagnostics;

namespace WinFormProject
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private string currentDir = "/home/ubuntu";

        private string GetFullCommand(string userInput)
        {
            if (userInput.StartsWith("cd "))
            {
                var target = userInput.Substring(3).Trim();

                if (target == "..")
                    currentDir = Path.GetDirectoryName(currentDir.Replace('/', '\\')).Replace('\\', '/');
                else if (target.StartsWith("/"))
                    currentDir = target;  // ������
                else
                    currentDir += "/" + target;  // �����

                return null; // cd ����� ���� ����
            }

            return $"bash -c \"cd {currentDir} && {userInput}\"";
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            string script = GetFullCommand(TxtScript.Text);

            ////
            ////
            ////
            // historyForm.AppendHistory(script);   ��ũ��Ʈ �����丮�� ���� �ϱ� ���� �ذ��� ��.
            ////
            ////
            ////
            if (script == null)
            {
                TxtResult.Text = $"���͸� �̵���: {currentDir}";
                return;
            }

            string tempFile = Path.GetTempFileName() + ".sh";
            File.WriteAllText(tempFile, script);
            string linuxPath = $"/mnt/{tempFile[0].ToString().ToLower()}/{tempFile.Substring(3).Replace('\\', '/')}";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "wsl.exe",
                Arguments = $"bash -c \"chmod +x {currentDir} && {script}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            var proc = new Process { StartInfo = psi };
            proc.Start();
            string output = proc.StandardOutput.ReadToEnd();
            string error = proc.StandardError.ReadToEnd();
            string clean = output.Replace("\r", "").Replace("\n", "\r\n");
            proc.WaitForExit();

            TxtResult.Text = string.IsNullOrWhiteSpace(error) ? clean : error;
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            TxtScript.KeyDown += TxtScript_KeyDown;
        }
        private void TxtScript_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                BtnProcess.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            float value = (float)numericUpDown1.Value;
            TxtScript.Font = new Font(TxtScript.Font.FontFamily, value);
            TxtResult.Font = new Font(TxtScript.Font.FontFamily, value);
        }

        private bool isShow = false;
        private FrmTutorial historyForm;  
        private void BtnTutor_Click(object sender, EventArgs e)
        {
            if (!isShow)
            {
                historyForm = new FrmTutorial();  // �� ���� ����
                isShow = true;
                historyForm.FormClosed += (s, ev) => isShow = false;  // ����ڰ� ���� �ݾ��� ��쵵 ���
                historyForm.Show();
            }
            else
            {
                isShow = false;
                historyForm.Close();
            }
        }

    }
}
