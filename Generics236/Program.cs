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
            Console.WriteLine("1.Find maximum Integer number \n2.Find maximum Float number \n3.Find Maximum String Value \n4.Refactor 1 \n5.Refactor 2 ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)             //Calling different methods using switch case
            {
                case 1:
                    int a,b, c;
                    Console.WriteLine("\nEnter Three Interger Values");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("a = {0}\t b = {1}\t c = {2} ",a,b,c);
                    FindMaxNumber.MaxInt(a,b,c);
                    break;
                case 2:
                    double p,q,r;
                    Console.WriteLine("\nEnter Three Float Values");
                    p = Convert.ToDouble(Console.ReadLine());
                    q = Convert.ToDouble(Console.ReadLine());
                    r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("p = {0}\t q = {1}\t r = {2} ", p, q, r);
                    double maxi = FindMaxNumber.MaxFloat(p,q,r);
                    Console.WriteLine("Maximum  Float Number is : {0}", maxi);
                    break;
                case 3:
                    string x,y,z;
                    Console.WriteLine("\nEnter Three String Values");
                    x = Console.ReadLine();
                    y = Console.ReadLine();
                    z = Console.ReadLine();
                    Console.WriteLine("x = {0}\t y = {1}\t z = {2} ", x, y, z);
                    string maxstring = FindMaxNumber.MaxString(x, y, z);
                    Console.WriteLine("Maximum  String Value is : {0}", maxstring);
                    break;
                case 4:
                    //Generics Method
                    int maxint = FindMaxNumber.GenericFindMax<int>(23, 23, 43);
                    Console.WriteLine("\n\tMaximum Interger Value is {0}", maxint);
                    Console.WriteLine("\n");
                    Console.WriteLine("----------------------------------------------------\n");
                    float maxfloat = FindMaxNumber.GenericFindMax<float>(23.6f, 40.3f, 60.6f);
                    Console.WriteLine("\n\tMaximum Float Value is {0}",maxfloat);
                    Console.WriteLine("\n");
                    Console.WriteLine("----------------------------------------------------\n");
                    string maxstrings = FindMaxNumber.GenericFindMax<string>("Apple", "Peach","Banana"); 
                    Console.WriteLine("\n\tMaximum String Value is {0}", maxstrings);            //According to ascii value strings are compared with each other
                    break;
                case 5:
                    //Generics Class
                    int maxInt = FindMaxNumbers<int>.getMaximum(23, 43, 13);
                    Console.WriteLine("\tMaximum Interger Value is {0}", maxInt+"\n");
                    float maxFloat = FindMaxNumbers<float>.getMaximum(2.3f, 5.3f, 11.3f);
                    Console.WriteLine("\tMaximum Float Value is {0}", maxFloat + "\n");
                    string maxString = FindMaxNumbers<string>.getMaximum("Apple", "Peach", "Banana");
                    Console.WriteLine("\tMaximum String Value is {0}", maxString);
                    break;
                default:
                    Console.WriteLine("Please enter correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}