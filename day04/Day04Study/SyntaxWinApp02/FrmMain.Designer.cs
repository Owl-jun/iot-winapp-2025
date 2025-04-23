namespace SyntaxWinApp02
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
            BtnMsg = new Button();
            imageList1 = new ImageList(components);
            Cal01 = new MonthCalendar();
            TxtRes = new TextBox();
            label1 = new Label();
            CboArray = new ComboBox();
            label2 = new Label();
            CboList = new ComboBox();
            SuspendLayout();
            // 
            // BtnMsg
            // 
            BtnMsg.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnMsg.ImageAlign = ContentAlignment.MiddleLeft;
            BtnMsg.ImageIndex = 0;
            BtnMsg.ImageList = imageList1;
            BtnMsg.Location = new Point(472, 259);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Padding = new Padding(12, 0, 0, 0);
            BtnMsg.Size = new Size(100, 40);
            BtnMsg.TabIndex = 0;
            BtnMsg.Text = "체크";
            BtnMsg.UseVisualStyleBackColor = true;
            BtnMsg.Click += BtnMsg_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "add.png");
            // 
            // Cal01
            // 
            Cal01.Location = new Point(18, 8);
            Cal01.Name = "Cal01";
            Cal01.TabIndex = 1;
            // 
            // TxtRes
            // 
            TxtRes.Location = new Point(250, 8);
            TxtRes.Multiline = true;
            TxtRes.Name = "TxtRes";
            TxtRes.Size = new Size(322, 245);
            TxtRes.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 179);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 3;
            label1.Text = "배열로 할당";
            // 
            // CboArray
            // 
            CboArray.FormattingEnabled = true;
            CboArray.Location = new Point(95, 176);
            CboArray.Name = "CboArray";
            CboArray.Size = new Size(121, 23);
            CboArray.TabIndex = 4;
            CboArray.SelectedIndexChanged += CboArray_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 208);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 3;
            label2.Text = "리스트 할당";
            // 
            // CboList
            // 
            CboList.FormattingEnabled = true;
            CboList.Location = new Point(95, 205);
            CboList.Name = "CboList";
            CboList.Size = new Size(121, 23);
            CboList.TabIndex = 4;
            CboList.SelectedIndexChanged += CboList_SelectedIndexChanged;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images;
            ClientSize = new Size(584, 311);
            Controls.Add(CboList);
            Controls.Add(label2);
            Controls.Add(CboArray);
            Controls.Add(label1);
            Controls.Add(TxtRes);
            Controls.Add(Cal01);
            Controls.Add(BtnMsg);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "컬렉션 학습 윈앱";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnMsg;
        private MonthCalendar Cal01;
        private TextBox TxtRes;
        private Label label1;
        private ComboBox CboArray;
        private ImageList imageList1;
        private Label label2;
        private ComboBox CboList;
    }
}
