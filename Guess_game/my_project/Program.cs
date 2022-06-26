using System;
namespace nm{
    class my_p
    {
        static void Main(String[] args)
        {
            int i;
            Random rand = new Random();
            int secret_no = rand.Next(100);
            Console.WriteLine("Guess the no from 0 to 100");
            for ( i = 0; i < 10; i++)
            {
                string gue = Console.ReadLine();
                int guess = Convert.ToInt32(gue);
                
                if (guess == secret_no)
                {
                    Console.WriteLine("corrrect guess,you won!!!");
                    break;

                }
                else if (guess > secret_no)
                    Console.WriteLine("the number is less than " + guess);
                else if (guess < secret_no)
                    Console.WriteLine("the number is greater than " + guess);
                else
                    Console.WriteLine("try again you have " + (10 - i) + " chances left");
            }
            if (i == 10)
                Console.WriteLine("Game over,you have finished your chances");
        }
    } 
}
