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
                    currentDir = target;  // 절대경로
                else
                    currentDir += "/" + target;  // 상대경로

                return null; // cd 명령은 실행 안함
            }

            return $"bash -c \"cd {currentDir} && {userInput}\"";
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            string script = GetFullCommand(TxtScript.Text);

            ////
            ////
            ////
            // historyForm.AppendHistory(script);   스크립트 히스토리에 저장 하기 문제 해결할 것.
            ////
            ////
            ////
            if (script == null)
            {
                TxtResult.Text = $"디렉터리 이동됨: {currentDir}";
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
                historyForm = new FrmTutorial();  // 한 번만 생성
                isShow = true;
                historyForm.FormClosed += (s, ev) => isShow = false;  // 사용자가 직접 닫았을 경우도 대비
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
