using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Demo
{
    class Car : Automobile
    {
        private int doors;

        public Car()
        {
            doors = 0;
        }

        public int Doors
        {
            get { return doors; }
            set { doors = value; }
        }
    }
}
