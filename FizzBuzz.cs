namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            bool found = false;
 
            for(int counter=1; counter <= 100; counter++)
            {
                if(counter%3 == 0)
                {
                    Console.Write("Fizz");
                    found = true;
                }
 
                if(counter%5 == 0)
                {
                    Console.Write("Buzz");
                    found = true;
                }
 
                if (!found)
                {
                    Console.Write(counter);
                }
 
                Console.WriteLine();
                found = false;
            }
        }
    }
}
