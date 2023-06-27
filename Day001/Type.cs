using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte a = -10; //-128~+127
            byte b = 255; //0~255
            short c = -32768; //-32768~32767
            ushort d = 65535; //0~65535
            Console.WriteLine($"a={a} b={b}");
            int e=2147483647;
            uint f = 4294967295; // 0~
            long g = -5000_0000_0000;
            ulong h = 200_0000_0000_0000_0000;
            Console.WriteLine($"c={c} d={d}");
            Console.WriteLine($"e={e} f={f}");
            Console.WriteLine($"g={g} h={h}");
        }
    }
}
