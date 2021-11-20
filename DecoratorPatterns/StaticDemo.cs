
namespace DecoratorPatterns
{
    static class StaticDemo
    {
       public static int Userid;
    }

     class Demo
    {
       public static int Userid;
    }

    static class Main
    {
        public static void MainTest()
        {
            StaticDemo.Userid = 5;

            Demo obj1 = new Demo();
            Demo.Userid = 1;

            Demo obj2 = new Demo();
            Demo.Userid = 2;

            StaticDemo.Userid = 10;
        }
    }
}
