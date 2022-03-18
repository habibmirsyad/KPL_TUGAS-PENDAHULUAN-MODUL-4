using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul4_1302201138
{
    class HaloGeneric<T>
    {
        public string SapaUser(T nama)
        {
            return "Halo user "+ nama;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            HaloGeneric<string> gen = new HaloGeneric<string>();
            Console.WriteLine(gen.SapaUser("Habib"));
        }
    }
}
