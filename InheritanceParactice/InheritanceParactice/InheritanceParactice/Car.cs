using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceParactice
{
    class Car
    {
        public Car()
        {
            speed = 510;
        }
        public readonly int speed;
        public string Brand;
        private int _horsePower;
        //public string color { get; private set; }

        public int HorsePower
            
        {

            get
            {
                if (_horsePower < 100)
                {
                    Console.WriteLine("Can`t drive");
                    return -1;
                }
                return _horsePower;
            }

            set
            {
                //_horsePower = value;
                if(value < 100)
                {
                    Console.WriteLine("Please set correct power");
                    return;
                }
                _horsePower = value;
            
            } 
        
        }
    }
}
