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
            // ��׶��� ��Ŀ �ʱ�ȭ
            BgwProcess.WorkerReportsProgress = true;

            BgwProcess.DoWork += BgwProcess_DoWork; // ��
            BgwProcess.ProgressChanged += BgwProcess_ProgressChanged;
            BgwProcess.RunWorkerCompleted += BgwProcess_RunWorkerCompleted;

            BtnStart.Click += BtnStart_Click;
        }

        private volatile bool isStart = false;
        private void BtnStart_Click(object? sender, EventArgs e)
        {
            if (isStart)
            {
                LblState.Text = "���� ���� : �ߴ�";
                BtnStart.Text = "����";
                isStart = false;
            }
            else
            { 
                LblState.Text = "���� ���� : ����";
                BtnStart.Text = "�ߴ�";
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
                LblState.Text = $"������� : {progress}%";
            }
            else 
            {
                PrgProcess.Value = 0;
                TxtLog.AppendText("�����Ǿ����ϴ�." + "\r\n");
                TxtLog.SelectionStart = TxtLog.Text.Length;
                TxtLog.ScrollToCaret();
                LblState.Text = "������� : �ߴ�";
            }
        }
        private void BgwProcess_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            PrgProcess.Value = 0;
            TxtLog.AppendText("�Ϸ�Ǿ����ϴ�." + "\r\n");
            LblState.Text = "���� ���� : �ߴ�";
            BtnStart.Text = "����";
            isStart = false;
        }

    }
}
