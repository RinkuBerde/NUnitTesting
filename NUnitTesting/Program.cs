namespace NUnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to  NUnit Testing Program!!!");
            Console.WriteLine("\t\t\t\t Programs for N-Unit Testing");
            Console.WriteLine("1. Find the day of the week");
            Console.WriteLine("2. Convert the temperature to either Fahrenheit/Celcius");
            Console.WriteLine("3. Derive the monthly payments as per provided data");
            Console.WriteLine("------------------------------------------------------------------");
            Console.Write("Enter the option : ");
            int option = Convert.ToInt32(Console.ReadLine());
            dayOfWeek nunit = new dayOfWeek();
            switch (option)
            {
                case 1:
                    dayOfWeek.CalculateDay();
                    break;
                case 2:
                    temperaturConversion.CalculateTemperature();
                    break;
                case 3:
                    MonthlyPayment.PaymentCalculation();
                    break;
                default:
                    Console.WriteLine("Please Enter from the given choice");
                    break;
            }
        }
    }
}