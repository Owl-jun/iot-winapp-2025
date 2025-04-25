namespace WinFormProject
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
            BtnProcess = new Button();
            TxtScript = new TextBox();
            TxtResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            BtnTutor = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // BtnProcess
            // 
            BtnProcess.Location = new Point(12, 170);
            BtnProcess.Name = "BtnProcess";
            BtnProcess.Size = new Size(560, 28);
            BtnProcess.TabIndex = 0;
            BtnProcess.Text = "실행";
            BtnProcess.UseVisualStyleBackColor = true;
            BtnProcess.Click += BtnProcess_Click;
            // 
            // TxtScript
            // 
            TxtScript.BackColor = SystemColors.InfoText;
            TxtScript.Font = new Font("D2Coding", 9F);
            TxtScript.ForeColor = SystemColors.Window;
            TxtScript.Location = new Point(12, 12);
            TxtScript.Multiline = true;
            TxtScript.Name = "TxtScript";
            TxtScript.Size = new Size(560, 152);
            TxtScript.TabIndex = 1;
            // 
            // TxtResult
            // 
            TxtResult.BackColor = SystemColors.InfoText;
            TxtResult.Font = new Font("D2Coding", 9F);
            TxtResult.ForeColor = SystemColors.Window;
            TxtResult.Location = new Point(12, 207);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.ReadOnly = true;
            TxtResult.ScrollBars = ScrollBars.Vertical;
            TxtResult.Size = new Size(560, 227);
            TxtResult.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label1.Location = new Point(597, 56);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 2;
            label1.Text = "Ctrl + ENTER : 바로 실행";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(597, 14);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 3;
            label2.Text = "폰트크기 조절";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(686, 12);
            numericUpDown1.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(46, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // BtnTutor
            // 
            BtnTutor.Location = new Point(596, 91);
            BtnTutor.Name = "BtnTutor";
            BtnTutor.Size = new Size(146, 30);
            BtnTutor.TabIndex = 5;
            BtnTutor.Text = "History";
            BtnTutor.UseVisualStyleBackColor = true;
            BtnTutor.Click += BtnTutor_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(749, 447);
            Controls.Add(BtnTutor);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtResult);
            Controls.Add(TxtScript);
            Controls.Add(BtnProcess);
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bash Programming Practice App";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnProcess;
        private TextBox TxtScript;
        private TextBox TxtResult;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button BtnTutor;
    }
}
