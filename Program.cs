//using System;

//namespace H6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int c = 0;
//       do
//            try
//            {
//                Console.WriteLine("Enter 2 numbers");
//                int a = Convert.ToInt32(Console.ReadLine());
//                int b = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine($"{Div(a, b)}");
//                    c = 0;
//            }
//            catch (DivideByZeroException ex)
//            {
//                Console.WriteLine(ex.Message);
//                c = 1;
//            }
//            catch (FormatException ex)
//            {
//                Console.WriteLine(ex.Message);
//                    c = 1;
//            }
//            while (c > 0);

//            static int Div(int a, int b)
//            {
//                return a / b;
//            }



//        }
//    }
//}
//using System;

//namespace H6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int c = 0;
//            do
//                try
//                {
//                    Console.WriteLine("Enter 2 numbers");
//                    double a = Convert.ToInt32(Console.ReadLine());
//                    double b = Convert.ToInt32(Console.ReadLine());
//                    if (a==0 || b==0) throw new ApplicationException("Enter numbers > than 0");
//                    Console.WriteLine($"{Div(a, b)}");
//                    c = 0;
//                }
//                catch (ApplicationException ex)
//                {
//                    Console.WriteLine(ex.Message);
//                    c = 1;
//                }

//            while (c > 0);

//            static double Div(double a, double b)
//            {
//                return a / b;
//            }



//        }
//    }
//}
using System;

namespace H6
{
    class Program
    {
          static int[] ReadNumber(int start, int end)
        {
            int[] a = new int [10];
            int c = 0;
            int min = 0;

            do
                try
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("Enter number");
                        a[i] = Convert.ToInt32(Console.ReadLine());
                        if (a[i] < start || a[i] > end) throw new ApplicationException("Enter new 10 numbers, >0 and <100");
                        if (a[i] <= min)
                        {
                            min = 0;
                            throw new ApplicationException("Enter new 10 numbers, number > previous number");
                        }
                        else min = a[i];
                        c = 0;
                    }
                    
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine(ex.Message);
                    c = 1;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Enter new 10 numbers");
                    c = 1;
                }

            while (c > 0);
            return a;

        }
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int[] result = ReadNumber(start,end);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
