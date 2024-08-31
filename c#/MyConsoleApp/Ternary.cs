namespace Utilities
{
    public static class Ternary
    {
        public static void TernaryMethod()
        {
            Console.WriteLine("enter three numbers");
            int num1 =int.Parse (Console.ReadLine());
            int num2 =int.Parse (Console.ReadLine());
            int num3 =int.Parse (Console.ReadLine());

            int BestNum = num1 > num2 ? num1 : num2;
            BestNum = BestNum > num3 ? BestNum : num3;

            Console.WriteLine(BestNum);
            
        }
    }
}