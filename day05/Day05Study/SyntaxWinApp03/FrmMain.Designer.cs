namespace SyntaxWinApp03
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            label1 = new Label();
            TxtLog = new TextBox();
            BtnStart = new Button();
            statusStrip1 = new StatusStrip();
            LblCurrState = new ToolStripStatusLabel();
            Prg01 = new ToolStripProgressBar();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            ㅋㄴㅁㅇToolStripMenuItem = new ToolStripMenuItem();
            toolStripSplitButton1 = new ToolStripSplitButton();
            ㅉㅉToolStripMenuItem = new ToolStripMenuItem();
            ㅋㅋToolStripMenuItem = new ToolStripMenuItem();
            a뭐ToolStripMenuItem = new ToolStripMenuItem();
            뭐임마ToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "로그";
            // 
            // TxtLog
            // 
            TxtLog.Location = new Point(12, 27);
            TxtLog.Multiline = true;
            TxtLog.Name = "TxtLog";
            TxtLog.ScrollBars = ScrollBars.Vertical;
            TxtLog.Size = new Size(560, 225);
            TxtLog.TabIndex = 1;
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(471, 258);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(101, 28);
            BtnStart.TabIndex = 2;
            BtnStart.Text = "시작";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblCurrState, Prg01, toolStripDropDownButton1, toolStripSplitButton1 });
            statusStrip1.Location = new Point(0, 289);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(584, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblCurrState
            // 
            LblCurrState.Name = "LblCurrState";
            LblCurrState.Size = new Size(94, 17);
            LblCurrState.Text = "현재 상태 : 중지";
            // 
            // Prg01
            // 
            Prg01.Name = "Prg01";
            Prg01.Size = new Size(300, 16);
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { ㅋㄴㅁㅇToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(29, 20);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // ㅋㄴㅁㅇToolStripMenuItem
            // 
            ㅋㄴㅁㅇToolStripMenuItem.Name = "ㅋㄴㅁㅇToolStripMenuItem";
            ㅋㄴㅁㅇToolStripMenuItem.Size = new Size(122, 22);
            ㅋㄴㅁㅇToolStripMenuItem.Text = "ㅋㄴㅁㅇ";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { ㅉㅉToolStripMenuItem, ㅋㅋToolStripMenuItem });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(32, 20);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // ㅉㅉToolStripMenuItem
            // 
            ㅉㅉToolStripMenuItem.Name = "ㅉㅉToolStripMenuItem";
            ㅉㅉToolStripMenuItem.Size = new Size(98, 22);
            ㅉㅉToolStripMenuItem.Text = "ㅉㅉ";
            // 
            // ㅋㅋToolStripMenuItem
            // 
            ㅋㅋToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { a뭐ToolStripMenuItem, 뭐임마ToolStripMenuItem });
            ㅋㅋToolStripMenuItem.Name = "ㅋㅋToolStripMenuItem";
            ㅋㅋToolStripMenuItem.Size = new Size(98, 22);
            ㅋㅋToolStripMenuItem.Text = "ㅋㅋ";
            // 
            // a뭐ToolStripMenuItem
            // 
            a뭐ToolStripMenuItem.Name = "a뭐ToolStripMenuItem";
            a뭐ToolStripMenuItem.Size = new Size(110, 22);
            a뭐ToolStripMenuItem.Text = "a뭐";
            // 
            // 뭐임마ToolStripMenuItem
            // 
            뭐임마ToolStripMenuItem.Name = "뭐임마ToolStripMenuItem";
            뭐임마ToolStripMenuItem.Size = new Size(110, 22);
            뭐임마ToolStripMenuItem.Text = "뭐임마";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(statusStrip1);
            Controls.Add(BtnStart);
            Controls.Add(TxtLog);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            Text = "비동기햄";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtLog;
        private Button BtnStart;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LblCurrState;
        private ToolStripProgressBar Prg01;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem ㅋㄴㅁㅇToolStripMenuItem;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem ㅉㅉToolStripMenuItem;
        private ToolStripMenuItem ㅋㅋToolStripMenuItem;
        private ToolStripMenuItem a뭐ToolStripMenuItem;
        private ToolStripMenuItem 뭐임마ToolStripMenuItem;
    }
}
