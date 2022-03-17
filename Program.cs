using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul4_1302201138
{
    internal class Program
    {
        public class HaloGeneric
        {
            public stringa SapaUser(string nama)
            {
                return "Halo user "+ nama;
            }
        }

        static void Main(string[] args)
        {
            HaloGeneric gen = new HaloGeneric();
            Console.WriteLine(gen.SapaUser("Habib"));
        }
    }
}
