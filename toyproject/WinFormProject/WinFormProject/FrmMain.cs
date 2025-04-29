using System.Diagnostics;

namespace WinFormProject
{
    public partial class FrmMain : Form
    {
        private bool hIsShow = false;
        private bool tIsShow = false;
        private FrmWindow historyForm;
        private FrmWindow tutorialForm;

        public FrmMain()
        {
            InitializeComponent();
            historyForm = new FrmWindow();
            tutorialForm = new FrmWindow();
            LoadTextFile();
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
            historyForm.AppendHistory(TxtScript.Text);
            string script = GetFullCommand(TxtScript.Text);

            ////
            ////
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


        private void BtnTutor_Click(object sender, EventArgs e)
        {
            if (!hIsShow)
            {
                hIsShow = true;
                historyForm.FormClosed += (s, ev) => hIsShow = false;
                historyForm.StartPosition = FormStartPosition.Manual;
                historyForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                historyForm.Show();
            }
            else
            {
                hIsShow = false;
                historyForm.Hide();
            }
        }

        private void BtnTutor_Click_1(object sender, EventArgs e)
        {
            if (!tIsShow)
            {
                tIsShow = true;
                tutorialForm.FormClosed += (s, ev) => tIsShow = false;
                tutorialForm.StartPosition = FormStartPosition.Manual; // 위치 수동 설정
                tutorialForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                tutorialForm.Show();
            }
            else
            {
                tIsShow = false;
                tutorialForm.Hide();
            }
        }
        private void LoadTextFile()
        {
            string filePath = "Tutorial.txt"; // 텍스트 파일 경로

            if (File.Exists(filePath))
            {
                string text = File.ReadAllText(filePath);
                tutorialForm.AppendText(text);
            }
            else
            {
                MessageBox.Show("파일이 존재하지 않습니다.");
            }
        }

    }
}
