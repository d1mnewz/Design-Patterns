using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AbstractFactory
{
    class EngiFactory : IFaculty
    {
        public Student GetStudent()
        {
            return new Student("Trust me, i`m engeeniier.");
        }
    }
}
