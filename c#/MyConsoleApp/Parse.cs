namespace Utilities
{
    public static class Parse
    {
        public static void ParseMethod()
        {
            Console.WriteLine("enter your age");
            int age =int.Parse (Console.ReadLine());
            Console.WriteLine("your age is "+ (age +1));
        }
    }
}