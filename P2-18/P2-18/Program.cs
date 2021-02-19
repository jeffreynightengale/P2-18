using System;

namespace P2_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            do
            {
                Console.WriteLine($"Please enter # of miles. >>");
                answer = Console.ReadLine();
                //double miles = Convert.ToDouble(answer);
                double miles;
                bool isSuccessful = double.TryParse(answer, out miles);

                if (isSuccessful == true)
                {
                    Console.WriteLine("Good job entering a valid number!");
                }
                else
                {
                    Console.WriteLine("Invalid input. Goodbye.");
                    Environment.Exit(0);
                }

                Console.WriteLine($"Please enter the weight of your shipment in pounds. >>");
                answer = Console.ReadLine();
                //double miles = Convert.ToDouble(answer);
                double weight;

                //Console.WriteLine($"{miles.ToString("N2")}");

                if (double.TryParse(answer, out weight) == false)
                {
                    Console.WriteLine("Invalid input. Goodbye.");
                    //return
                    Environment.Exit(-1);
                }
                Console.WriteLine("Does your shipment contain hazardous material? yes or no");
                answer = Console.ReadLine();

                double quote = .55 * miles + .73 * weight;
                double hazardousCost;

                if (answer.ToLower() == "yes")
                {
                    hazardousCost = .015 * weight;
                }
                else
                {
                    hazardousCost = 0;
                }

                double netTotal = quote + hazardousCost;
                double discount; //double discount = 0; do this instead of else
                if (miles < 150 && weight > 500)
                {
                    discount = .10 * netTotal;
                }
                else
                {
                    discount = 0;
                }
                double total = netTotal - discount;


                Console.WriteLine($"Quote: \t{quote.ToString("C")}");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Hazardous Cost: \t{hazardousCost.ToString("C")}");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Discount: \t{discount.ToString("C")}");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Total: \t{total.ToString("C")}");

                Console.WriteLine($"\nDo you want to enter another shipment? yes or no >>");
                answer = Console.ReadLine();
                while (answer.ToLower() != "yes" && answer.ToLower() != "no")
                {
                    Console.WriteLine("You must say yes or no!");
                    answer = Console.ReadLine();
                }
            } while (answer.ToLower() == "yes");

            Console.WriteLine("\nGoodbye.");
        }
    }
    }

