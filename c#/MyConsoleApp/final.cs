namespace Utilities
{
    public static class Finals
    {
        // finding if a number is primary number
        public static void PrimaryMethod()
        {
            bool chk = true;
            int i =2;
            Console.WriteLine("enter a number");
            int num = int.Parse (Console.ReadLine());

            while(chk && i <(num/2)+1)
            {
                if(num % i == 0)
                {
                    chk = false;
                }
                i++;
            }
            if (chk)
            {
              Console.WriteLine("primary");  
            }
            else
            {
               Console.WriteLine("not primary"); 
            }
        }



        // finding the holding of 2 numbers
        public static void HoldingMethod()
        {
            int i =1;
            int sum = 1;
            Console.WriteLine("enter two numbers number");
            int num1 = int.Parse (Console.ReadLine());
            int num2 = int.Parse (Console.ReadLine());

            while(i <= num2)
            {
                sum = sum * num1;
                i++;
            }
            Console.WriteLine(sum);
        }



        // finding if the number have a root
        public static void RootMethod()
        {
            bool chk = false;
            int i =2;
            Console.WriteLine("enter two numbers number");
            int num = int.Parse (Console.ReadLine());

            while(!chk && i<= num/2)
            {
                if (i*i == num)
                {
                    chk = true;
                }
                i++;
                
            }
            if (chk)
            {
              Console.WriteLine("have a root");  
            }
            else
            {
              Console.WriteLine("does not have a root"); 
            }
        }
    }
}