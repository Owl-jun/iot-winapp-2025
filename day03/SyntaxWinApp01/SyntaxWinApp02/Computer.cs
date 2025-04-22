using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SyntaxWinApp02
{
    internal class Computer
    {
        public Computer() { Debug.WriteLine("버그없는세상에서 살고싶어요~"); }

        bool PowerOn;
        public void Boot() { }
        public void ShutDown() { }
        public void Reset() { }
    }

    internal class Server : Computer
    {
        public Server() { }
    }
    internal class Notebook : Computer
    {
        public Notebook() { }
    }
}
