using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AbstractFactory
{
    class Program
    {
        

        static void Main(string[] args)
        {
            IFaculty progs = new ProgFactory();
            Console.WriteLine(progs.GetStudent().desc);

            IFaculty engs = new EngiFactory();
            Console.WriteLine(engs.GetStudent().desc);

        }
    }
}
