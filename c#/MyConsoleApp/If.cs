using System.Security.Cryptography;

namespace Utilities
{
    public static class If
    {
        // if learner
        public static void IfMethod()
        {
            Console.WriteLine("enter two numbers");
            double num1 =double.Parse (Console.ReadLine());
            double num2 =double.Parse (Console.ReadLine());

            // Math.Abs() return absolute value
            if (num1 + num2 >10.5 && Math.Abs(num1 - num2) < 5.3)
                {
                Console.WriteLine("100.5 < " + num1 +"+"+ num2);
                }
        }

        // if in while checker (for 2 and 3)
                public static void BoomCheckerMethod()
        {
            int loop = 1;
            string chk;
            while (loop < 100)
            {
            chk = loop+ "";    
            if (loop % 2 == 0 && loop % 3 == 0)
                {
                chk = "BOOM";
                }
            else 
            {
                if (loop % 2 == 0)
                {
                  chk = "2";  
                }
                if (loop % 3 == 0)
                {
                  chk = "3";  
                }
            }   

            Console.WriteLine(chk);
            loop++;
            }
        }
    }
}
