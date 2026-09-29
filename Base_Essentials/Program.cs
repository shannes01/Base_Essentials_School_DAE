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
                string ?option = Essentials.ReadAndWrite.ReadlineWithDefault("choose an option:", "Empty");
                switch (option)
                {
                    case "1":
                        Calculator();
                        break;
                    case "2":
                        return;
                    case "Empty":
                        Console.WriteLine("Please choose an option.");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            } while (true);
        }
        static void Calculator()
        {
            Console.WriteLine("1. BaseCalculator");
            Console.WriteLine("2. PowerCalculator");
            Console.WriteLine("3. RootCalculator");
            Console.WriteLine("4. Exit");
            string? option = Essentials.ReadAndWrite.ReadlineWithDefault("choose an option:", "Empty");
            switch (option)
            {
                case "1":
                    BaseCalculation();
                    break;
                case "2":
                    Power();
                    break;
                case "3":
                    root();
                    break;
                case "4":
                    return;
                case "Empty":
                    Console.WriteLine("Please choose an option.");
                    Calculator();
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    Calculator();
                    break;
            }
        }
        static void root()
        {
            string number = Essentials.ReadAndWrite.ReadlineWithDefault("give number:", "0");
            string root = Essentials.ReadAndWrite.ReadlineWithDefault("give root:", "2", true);
            Console.WriteLine($"{number} root {root} = {Essentials.Calculator.CalculateRoot(number, root)}");
        }
        static void Power()
        {
            string number = Essentials.ReadAndWrite.ReadlineWithDefault("give number:", "0");
            string power = Essentials.ReadAndWrite.ReadlineWithDefault("give power:", "2", true);
            Console.WriteLine($"{number}^{power} = {Essentials.Calculator.CalculateSquare(number, power)}");
        }
        static void BaseCalculation()
        {
            string number = Essentials.ReadAndWrite.ReadlineWithDefault("give number:", "0");
            string number2 = Essentials.ReadAndWrite.ReadlineWithDefault("give number2:", "0");
            string operator_ = Essentials.ReadAndWrite.ReadlineWithDefault("give operator:", "+");
            Console.WriteLine($"{number} {operator_} {number2} = {Essentials.Calculator.CalculateToString(number, number2, operator_)}");
        }
    }
}
