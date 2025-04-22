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
            button1 = new Button();
            ImlForm = new ImageList(components);
            label1 = new Label();
            Pic01 = new PictureBox();
            CboList = new ComboBox();
            imgimg = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)Pic01).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 0;
            button1.ImageList = ImlForm;
            button1.Location = new Point(475, 241);
            button1.Name = "button1";
            button1.Size = new Size(147, 58);
            button1.TabIndex = 0;
            button1.Text = "밖에비온다 주룩주룩";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ImlForm
            // 
            ImlForm.ColorDepth = ColorDepth.Depth24Bit;
            ImlForm.ImageStream = (ImageListStreamer)resources.GetObject("ImlForm.ImageStream");
            ImlForm.TransparentColor = Color.Transparent;
            ImlForm.Images.SetKeyName(0, "..png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(464, 12);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "종류";
            // 
            // Pic01
            // 
            Pic01.BackColor = SystemColors.ControlLightLight;
            Pic01.BorderStyle = BorderStyle.FixedSingle;
            Pic01.Location = new Point(12, 12);
            Pic01.Name = "Pic01";
            Pic01.Size = new Size(305, 287);
            Pic01.SizeMode = PictureBoxSizeMode.StretchImage;
            Pic01.TabIndex = 2;
            Pic01.TabStop = false;
            // 
            // CboList
            // 
            CboList.FormattingEnabled = true;
            CboList.Items.AddRange(new object[] { "Computer", "Notebook", "Server" });
            CboList.Location = new Point(501, 9);
            CboList.Name = "CboList";
            CboList.Size = new Size(121, 23);
            CboList.TabIndex = 3;
            // 
            // imgimg
            // 
            imgimg.ColorDepth = ColorDepth.Depth32Bit;
            imgimg.ImageStream = (ImageListStreamer)resources.GetObject("imgimg.ImageStream");
            imgimg.TransparentColor = Color.Transparent;
            imgimg.Images.SetKeyName(0, "computer-case.png");
            imgimg.Images.SetKeyName(1, "laptop.png");
            imgimg.Images.SetKeyName(2, "server.png");
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 311);
            Controls.Add(CboList);
            Controls.Add(Pic01);
            Controls.Add(label1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "민머리대머리맨들맨들";
            ((System.ComponentModel.ISupportInitialize)Pic01).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ImageList ImlForm;
        private Label label1;
        private PictureBox Pic01;
        private ComboBox CboList;
        private ImageList imgimg;
    }
}
