using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JFKTest
{ 
    using Jfk.Prism;
    [Description("Logiczny XOR, eksluzywna alternatywa.")]
    public class XOR : ICallable
    {
        public int Call(int arg1, int arg2)
        {
            return (arg1 ^ arg2);
        }
    }
}
