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
            Console.WriteLine("1.Find maximum Integer number \n2.Find maximum Float number \n3.Find Maximum String Value ");
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
                case 2:
                    double p,q,r; 
                    p = Convert.ToDouble(Console.ReadLine());
                    q = Convert.ToDouble(Console.ReadLine());
                    r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("p = {0}\t q = {1}\t r = {2} ", p, q, r);
                    double maxi = FindMaxNumber.MaxFloat(p,q,r);
                    Console.WriteLine("Maximum  Float Number is : {0}", maxi);
                    break;
                case 3:
                    string x,y,z;
                    x = Console.ReadLine();
                    y = Console.ReadLine();
                    z = Console.ReadLine();
                    Console.WriteLine("x = {0}\t y = {1}\t z = {2} ", x, y, z);
                    string maxstring = FindMaxNumber.MaxString(x, y, z);
                    Console.WriteLine("Maximum  String Value is : {0}", maxstring);
                    break;
                default:
                    Console.WriteLine("Please enter correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}