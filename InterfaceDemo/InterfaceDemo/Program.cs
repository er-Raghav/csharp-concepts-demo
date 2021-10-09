using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            IfreeUser ifreeUser = new calculator();     //Interface reference

            ifreeUser.add();
            ifreeUser.sub();
            ifreeUser.mul();
            ifreeUser.div();
            


            ILicenseUser license = new calculator();
            license.add();
            license.sub();
            license.mul();
            license.div();
            license.squareRoot();
            license.Log();
        }
    }

    public interface IfreeUser
    {
        
        void add();
        void sub();
        void mul();
        void div();

    }

    public interface ILicenseUser : IfreeUser
    {
        void squareRoot();
        void Log();

    }

    public class calculator : IfreeUser, ILicenseUser
    {
        public void add()
        {

        }
        public void sub()
        {

        }
        public void mul()
        {

        }

        public void div()
        {

        }

        public void squareRoot()
        {          //Advance Method

        }

        public void Log()           //Advance Method
        {

        }
    }

}
