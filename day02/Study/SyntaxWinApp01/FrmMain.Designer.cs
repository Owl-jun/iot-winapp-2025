﻿namespace SyntaxWinApp01
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
            BtnOK = new Button();
            BtnMsg = new Button();
            SuspendLayout();
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(558, 12);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(91, 28);
            BtnOK.TabIndex = 0;
            BtnOK.Text = "OK";
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // BtnMsg
            // 
            BtnMsg.Location = new Point(558, 46);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(91, 26);
            BtnMsg.TabIndex = 1;
            BtnMsg.Text = "메세지";
            BtnMsg.UseVisualStyleBackColor = true;
            BtnMsg.Click += BtnMsg_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 404);
            Controls.Add(BtnMsg);
            Controls.Add(BtnOK);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "문법학습 윈앱 01";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnOK;
        private Button BtnMsg;
    }
}
