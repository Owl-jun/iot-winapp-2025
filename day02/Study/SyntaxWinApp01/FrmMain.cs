namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����", "OK��ư", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            // �ڷ���
            sbyte sbtVal = 127;     // 1byte ������ 
            byte btVal = 255;       // 1byte ������ (unsigned)
            System.SByte sbtVal2 = System.SByte.MinValue;
            short stVal = 32767;    // 2byte ������
            ushort ustVal = 65535;  // 2byte ������ (unsigned)
            int intVal;
            uint uintVal;
            long lngVal;
            ulong ulngVal;

            float fVal;
            System.Single fVal2 = System.Single.MinValue;
            double dVal;
            decimal dcVal;

            // ������ Ÿ��
            char ch01 = 'A';
            char ch02 = '\u25b6';

            string str01 = "HELLO";

            bool b01 = true;

            int int02;
            int? i03 = null;
            // Nullable : �⺻Ÿ�� + ?
            string? asb = null;

            var int05 = 50; // ������ �Ǹ鼭 �ڷ��� ����

            MessageBox.Show(ch02.ToString());
        }
    }
}
