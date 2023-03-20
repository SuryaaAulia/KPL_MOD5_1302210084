using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Penjumlahan
    {
        public void JumlahTigaAngka<T>(T x, T y, T z)
        {
            dynamic a = 0;
            a = a + x + y + z;
            Console.WriteLine(a);
        }
    }
}
