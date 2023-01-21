namespace NUnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to  NUnit Testing Program!!!");
            Console.WriteLine("\t\t\t\t Programs for N-Unit Testing");
            Console.WriteLine("1. Find the day of the week");
            Console.WriteLine("------------------------------------------------------------------");
            Console.Write("Enter the option : ");
            int option = Convert.ToInt32(Console.ReadLine());
            dayOfWeek nunit = new dayOfWeek();
            switch (option)
            {
                case 1:
                    dayOfWeek.CalculateDay();
                    break;
                default:
                    Console.WriteLine("Please Enter from the given choice");
                    break;
            }
        }
    }
}