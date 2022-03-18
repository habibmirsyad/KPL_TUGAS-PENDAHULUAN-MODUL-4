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
            return "Halo user " + nama;
        }
    }

    class DataGeneric<T>
    {
        public T data;

        public void printData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            HaloGeneric<string> Hgen = new HaloGeneric<string>();
            Console.WriteLine(Hgen.SapaUser("Habib"));

            DataGeneric<string> Dgen = new DataGeneric<string>();
            Dgen.data = "1302201138";
            Dgen.printData();
        }
    }
}
