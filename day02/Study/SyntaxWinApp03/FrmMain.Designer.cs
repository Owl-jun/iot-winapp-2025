namespace SyntaxWinApp03
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
            Lbl통증여부 = new Label();
            Txt통증여부 = new TextBox();
            Lbl통증부위 = new Label();
            Cmb통증부위 = new ComboBox();
            BtnMsg = new Button();
            BtnDisplay = new Button();
            TxtDisplay = new TextBox();
            BtnWhile = new Button();
            SuspendLayout();
            // 
            // Lbl통증여부
            // 
            Lbl통증여부.AutoSize = true;
            Lbl통증여부.BackColor = Color.AliceBlue;
            Lbl통증여부.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Lbl통증여부.Location = new Point(12, 9);
            Lbl통증여부.Name = "Lbl통증여부";
            Lbl통증여부.Size = new Size(120, 30);
            Lbl통증여부.TabIndex = 0;
            Lbl통증여부.Text = "통증여부 - ";
            // 
            // Txt통증여부
            // 
            Txt통증여부.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Txt통증여부.Location = new Point(138, 9);
            Txt통증여부.Name = "Txt통증여부";
            Txt통증여부.PlaceholderText = "입력";
            Txt통증여부.Size = new Size(120, 35);
            Txt통증여부.TabIndex = 1;
            Txt통증여부.TextAlign = HorizontalAlignment.Center;
            Txt통증여부.KeyPress += Txt통증여부_KeyPress;
            // 
            // Lbl통증부위
            // 
            Lbl통증부위.AutoSize = true;
            Lbl통증부위.BackColor = Color.AliceBlue;
            Lbl통증부위.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Lbl통증부위.Location = new Point(12, 62);
            Lbl통증부위.Name = "Lbl통증부위";
            Lbl통증부위.Size = new Size(120, 30);
            Lbl통증부위.TabIndex = 2;
            Lbl통증부위.Text = "통증부위 - ";
            // 
            // Cmb통증부위
            // 
            Cmb통증부위.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Cmb통증부위.FormattingEnabled = true;
            Cmb통증부위.Items.AddRange(new object[] { "머리", "눈", "코", "목", "가슴", "배" });
            Cmb통증부위.Location = new Point(138, 62);
            Cmb통증부위.Name = "Cmb통증부위";
            Cmb통증부위.Size = new Size(121, 38);
            Cmb통증부위.TabIndex = 3;
            Cmb통증부위.Text = "ㅋㅋㅋ";
            Cmb통증부위.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // BtnMsg
            // 
            BtnMsg.BackColor = SystemColors.ActiveCaption;
            BtnMsg.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            BtnMsg.Location = new Point(673, 388);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(115, 50);
            BtnMsg.TabIndex = 4;
            BtnMsg.Text = "메시지";
            BtnMsg.UseVisualStyleBackColor = false;
            BtnMsg.Click += BtnMsg_Click;
            // 
            // BtnDisplay
            // 
            BtnDisplay.BackColor = SystemColors.ActiveCaption;
            BtnDisplay.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            BtnDisplay.Location = new Point(552, 388);
            BtnDisplay.Name = "BtnDisplay";
            BtnDisplay.Size = new Size(115, 50);
            BtnDisplay.TabIndex = 5;
            BtnDisplay.Text = "구구단";
            BtnDisplay.UseVisualStyleBackColor = false;
            BtnDisplay.Click += BtnDisplay_Click;
            // 
            // TxtDisplay
            // 
            TxtDisplay.Location = new Point(12, 111);
            TxtDisplay.Multiline = true;
            TxtDisplay.Name = "TxtDisplay";
            TxtDisplay.Size = new Size(776, 271);
            TxtDisplay.TabIndex = 6;
            // 
            // BtnWhile
            // 
            BtnWhile.BackColor = SystemColors.ActiveCaption;
            BtnWhile.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            BtnWhile.Location = new Point(431, 388);
            BtnWhile.Name = "BtnWhile";
            BtnWhile.Size = new Size(115, 50);
            BtnWhile.TabIndex = 7;
            BtnWhile.Text = "반복";
            BtnWhile.UseVisualStyleBackColor = false;
            BtnWhile.Click += BtnWhile_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnWhile);
            Controls.Add(TxtDisplay);
            Controls.Add(BtnDisplay);
            Controls.Add(BtnMsg);
            Controls.Add(Cmb통증부위);
            Controls.Add(Lbl통증부위);
            Controls.Add(Txt통증여부);
            Controls.Add(Lbl통증여부);
            Cursor = Cursors.Cross;
            DoubleBuffered = true;
            Name = "FrmMain";
            Text = "FrmMain";
            Load += FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl통증여부;
        private TextBox Txt통증여부;
        private Label Lbl통증부위;
        private ComboBox Cmb통증부위;
        private Button BtnMsg;
        private Button BtnDisplay;
        private TextBox TxtDisplay;
        private Button BtnWhile;
    }
}
