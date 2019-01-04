using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JFKTest
{
    using Jfk.Prism;
    
    public class Testowa : ICallable
    {
        static void Main()
        {

        }
        [Description("Logiczny OR, alternatywa.")]
        public int OR(int arg1, int arg2)
        {
            return (arg1 | arg2);
        }
        [Description("Logiczny AND, koniunkcja.")]
        public int AND(int arg1, int arg2)
        {
            return (arg1 & arg2);
        }
        [Description("Logiczny XOR, eksluzywna alternatywa.")]
        public int XOR(int arg1, int arg2)
        {
            return (arg1 ^ arg2);
        }
        [Description("Przesunięcie logiczne w lewo o wartość z drugiego argumentu.")]
        public int MoveLeft(int arg1, int arg2)
        {
            return (arg1 << arg2);
        }
        [Description("Przesunięcie logiczne w prawo o wartość z drugiego argumentu.")]
        public int MoveRight(int arg1, int arg2)
        {
            return (arg1 >> arg2);
        }
    }
}
