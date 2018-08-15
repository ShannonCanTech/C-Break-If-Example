using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakIfExample
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;

            while (!done) {
                Console.WriteLine("Are you old enough to party?");
                string answer = Console.ReadLine();
                if (answer.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Well lets find out, shall we.");
                } else if (answer.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Well thanks for stopping by.");
                    break;
                }
                Console.WriteLine("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if(age < 18)
                {
                    Console.WriteLine("Sorry, you can't party. Goodbye ;)");
                    break;
                } else
                {
                    switch (age)
                    {
                        case 18:
                            Console.WriteLine("Age: " + age + "You can't party yet.");
                            break;
                        case 19:
                            Console.WriteLine("Age: " + age + "You're so close. Try again in 2 years.");
                            break;
                        case 20:
                            Console.WriteLine("Age: " + age + "Almost there. Just one more year.");
                            break;
                        case 21:
                            Console.WriteLine("Age: " + age + "What took you so long?!\nWelcome to the party!");
                            break;
                        default:
                            Console.WriteLine("Age: " + age + "\nSomething tells me you are definitely old enough to party.");
                            break;
                    }
                }
                
                done = true;
            }

            
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
