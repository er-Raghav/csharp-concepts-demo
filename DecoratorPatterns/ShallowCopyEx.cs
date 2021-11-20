using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatterns
{
    class ShallowCopyEx : ICloneable
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public Department dept { get; set; }

        public object Clone()
        {
            //return this.MemberwiseClone();
            ShallowCopyEx obj = (ShallowCopyEx)this.MemberwiseClone();
            obj.dept = new Department() { DeptID = this.dept.DeptID, DeptName = this.dept.DeptName };
            return obj;
        }
    }

    class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
    }
}
