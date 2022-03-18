using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul4_1302201138
{
    class DataGeneric<T>
    {
        public T data;
    
        public void printData()
        {
            Console.WriteLine("Data yang tersimpan adalah: "+data);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DataGeneric<string> gen = new DataGeneric<string>();
            gen.data = "1302201138";
            gen.printData();
        }
    }
}
