using System;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            FilterOperator.GetNames();
            SortOperators.sortArray();

            //Aggregation Operator
            AggregateOperators.getsum();
            AggregateOperators.getmaximum();
            AggregateOperators.getminimum();
            AggregateOperators.getaverage();

            //Element Operator
            ElementOperators.getemployee();

            //Group Operator
            GroupOperator.getemployeesbydepartment();


            //Set Operators

            SetOperators.getDistinctCountries();
            SetOperators.getExceptCountries();
            SetOperators.getInterseptCountries();
            SetOperators.getUnionCountries();


            //Join Operator

            JoinOperator.getemployeewithdept();

            Console.Read();

        }
    }
}
