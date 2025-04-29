using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject
{
    public partial class FrmWindow : Form
    {
        public FrmWindow()
        {
            InitializeComponent();
        }
        public void AppendHistory(string line)
        {
            TxtHistory.Text += line + "\r\n";
        }
        public void AppendText(string line)
        {
            TxtHistory.Text += line;
        }
    }
}
