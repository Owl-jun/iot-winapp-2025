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
            label1 = new Label();
            RtbMsg = new RichTextBox();
            BtnMsg = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "이벤트순서";
            // 
            // RtbMsg
            // 
            RtbMsg.Location = new Point(12, 27);
            RtbMsg.Name = "RtbMsg";
            RtbMsg.Size = new Size(560, 245);
            RtbMsg.TabIndex = 1;
            RtbMsg.Text = "";
            // 
            // BtnMsg
            // 
            BtnMsg.Location = new Point(497, 278);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(75, 23);
            BtnMsg.TabIndex = 2;
            BtnMsg.Text = "확인";
            BtnMsg.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(BtnMsg);
            Controls.Add(RtbMsg);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            Text = "5일차";
            Activated += FrmMain_Activated;
            FormClosing += FrmMain_FormClosing;
            FormClosed += FrmMain_FormClosed;
            Load += FrmMain_Load;
            Shown += FrmMain_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox RtbMsg;
        private Button BtnMsg;
    }
}
