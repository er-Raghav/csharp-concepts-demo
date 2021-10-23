using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignDemo
{
    sealed class logger                        //Class should be sealed
    {
        private static int counter;
        private static logger _logInstance;
        private logger()                        //All constructors must be private
        {
            counter++;
            
        }
        public static logger getInstance
        {
            get
            {
                if (_logInstance == null)
                {
                    _logInstance = new logger();            //Object Creation inside static property.
                }
                return _logInstance;
            }
        }

        public void writetrace() {
            Console.WriteLine($"Object counter :{counter}");
            Console.WriteLine("This method is writing trace");
        }

    }
}
