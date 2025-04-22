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
            Grp01 = new GroupBox();
            TxtPhone = new TextBox();
            LblPhone = new Label();
            TxtSex = new TextBox();
            LblSex = new Label();
            TxtAge = new TextBox();
            LblAge = new Label();
            txtName = new TextBox();
            LblName = new Label();
            BtnMsg = new Button();
            LblRes = new Label();
            TxtRes = new TextBox();
            Grp01.SuspendLayout();
            SuspendLayout();
            // 
            // Grp01
            // 
            Grp01.Controls.Add(TxtPhone);
            Grp01.Controls.Add(LblPhone);
            Grp01.Controls.Add(TxtSex);
            Grp01.Controls.Add(LblSex);
            Grp01.Controls.Add(TxtAge);
            Grp01.Controls.Add(LblAge);
            Grp01.Controls.Add(txtName);
            Grp01.Controls.Add(LblName);
            Grp01.Location = new Point(12, 12);
            Grp01.Name = "Grp01";
            Grp01.Size = new Size(370, 426);
            Grp01.TabIndex = 0;
            Grp01.TabStop = false;
            Grp01.Text = "사람정보입력";
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(68, 118);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(180, 23);
            TxtPhone.TabIndex = 4;
            // 
            // LblPhone
            // 
            LblPhone.AutoSize = true;
            LblPhone.Location = new Point(3, 121);
            LblPhone.Name = "LblPhone";
            LblPhone.Size = new Size(50, 15);
            LblPhone.TabIndex = 0;
            LblPhone.Text = "핸드폰 :";
            // 
            // TxtSex
            // 
            TxtSex.Location = new Point(68, 89);
            TxtSex.Name = "TxtSex";
            TxtSex.Size = new Size(180, 23);
            TxtSex.TabIndex = 3;
            // 
            // LblSex
            // 
            LblSex.AutoSize = true;
            LblSex.Location = new Point(15, 92);
            LblSex.Name = "LblSex";
            LblSex.Size = new Size(38, 15);
            LblSex.TabIndex = 0;
            LblSex.Text = "성별 :";
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(68, 60);
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(180, 23);
            TxtAge.TabIndex = 2;
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Location = new Point(15, 63);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(38, 15);
            LblAge.TabIndex = 0;
            LblAge.Text = "나이 :";
            // 
            // txtName
            // 
            txtName.Location = new Point(68, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 23);
            txtName.TabIndex = 1;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(15, 34);
            LblName.Name = "LblName";
            LblName.Size = new Size(38, 15);
            LblName.TabIndex = 0;
            LblName.Text = "이름 :";
            // 
            // BtnMsg
            // 
            BtnMsg.Location = new Point(681, 392);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(107, 46);
            BtnMsg.TabIndex = 1;
            BtnMsg.Text = "확인";
            BtnMsg.UseVisualStyleBackColor = true;
            BtnMsg.Click += this.BtnMsg_Click;
            // 
            // LblRes
            // 
            LblRes.AutoSize = true;
            LblRes.Location = new Point(397, 12);
            LblRes.Name = "LblRes";
            LblRes.Size = new Size(31, 15);
            LblRes.TabIndex = 0;
            LblRes.Text = "결과";
            // 
            // TxtRes
            // 
            TxtRes.Location = new Point(397, 38);
            TxtRes.Multiline = true;
            TxtRes.Name = "TxtRes";
            TxtRes.ReadOnly = true;
            TxtRes.Size = new Size(389, 348);
            TxtRes.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtRes);
            Controls.Add(LblRes);
            Controls.Add(BtnMsg);
            Controls.Add(Grp01);
            Name = "FrmMain";
            Text = "빡빡머리대머리";
            Grp01.ResumeLayout(false);
            Grp01.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Grp01;
        private Button BtnMsg;
        private TextBox TxtPhone;
        private Label LblPhone;
        private TextBox TxtSex;
        private Label LblSex;
        private TextBox TxtAge;
        private Label LblAge;
        private TextBox txtName;
        private Label LblName;
        private Label LblRes;
        private TextBox TxtRes;
    }
}
