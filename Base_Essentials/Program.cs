using Essentials;

namespace Base_Essentials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("1. Calculator");
                Console.WriteLine("2. Exit");
                Console.Write("Choose an option: ");
                string option = Console.ReadLine() ?? "2";
                switch (option)
                {
                    case "1":
                        Calculator();
                        break;
                    case "2":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            } while (true);
        }

        static void Power()
        {
            Console.Write("give number:");
            string number = Console.ReadLine() ?? "0";
            Console.Write("\ngive power:");
            string power = Console.ReadLine() ?? "0";
            Console.WriteLine($"{number}^{power} = {Essentials.Calculator.CalculateSquare(number, power)}");
        }

        static void BaseCalculation()
        {
            Console.Write("give number1:");
            int number1 = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("\ngive number2:");
            int number2 = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("\ngive operator:");
            string operator_ = Console.ReadLine() ?? "+";
            Console.WriteLine($"{number1} {operator_} {number2} = {Essentials.Calculator.CalculateToString(number1, number2, operator_)}");
        }

        static void Calculator()
        {
            Console.WriteLine("1. baseCalculator");
            Console.WriteLine("2. PowerCalculator");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string subOption = Console.ReadLine() ?? "1";
            switch (subOption)
            {
                case "1":
                    BaseCalculation();
                    break;
                case "2":
                    Power();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    Calculator();
                    break;
            }
        }
    }
}
