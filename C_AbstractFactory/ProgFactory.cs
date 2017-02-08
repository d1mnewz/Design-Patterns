using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AbstractFactory
{
    class ProgFactory : IFaculty
    {
        public Student GetStudent()
        {
            return new ProgStudent("Cool programmer");
        }
    }
}
