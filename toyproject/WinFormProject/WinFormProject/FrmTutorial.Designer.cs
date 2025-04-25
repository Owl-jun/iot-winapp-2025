namespace WinFormProject
{
    partial class FrmTutorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtHistory = new TextBox();
            SuspendLayout();
            // 
            // TxtHistory
            // 
            TxtHistory.Location = new Point(12, 12);
            TxtHistory.Multiline = true;
            TxtHistory.Name = "TxtHistory";
            TxtHistory.Size = new Size(460, 537);
            TxtHistory.TabIndex = 0;
            // 
            // FrmTutorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(TxtHistory);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTutorial";
            StartPosition = FormStartPosition.Manual;
            Text = "history";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtHistory;
    }
}