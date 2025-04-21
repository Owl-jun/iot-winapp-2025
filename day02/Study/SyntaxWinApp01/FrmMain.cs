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
            MessageBox.Show("껄껄", "OK버튼", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            // 자료형
            sbyte sbtVal = 127;     // 1byte 정수형 
            byte btVal = 255;       // 1byte 정수형 (unsigned)
            System.SByte sbtVal2 = System.SByte.MinValue;
            short stVal = 32767;    // 2byte 정수형
            ushort ustVal = 65535;  // 2byte 정수형 (unsigned)
            int intVal;
            uint uintVal;
            long lngVal;
            ulong ulngVal;

            float fVal;
            System.Single fVal2 = System.Single.MinValue;
            double dVal;
            decimal dcVal;

            // 문자형 타입
            char ch01 = 'A';
            char ch02 = '\u25b6';

            string str01 = "HELLO";

            bool b01 = true;

            int int02;
            int? i03 = null;
            // Nullable : 기본타입 + ?
            string? asb = null;

            var int05 = 50; // 컴파일 되면서 자료형 결정

            MessageBox.Show(ch02.ToString());
        }
    }
}
