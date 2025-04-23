namespace SyntaxWinApp01
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
            groupBox1 = new GroupBox();
            TxtPhone = new MaskedTextBox();
            NudAge = new NumericUpDown();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            TxtRes = new TextBox();
            TxtGender = new TextBox();
            label3 = new Label();
            TxtName = new TextBox();
            label1 = new Label();
            BtnMsg = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(TxtPhone);
            groupBox1.Controls.Add(NudAge);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtRes);
            groupBox1.Controls.Add(TxtGender);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.ImeMode = ImeMode.NoControl;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 287);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "정보입력/결과";
            // 
            // TxtPhone
            // 
            TxtPhone.BackColor = Color.AntiqueWhite;
            TxtPhone.Location = new Point(134, 110);
            TxtPhone.Margin = new Padding(6);
            TxtPhone.Mask = "000-0000-0000";
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(120, 23);
            TxtPhone.TabIndex = 4;
            TxtPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // NudAge
            // 
            NudAge.BackColor = Color.AntiqueWhite;
            NudAge.Location = new Point(134, 52);
            NudAge.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            NudAge.Name = "NudAge";
            NudAge.Size = new Size(120, 23);
            NudAge.TabIndex = 2;
            NudAge.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label2.Location = new Point(97, 54);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "나이";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label5.Location = new Point(6, 143);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 2;
            label5.Text = "결과";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label4.Location = new Point(85, 113);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 2;
            label4.Text = "연락처";
            // 
            // TxtRes
            // 
            TxtRes.BackColor = Color.AntiqueWhite;
            TxtRes.Location = new Point(6, 161);
            TxtRes.Multiline = true;
            TxtRes.Name = "TxtRes";
            TxtRes.ReadOnly = true;
            TxtRes.Size = new Size(248, 120);
            TxtRes.TabIndex = 6;
            // 
            // TxtGender
            // 
            TxtGender.BackColor = Color.AntiqueWhite;
            TxtGender.Location = new Point(134, 81);
            TxtGender.MaxLength = 1;
            TxtGender.Name = "TxtGender";
            TxtGender.PlaceholderText = "M / F";
            TxtGender.Size = new Size(120, 23);
            TxtGender.TabIndex = 3;
            TxtGender.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label3.Location = new Point(97, 84);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "성별";
            // 
            // TxtName
            // 
            TxtName.BackColor = Color.AntiqueWhite;
            TxtName.Location = new Point(134, 22);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(120, 23);
            TxtName.TabIndex = 1;
            TxtName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label1.Location = new Point(97, 25);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "이름";
            // 
            // BtnMsg
            // 
            BtnMsg.BackColor = Color.Transparent;
            BtnMsg.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnMsg.Location = new Point(463, 258);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(109, 41);
            BtnMsg.TabIndex = 5;
            BtnMsg.Text = "체크";
            BtnMsg.UseVisualStyleBackColor = false;
            BtnMsg.Click += BtnMsg_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(372, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            BackgroundImage = Properties.Resources.images;
            ClientSize = new Size(584, 311);
            Controls.Add(pictureBox1);
            Controls.Add(BtnMsg);
            Controls.Add(groupBox1);
            Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "윈앱 학습";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown NudAge;
        private Label label2;
        private TextBox TxtName;
        private Label label1;
        private Button BtnMsg;
        private MaskedTextBox TxtPhone;
        private Label label4;
        private TextBox TxtGender;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox TxtRes;
        private Label label5;
    }
}
