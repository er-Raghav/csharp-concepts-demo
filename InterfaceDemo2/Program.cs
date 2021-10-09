using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    /// <summary>
    /// This demo is example of Explicit Interface Implementation.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            employee obj = new employee();
            //obj.GetName();      //It is not associated with class object
            I1 i1 = new employee();
            i1.GetName();
            I2 i2 = new employee();
            i2.GetName();

            Console.Read();
        }
    }

    interface I1
    {
        void GetName();
    }

    interface I2
    {
        void GetName();
    }

    class employee : I1, I2
    {

        void I1.GetName()
        {
            Console.WriteLine("I1 GetName Implemented!");
        }
        void I2.GetName()
        {
            Console.WriteLine("I2 GetName Implemented!");
        }
    }
}
