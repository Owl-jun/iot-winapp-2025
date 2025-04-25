using System;
using System.ComponentModel;

namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 백그라운드 워커 초기화
            BgwProcess.WorkerReportsProgress = true;

            BgwProcess.DoWork += BgwProcess_DoWork; // 뷁
            BgwProcess.ProgressChanged += BgwProcess_ProgressChanged;
            BgwProcess.RunWorkerCompleted += BgwProcess_RunWorkerCompleted;

            BtnStart.Click += BtnStart_Click;
        }

        private volatile bool isStart = false;
        private void BtnStart_Click(object? sender, EventArgs e)
        {
            if (isStart)
            {
                LblState.Text = "현재 상태 : 중단";
                BtnStart.Text = "시작";
                isStart = false;
            }
            else
            { 
                LblState.Text = "현재 상태 : 진행";
                BtnStart.Text = "중단";
                isStart = true;
            }
            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = 100;

            if (!BgwProcess.IsBusy)
                BgwProcess.RunWorkerAsync();

        }
        private void BgwProcess_DoWork(object? sender, DoWorkEventArgs e)
        {
            long MaxVal = 200;
            long total = 0;

            for (int i = 0; i < MaxVal; ++i)
            {
                if (!isStart)
                {
                    BgwProcess.ReportProgress(0, -1);    
                    return;
                }
                total += i % 3;
                int progress = (int)(i * 100 / MaxVal) + 1;
                BgwProcess.ReportProgress(progress, i);
                Thread.Sleep(50);
            }
        }
        private void BgwProcess_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            int progress = e.ProgressPercentage;
            int currVal = (int)e.UserState;

            if (currVal != -1)
            {
                PrgProcess.Value = progress;
                TxtLog.AppendText(currVal.ToString() + "\r\n");
                TxtLog.SelectionStart = TxtLog.Text.Length;
                TxtLog.ScrollToCaret();
                LblState.Text = $"현재상태 : {progress}%";
            }
            else 
            {
                PrgProcess.Value = 0;
                TxtLog.AppendText("중지되었습니다." + "\r\n");
                TxtLog.SelectionStart = TxtLog.Text.Length;
                TxtLog.ScrollToCaret();
                LblState.Text = "현재상태 : 중단";
            }
        }
        private void BgwProcess_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            PrgProcess.Value = 0;
            TxtLog.AppendText("완료되었습니다." + "\r\n");
            LblState.Text = "현재 상태 : 중단";
            BtnStart.Text = "시작";
            isStart = false;
        }

    }
}
