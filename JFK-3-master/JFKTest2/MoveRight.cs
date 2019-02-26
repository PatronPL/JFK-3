using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JFKTest2
{
    using Jfk.Prism;
    [Description("Przesunięcie logiczne w prawo o wartość z drugiego argumentu.")]
    public class MoveRight : ICallable
    {
        public int Call(int arg1, int arg2)
        {
            return (arg1 >> arg2);
        }
    }
}
