using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            //First of all sorry for my bad English :( 
            //Thank you for looking

            //*Integer Area*//

            double result = 0, x = 0, y = 0;
            byte select = 0;

        //*******************//

        //*Process Selecting Area*//

        SelectingAreaOut:

            try
            {

            SelectingArea:

                Console.WriteLine("1-Addition");
                Console.WriteLine("2-Substraction");
                Console.WriteLine("3-Multiplication");
                Console.WriteLine("4-Division");
                Console.WriteLine("Please Choose a Math Process : ");
                select = Convert.ToByte(Console.ReadLine());

                //*******************//

                //*Function Calling Area*//

                if (select == 1)
                {
                    Console.Clear();
                    result = Addition(x, y);
                    Console.WriteLine("Result is = " + result);
                    Console.WriteLine("Press Any Key to Go to Start");
                    Console.ReadKey();
                    Console.Clear();
                    goto Start;
                }
                if (select == 2)
                {
                    Console.Clear();
                    result = Subtraction(x, y);
                    Console.WriteLine("Result is = " + result);
                    Console.WriteLine("Press Any Key to Go to Start");
                    Console.ReadKey();
                    Console.Clear();
                    goto Start;
                }
                if (select == 3)
                {
                    Console.Clear();
                    result = Multiplication(x, y);
                    Console.WriteLine("Result is = " + result);
                    Console.WriteLine("Press Any Key to Go to Start");
                    Console.ReadKey();
                    Console.Clear();
                    goto Start;
                }
                if (select == 4)
                {
                    Console.Clear();
                    result = Division(x, y);
                    Console.WriteLine("Result is = " + result);
                    Console.WriteLine("Press Any Key to Go to Start");
                    Console.ReadKey();
                    Console.Clear();
                    goto Start;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please Select Numbers Between 1-4\n Press Any Key to Continue");
                    Console.ReadKey();
                    Console.Clear();
                    goto SelectingArea;
                }

            }
            catch (Exception Error)
            {
                Console.WriteLine("Error : " + Error);
                Console.WriteLine("Please Select Numbers Between 1-4\n Press Any Key to Continue");
                Console.ReadKey();
                Console.Clear();
                goto SelectingAreaOut;
            }

            //*******************//
        }













        //*Function Area*//

        //I'm using Functions for cleaning my code spaces

        static double Addition(double x, double y)
        {
            Console.Write("Please Enter Number 1 : ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter Number 2 : ");
            y = Convert.ToDouble(Console.ReadLine());
            return x + y;
        }
        static double Subtraction(double x, double y)
        {
            Console.Write("Please Enter Number 1 : ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter Number 2 : ");
            y = Convert.ToDouble(Console.ReadLine());
            return x - y;
        }
        static double Multiplication(double x, double y)
        {
            Console.Write("Please Enter Number 1 : ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter Number 2 : ");
            y = Convert.ToDouble(Console.ReadLine());
            return x * y;
        }
        static double Division(double x, double y)
        {
            Console.Write("Please Enter Number 1 : ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter Number 2 : ");
            y = Convert.ToDouble(Console.ReadLine());
            if (y == 0)
            {
                Console.WriteLine("Infinite");
                return 0;
            }
            return x / y;
        }
        //*******************//
    }
}
