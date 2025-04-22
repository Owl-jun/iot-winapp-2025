using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxWinApp02
{
    internal interface Imobile
    {
        // 인터페이스를 구현하는 클래스에서 메서드 재정의
        void Call();
        string GetList();
    }
    
    internal class Iphone : Imobile 
    {
        public void Call() {
            
        }
        public string GetList() {
            return "a";
        }
    }
}
