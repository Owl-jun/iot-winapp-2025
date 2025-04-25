namespace WinControlsApp
{
    public partial class FrmMain : Form
    {
        private bool isActiveBold = false;
        private bool isActiveItalic = false;
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;
            foreach (var Font in Fonts)
            {
                CboFonts.Items.Add(Font.Name);
            }
            LblState.Text = "state : Font Loaded";

            toolTip1.SetToolTip(BtnModal, "��� ����ü����");
        }
        private void CboFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
        private void BtnBold_Click(object sender, EventArgs e)
        {
            isActiveBold = !isActiveBold;
            BtnBold.BackColor = isActiveBold ? Color.SkyBlue : Color.White;
            ChangeFont();
        }
        private void BtnItalic_Click(object sender, EventArgs e)
        {
            isActiveItalic = !isActiveItalic;
            BtnItalic.BackColor = isActiveItalic ? Color.SkyBlue : Color.White;
            ChangeFont();
        }

        private void ChangeFont()
        {
            if (CboFonts.SelectedIndex < 0) return;

            FontStyle style = FontStyle.Regular;

            if (isActiveBold) style |= FontStyle.Bold;
            if (isActiveItalic) style |= FontStyle.Italic;
            TxtSample.Font = new Font((string)CboFonts.SelectedItem, 12, style);
            LblState.Text = "state : Font Changed";
        }

        private void TrbProcess_Scroll(object sender, EventArgs e)
        {
            PrgProcess.Value = TrbProcess.Value;
            double opacityValue = PrgProcess.Value / 100.0; // 0.0 ~ 1.0 �� ��ȯ
            if (opacityValue >= 0.4)
            {
                this.Opacity = opacityValue;
                LblOpacity.Text = $"{(this.Opacity * 100).ToString()}%";
            }
            else
            {
                this.Opacity = 0.4;
                LblOpacity.Text = $"{(this.Opacity * 100).ToString()}%";
            }
            LblState.Text = "state : Set Opacity";
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frmModal = new Form();
            frmModal.Text = "���â";
            frmModal.Width = 300;
            frmModal.Height = 100;
            frmModal.BackColor = Color.Red;
            frmModal.StartPosition = FormStartPosition.CenterParent;
            LblState.Text = "state : Open ModalWindow";
            frmModal.ShowDialog(); // ���â ����
        }

        private void BtnModalless_Click(object sender, EventArgs e)
        {
            Form frmModaless = new Form();
            frmModaless.Text = "��޸���â";
            frmModaless.Width = 300;
            frmModaless.Height = 100;
            frmModaless.BackColor = Color.Green;
            frmModaless.StartPosition = FormStartPosition.Manual;
            frmModaless.Location = new Point(this.Location.X + ((this.Width - frmModaless.Width) / 2),
                this.Location.Y + ((this.Height - frmModaless.Height) / 2));
            LblState.Text = "state : Open ModalessWindow";
            frmModaless.Show(this);
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            LblState.Text = "state : Show MessageBox";
            MessageBox.Show(TxtSample.Text, "�ؽ�Ʈ�ڽ�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnRoot_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            TrvDummy.Nodes.Add(rand.Next().ToString());
        }

        private void BtnNode_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            if (TrvDummy.SelectedNode == null)
            {
                MessageBox.Show("��带 �����Ͻÿ�", "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                TrvDummy.SelectedNode.Nodes.Add(rand.Next().ToString());
                TrvDummy.SelectedNode.Expand();
                TreeToList();
            }
        }

        private void TreeToList()
        {
            LsvDummy.Items.Clear();
            foreach (TreeNode node in TrvDummy.Nodes)
            {
                TreeToList(node);
            }
        }
        private void TreeToList(TreeNode node)
        {
            ListViewItem item = new ListViewItem(
                    new String[] { node.Text, node.FullPath.Count(f => f == '\\').ToString() }
                    );
            item.ImageIndex = 0;
            LsvDummy.Items.Add(item);

            foreach (TreeNode subNode in node.Nodes)
            {
                TreeToList(subNode);
            }
        }

        private void BtnOpenImage_Click(object sender, EventArgs e)
        {
            DlgOpenImage.Title = "�̹��� ����";
            DlgOpenImage.FileName = "";
            DlgOpenImage.Filter = "�̹��� ����(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";

            if (DlgOpenImage.ShowDialog() == DialogResult.OK)
            {
                PicImage.Image = Bitmap.FromFile(DlgOpenImage.FileName);
            }
        }

        private void CalSchedule_DateChanged(object sender, DateRangeEventArgs e)
        {
            // MessageBox.Show(CalSchedule.SelectionStart.ToString());
            TxtYear.Text = CalSchedule.SelectionStart.Year.ToString() + "��";
            TxtMonth.Text = CalSchedule.SelectionStart.Month.ToString() + "��";
            TxtDay.Text = CalSchedule.SelectionStart.Day.ToString() + "��";
        }

        private void LblURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.naver.com",
                UseShellExecute = true
            });

        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("������?", "���Ῡ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.FormClosing -= FrmMain_FormClosing;
                Application.Exit();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("��¥ ������?", "���Ῡ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
