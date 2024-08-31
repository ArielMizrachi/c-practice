namespace Utilities
{
    public static class Input
    {
        public static void InputMethod()
        {
            // the sting? is to give the option to recive null values

            Console.WriteLine("enter your name");
            string? name = Console.ReadLine();
            Console.WriteLine("your name is "+ name);
        }
    }
}