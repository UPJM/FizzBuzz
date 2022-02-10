using System;
using System.Collections.Generic;


namespace FizzBuzz
{
    //class that contains actions
    public class Actions
    {

        // Accepts a list and returns the
        // required outputs
        public static void DoFizzBuzz(List<int> data)
        {
            if (data != null)
            {

                foreach (var num in data)
                {
                    if (num % 3 == 0 && num % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (num % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (num % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(num);
                    }
                }
            }
            else {
                Console.WriteLine("List Data Empty.");


            }

        }

    }
}
