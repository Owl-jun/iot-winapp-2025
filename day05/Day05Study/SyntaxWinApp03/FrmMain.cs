using System;

namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private async void BtnStart_Click(object sender, EventArgs e)
        {
            LblCurrState.Text = "현재상태 : 진행";
            BtnStart.Text = "진행중";
            BtnStart.Enabled = false;
            
            long MaxVal = 200;
            long total = 0;
            Prg01.Minimum = 0;
            Prg01.Maximum = 100;

            //for (int i = 0; i < MaxVal; i++)
            //{
            //    total += i % 3;
            //    int progress = (int)((i * 100) / MaxVal) + 1;
            //    TxtLog.Text = "현재 진행률 : " + progress.ToString();
            //    Prg01.Value = progress;
            //    Thread.Sleep(50);
            //}

            // await 사용
            await Task.Run(() =>
            {
                for (long i = 0; i < MaxVal; i++)
                {
                    total += i % 3;
                    int progress = (int)((i * 100) / MaxVal) + 1;
                    this.Invoke(() => TxtLog.Text = "현재 진행률 : " + progress.ToString());
                    this.Invoke(() => Prg01.Value = progress);
                    Thread.Sleep(50);
                }
            });
            Prg01.Value = 0;

            LblCurrState.Text = "현재상태 : 중지";
            BtnStart.Text = "시작";
            BtnStart.Enabled = true;
        }
    }
}
