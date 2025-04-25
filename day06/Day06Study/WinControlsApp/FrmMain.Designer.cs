namespace WinControlsApp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            statusStrip1 = new StatusStrip();
            LblState = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            MnuFile = new ToolStripMenuItem();
            MnuSave = new ToolStripMenuItem();
            MnuASave = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            MnuExit = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            BtnItalic = new Button();
            BtnBold = new Button();
            TxtSample = new TextBox();
            CboFonts = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BtnOpenImage = new Button();
            PicImage = new PictureBox();
            groupBox3 = new GroupBox();
            DtpBirth = new DateTimePicker();
            LblURL = new LinkLabel();
            TxtDay = new TextBox();
            TxtMonth = new TextBox();
            TxtYear = new TextBox();
            CalSchedule = new MonthCalendar();
            groupBox4 = new GroupBox();
            LblOpacity = new Label();
            TrbProcess = new TrackBar();
            PrgProcess = new ProgressBar();
            groupBox5 = new GroupBox();
            BtnMsgBox = new Button();
            BtnModalless = new Button();
            BtnModal = new Button();
            groupBox6 = new GroupBox();
            BtnNode = new Button();
            BtnRoot = new Button();
            LsvDummy = new ListView();
            imageList1 = new ImageList(components);
            TrvDummy = new TreeView();
            DlgOpenImage = new OpenFileDialog();
            pictureBox2 = new PictureBox();
            toolTip1 = new ToolTip(components);
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicImage).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrbProcess).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Transparent;
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblState });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1184, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblState
            // 
            LblState.Name = "LblState";
            LblState.Size = new Size(81, 17);
            LblState.Text = "state : normal";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MnuFile });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 23);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            MnuFile.DropDownItems.AddRange(new ToolStripItem[] { MnuSave, MnuASave, toolStripMenuItem1, MnuExit });
            MnuFile.Name = "MnuFile";
            MnuFile.Size = new Size(57, 19);
            MnuFile.Text = "파일(&F)";
            // 
            // MnuSave
            // 
            MnuSave.Name = "MnuSave";
            MnuSave.Size = new Size(269, 22);
            MnuSave.Text = "저장(&S)";
            // 
            // MnuASave
            // 
            MnuASave.Name = "MnuASave";
            MnuASave.Size = new Size(269, 22);
            MnuASave.Text = "다른 이름으로 저장(&Ctrl + Shift + S)";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(266, 6);
            // 
            // MnuExit
            // 
            MnuExit.Name = "MnuExit";
            MnuExit.Size = new Size(269, 22);
            MnuExit.Text = "종료(&X)";
            MnuExit.Click += MnuExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(BtnItalic);
            groupBox1.Controls.Add(BtnBold);
            groupBox1.Controls.Add(TxtSample);
            groupBox1.Controls.Add(CboFonts);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 111);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "일반 컨트롤";
            // 
            // BtnItalic
            // 
            BtnItalic.Anchor = AnchorStyles.Top;
            BtnItalic.Font = new Font("D2Coding", 8.999999F, FontStyle.Italic, GraphicsUnit.Point, 129);
            BtnItalic.Location = new Point(283, 20);
            BtnItalic.Margin = new Padding(1);
            BtnItalic.Name = "BtnItalic";
            BtnItalic.Size = new Size(22, 22);
            BtnItalic.TabIndex = 4;
            BtnItalic.Text = "I";
            BtnItalic.UseVisualStyleBackColor = true;
            BtnItalic.Click += BtnItalic_Click;
            // 
            // BtnBold
            // 
            BtnBold.Font = new Font("D2Coding", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BtnBold.Location = new Point(257, 20);
            BtnBold.Name = "BtnBold";
            BtnBold.Size = new Size(22, 22);
            BtnBold.TabIndex = 4;
            BtnBold.Text = "B";
            BtnBold.UseVisualStyleBackColor = true;
            BtnBold.Click += BtnBold_Click;
            // 
            // TxtSample
            // 
            TxtSample.BackColor = SystemColors.ButtonHighlight;
            TxtSample.Enabled = false;
            TxtSample.Font = new Font("D2Coding", 12F);
            TxtSample.Location = new Point(17, 48);
            TxtSample.Margin = new Padding(6);
            TxtSample.Multiline = true;
            TxtSample.Name = "TxtSample";
            TxtSample.ReadOnly = true;
            TxtSample.Size = new Size(343, 50);
            TxtSample.TabIndex = 3;
            TxtSample.Text = "Sample Text\r\n샘플 문자";
            // 
            // CboFonts
            // 
            CboFonts.FormattingEnabled = true;
            CboFonts.Location = new Point(54, 20);
            CboFonts.Name = "CboFonts";
            CboFonts.Size = new Size(197, 22);
            CboFonts.TabIndex = 1;
            CboFonts.SelectedIndexChanged += CboFonts_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 23);
            label1.Name = "label1";
            label1.Size = new Size(31, 14);
            label1.TabIndex = 0;
            label1.Text = "폰트";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(BtnOpenImage);
            groupBox2.Controls.Add(PicImage);
            groupBox2.Location = new Point(402, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(382, 509);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "픽처박스";
            // 
            // BtnOpenImage
            // 
            BtnOpenImage.Location = new Point(276, 471);
            BtnOpenImage.Name = "BtnOpenImage";
            BtnOpenImage.Size = new Size(100, 30);
            BtnOpenImage.TabIndex = 2;
            BtnOpenImage.Text = "이미지열기";
            BtnOpenImage.UseVisualStyleBackColor = true;
            BtnOpenImage.Click += BtnOpenImage_Click;
            // 
            // PicImage
            // 
            PicImage.BorderStyle = BorderStyle.FixedSingle;
            PicImage.Location = new Point(6, 20);
            PicImage.Name = "PicImage";
            PicImage.Size = new Size(370, 445);
            PicImage.SizeMode = PictureBoxSizeMode.StretchImage;
            PicImage.TabIndex = 0;
            PicImage.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(DtpBirth);
            groupBox3.Controls.Add(LblURL);
            groupBox3.Controls.Add(TxtDay);
            groupBox3.Controls.Add(TxtMonth);
            groupBox3.Controls.Add(TxtYear);
            groupBox3.Controls.Add(CalSchedule);
            groupBox3.Location = new Point(788, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(383, 509);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "기타컨트롤";
            // 
            // DtpBirth
            // 
            DtpBirth.Location = new Point(8, 189);
            DtpBirth.Name = "DtpBirth";
            DtpBirth.Size = new Size(220, 21);
            DtpBirth.TabIndex = 3;
            // 
            // LblURL
            // 
            LblURL.AutoSize = true;
            LblURL.Location = new Point(310, 117);
            LblURL.Name = "LblURL";
            LblURL.Size = new Size(37, 14);
            LblURL.TabIndex = 2;
            LblURL.TabStop = true;
            LblURL.Text = "naver";
            LblURL.LinkClicked += LblURL_LinkClicked;
            // 
            // TxtDay
            // 
            TxtDay.Location = new Point(240, 74);
            TxtDay.Name = "TxtDay";
            TxtDay.Size = new Size(137, 21);
            TxtDay.TabIndex = 1;
            // 
            // TxtMonth
            // 
            TxtMonth.Location = new Point(240, 47);
            TxtMonth.Name = "TxtMonth";
            TxtMonth.Size = new Size(137, 21);
            TxtMonth.TabIndex = 1;
            // 
            // TxtYear
            // 
            TxtYear.Location = new Point(240, 20);
            TxtYear.Name = "TxtYear";
            TxtYear.Size = new Size(137, 21);
            TxtYear.TabIndex = 1;
            // 
            // CalSchedule
            // 
            CalSchedule.FirstDayOfWeek = Day.Monday;
            CalSchedule.Location = new Point(8, 20);
            CalSchedule.Name = "CalSchedule";
            CalSchedule.TabIndex = 0;
            CalSchedule.DateChanged += CalSchedule_DateChanged;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(LblOpacity);
            groupBox4.Controls.Add(TrbProcess);
            groupBox4.Controls.Add(PrgProcess);
            groupBox4.Location = new Point(16, 144);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(383, 103);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "투명도조절";
            // 
            // LblOpacity
            // 
            LblOpacity.AutoSize = true;
            LblOpacity.Location = new Point(329, 79);
            LblOpacity.Name = "LblOpacity";
            LblOpacity.Size = new Size(31, 14);
            LblOpacity.TabIndex = 2;
            LblOpacity.Text = "100%";
            // 
            // TrbProcess
            // 
            TrbProcess.Location = new Point(17, 20);
            TrbProcess.Maximum = 100;
            TrbProcess.Minimum = 40;
            TrbProcess.Name = "TrbProcess";
            TrbProcess.Size = new Size(343, 45);
            TrbProcess.TabIndex = 1;
            TrbProcess.Value = 100;
            TrbProcess.Scroll += TrbProcess_Scroll;
            // 
            // PrgProcess
            // 
            PrgProcess.Location = new Point(17, 53);
            PrgProcess.MarqueeAnimationSpeed = 0;
            PrgProcess.Minimum = 40;
            PrgProcess.Name = "PrgProcess";
            PrgProcess.Size = new Size(343, 23);
            PrgProcess.Step = 1;
            PrgProcess.TabIndex = 0;
            PrgProcess.Value = 100;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Transparent;
            groupBox5.Controls.Add(BtnMsgBox);
            groupBox5.Controls.Add(BtnModalless);
            groupBox5.Controls.Add(BtnModal);
            groupBox5.Location = new Point(16, 253);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(383, 85);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "모달, 모달리스";
            // 
            // BtnMsgBox
            // 
            BtnMsgBox.Location = new Point(259, 20);
            BtnMsgBox.Name = "BtnMsgBox";
            BtnMsgBox.Size = new Size(118, 57);
            BtnMsgBox.TabIndex = 0;
            BtnMsgBox.Text = "MessageBox";
            BtnMsgBox.UseVisualStyleBackColor = true;
            BtnMsgBox.Click += BtnMsgBox_Click;
            // 
            // BtnModalless
            // 
            BtnModalless.Location = new Point(133, 20);
            BtnModalless.Name = "BtnModalless";
            BtnModalless.Size = new Size(118, 57);
            BtnModalless.TabIndex = 0;
            BtnModalless.Text = "Modalless";
            BtnModalless.UseVisualStyleBackColor = true;
            BtnModalless.Click += BtnModalless_Click;
            // 
            // BtnModal
            // 
            BtnModal.Location = new Point(6, 20);
            BtnModal.Name = "BtnModal";
            BtnModal.Size = new Size(118, 57);
            BtnModal.TabIndex = 0;
            BtnModal.Text = "Modal";
            BtnModal.UseVisualStyleBackColor = true;
            BtnModal.Click += BtnModal_Click;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.Transparent;
            groupBox6.Controls.Add(BtnNode);
            groupBox6.Controls.Add(BtnRoot);
            groupBox6.Controls.Add(LsvDummy);
            groupBox6.Controls.Add(TrvDummy);
            groupBox6.Location = new Point(16, 344);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(383, 192);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "트리뷰, 리스트뷰";
            // 
            // BtnNode
            // 
            BtnNode.Location = new Point(277, 154);
            BtnNode.Name = "BtnNode";
            BtnNode.Size = new Size(100, 30);
            BtnNode.TabIndex = 2;
            BtnNode.Text = "노드추가";
            BtnNode.UseVisualStyleBackColor = true;
            BtnNode.Click += BtnNode_Click;
            // 
            // BtnRoot
            // 
            BtnRoot.Location = new Point(171, 154);
            BtnRoot.Name = "BtnRoot";
            BtnRoot.Size = new Size(100, 30);
            BtnRoot.TabIndex = 2;
            BtnRoot.Text = "루트추가";
            BtnRoot.UseVisualStyleBackColor = true;
            BtnRoot.Click += BtnRoot_Click;
            // 
            // LsvDummy
            // 
            LsvDummy.LargeImageList = imageList1;
            LsvDummy.Location = new Point(197, 20);
            LsvDummy.Name = "LsvDummy";
            LsvDummy.Size = new Size(180, 128);
            LsvDummy.SmallImageList = imageList1;
            LsvDummy.TabIndex = 1;
            LsvDummy.UseCompatibleStateImageBehavior = false;
            LsvDummy.View = View.SmallIcon;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "folder-normal.png");
            // 
            // TrvDummy
            // 
            TrvDummy.ImageIndex = 0;
            TrvDummy.ImageList = imageList1;
            TrvDummy.Location = new Point(6, 20);
            TrvDummy.Name = "TrvDummy";
            TrvDummy.SelectedImageIndex = 0;
            TrvDummy.Size = new Size(185, 128);
            TrvDummy.TabIndex = 0;
            // 
            // DlgOpenImage
            // 
            DlgOpenImage.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.kiss;
            pictureBox2.Location = new Point(790, 286);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1184, 561);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox6);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("D2Coding", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UI컨트롤예제 윈앱";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicImage).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrbProcess).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ToolStripMenuItem MnuFile;
        private ToolStripMenuItem MnuSave;
        private ToolStripMenuItem MnuASave;
        private TextBox TxtSample;
        private ComboBox CboFonts;
        private Label label1;
        private Button BtnItalic;
        private Button BtnBold;
        private ToolStripStatusLabel LblState;
        private GroupBox groupBox4;
        private TrackBar TrbProcess;
        private ProgressBar PrgProcess;
        private Label LblOpacity;
        private GroupBox groupBox5;
        private Button BtnMsgBox;
        private Button BtnModalless;
        private Button BtnModal;
        private GroupBox groupBox6;
        private Button BtnNode;
        private Button BtnRoot;
        private ListView LsvDummy;
        private TreeView TrvDummy;
        private ImageList imageList1;
        private Button BtnOpenImage;
        private PictureBox PicImage;
        private OpenFileDialog DlgOpenImage;
        private PictureBox pictureBox2;
        private DateTimePicker DtpBirth;
        private LinkLabel LblURL;
        private TextBox TxtDay;
        private TextBox TxtMonth;
        private TextBox TxtYear;
        private MonthCalendar CalSchedule;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem MnuExit;
        private ToolTip toolTip1;
    }
}
