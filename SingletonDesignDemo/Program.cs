using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            logger objlog = logger.getInstance;

            objlog.writetrace();

            logger objlog1 = logger.getInstance;

            objlog1.writetrace();

            Console.Read();

        }
    }
}
