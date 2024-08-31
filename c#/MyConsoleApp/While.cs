namespace Utilities
{
    public static class While
    {
        // checking while
        public static void WhileMethod()
        {
            int num = 0;
            while(num < 10)
            {
                Console.WriteLine(num);
                num++;
            }
        }

        // doing an assemly
        public static void AssemblyMethod()
        {
            Console.WriteLine("enter a number");
            int num = int.Parse (Console.ReadLine());
            int sum =1;
            while(num > 1)
            {
                sum = sum * num;
                num--;
            }
            Console.WriteLine(sum);
        }

        // finding the biggest out of 10 numbers
        public static void TenNumbersMethod()
        {
            int loop = 0;
            int num;
            Console.WriteLine("enter a number");
            int biggest = int.Parse (Console.ReadLine());

            while(loop < 9)
            {
            Console.WriteLine("enter a number");
            num =int.Parse (Console.ReadLine());
            if (num > biggest)
                {
                    biggest = num;
                }
            loop++;    
            }
            Console.WriteLine(biggest);
        }


        // guess the number that was entered
        public static void GusserMethod()
        {
            bool  loop = true;
            int Guess;
            int PreviousGuess = 0;
            int tries = 0;

            Console.WriteLine("enter a number");
            int DNumber = int.Parse (Console.ReadLine());

            while(loop)
            {
            tries++;

            Console.WriteLine("enter a number and try your luck");
            Guess =int.Parse (Console.ReadLine());

            if (Guess == DNumber)
                {
                  Console.WriteLine("good job you got it in "+tries+" tries");
                  loop = false;
                } 
            else
                {
                   if (tries == 1 || Math.Abs(DNumber - PreviousGuess) == Math.Abs(DNumber - Guess))
                    {
                        Console.WriteLine("mistake");
                    }
                    else
                    {

                        if (Math.Abs(DNumber - PreviousGuess) > Math.Abs(DNumber - Guess))  
                          {
                            Console.WriteLine("getting warmer my dood");
                          }
                        else
                          {
                            Console.WriteLine("getting colder my dood");
                          }                                   
                    }
                }
            PreviousGuess = Guess;    
            }
        }
    }   
}