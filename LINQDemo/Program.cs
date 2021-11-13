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


            Console.Read();

        }
    }
}
