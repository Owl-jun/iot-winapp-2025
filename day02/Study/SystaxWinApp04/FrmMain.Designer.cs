namespace SystaxWinApp04
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
            LblName = new Label();
            TxtName = new TextBox();
            LblAge = new Label();
            LblSex = new Label();
            RdoMale = new RadioButton();
            RdoFemale = new RadioButton();
            BtnMsg = new Button();
            LblResult = new Label();
            TxtResult = new TextBox();
            TxtAge = new MaskedTextBox();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.CausesValidation = false;
            LblName.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            LblName.ForeColor = SystemColors.Info;
            LblName.Location = new Point(12, 15);
            LblName.Name = "LblName";
            LblName.Size = new Size(70, 15);
            LblName.TabIndex = 7;
            LblName.Text = "이름 입력 : ";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(91, 12);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(162, 23);
            TxtName.TabIndex = 1;
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.CausesValidation = false;
            LblAge.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            LblAge.ForeColor = SystemColors.Info;
            LblAge.Location = new Point(12, 44);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(66, 15);
            LblAge.TabIndex = 0;
            LblAge.Text = "생년 월일 :";
            // 
            // LblSex
            // 
            LblSex.AutoSize = true;
            LblSex.CausesValidation = false;
            LblSex.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            LblSex.ForeColor = SystemColors.Info;
            LblSex.Location = new Point(12, 73);
            LblSex.Name = "LblSex";
            LblSex.Size = new Size(66, 15);
            LblSex.TabIndex = 0;
            LblSex.Text = "성별 입력 :";
            // 
            // RdoMale
            // 
            RdoMale.AutoSize = true;
            RdoMale.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            RdoMale.ForeColor = SystemColors.Control;
            RdoMale.Location = new Point(91, 71);
            RdoMale.Name = "RdoMale";
            RdoMale.Size = new Size(54, 19);
            RdoMale.TabIndex = 3;
            RdoMale.TabStop = true;
            RdoMale.Text = "Male";
            RdoMale.UseVisualStyleBackColor = true;
            // 
            // RdoFemale
            // 
            RdoFemale.AutoSize = true;
            RdoFemale.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            RdoFemale.ForeColor = SystemColors.Control;
            RdoFemale.Location = new Point(168, 71);
            RdoFemale.Name = "RdoFemale";
            RdoFemale.Size = new Size(66, 19);
            RdoFemale.TabIndex = 4;
            RdoFemale.TabStop = true;
            RdoFemale.Text = "Female";
            RdoFemale.UseVisualStyleBackColor = true;
            // 
            // BtnMsg
            // 
            BtnMsg.BackColor = SystemColors.InactiveBorder;
            BtnMsg.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BtnMsg.Location = new Point(657, 393);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(131, 45);
            BtnMsg.TabIndex = 6;
            BtnMsg.Text = "확인";
            BtnMsg.UseVisualStyleBackColor = false;
            BtnMsg.Click += BtnMsg_Click;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.CausesValidation = false;
            LblResult.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            LblResult.ForeColor = SystemColors.Info;
            LblResult.Location = new Point(12, 151);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(66, 15);
            LblResult.TabIndex = 0;
            LblResult.Text = "결       과 :";
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(91, 148);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(548, 221);
            TxtResult.TabIndex = 5;
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(91, 42);
            TxtAge.Mask = "0000-00-00";
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(162, 23);
            TxtAge.TabIndex = 2;
            TxtAge.ValidatingType = typeof(DateTime);
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtAge);
            Controls.Add(BtnMsg);
            Controls.Add(RdoFemale);
            Controls.Add(RdoMale);
            Controls.Add(LblSex);
            Controls.Add(TxtResult);
            Controls.Add(LblResult);
            Controls.Add(LblAge);
            Controls.Add(TxtName);
            Controls.Add(LblName);
            Name = "FrmMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblName;
        private TextBox TxtName;
        private Label LblAge;
        private Label LblSex;
        private RadioButton RdoMale;
        private RadioButton RdoFemale;
        private Button BtnMsg;
        private Label LblResult;
        private TextBox TxtResult;
        private MaskedTextBox TxtAge;
    }
}
