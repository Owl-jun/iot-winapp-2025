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
            LblCurrState.Text = "������� : ����";
            BtnStart.Text = "������";
            BtnStart.Enabled = false;
            
            long MaxVal = 200;
            long total = 0;
            Prg01.Minimum = 0;
            Prg01.Maximum = 100;

            //for (int i = 0; i < MaxVal; i++)
            //{
            //    total += i % 3;
            //    int progress = (int)((i * 100) / MaxVal) + 1;
            //    TxtLog.Text = "���� ����� : " + progress.ToString();
            //    Prg01.Value = progress;
            //    Thread.Sleep(50);
            //}

            // await ���
            await Task.Run(() =>
            {
                for (long i = 0; i < MaxVal; i++)
                {
                    total += i % 3;
                    int progress = (int)((i * 100) / MaxVal) + 1;
                    this.Invoke(() => TxtLog.Text = "���� ����� : " + progress.ToString());
                    this.Invoke(() => Prg01.Value = progress);
                    Thread.Sleep(50);
                }
            });
            Prg01.Value = 0;

            LblCurrState.Text = "������� : ����";
            BtnStart.Text = "����";
            BtnStart.Enabled = true;
        }
    }
}
