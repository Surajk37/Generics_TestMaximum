using Generics236;

namespace Generics
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("\t\t\t----------------------------\n\t\t\tWelcome To Generics Problems\n\t\t\t----------------------------\n");
            Console.WriteLine("\n\tPlease enter an option");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1:Find integer maximum number");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Three Values");

            switch (option)             //Calling different methods using switch case
            {
                case 1:
                    int a,b, c;
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("a = {0}\t b = {1}\t c = {2} ",a,b,c);
                    FindMaxNumber.MaxInt(a,b,c);
                    break;
                default:
                    Console.WriteLine("Please enter correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}