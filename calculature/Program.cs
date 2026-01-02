using System;
namespace program
{
    class Program
    {

        static void Main(string[] args)
        {


            GetNumberPrint("first");
            int num0 = Convert.ToInt32(Console.ReadLine());
            GetNumberPrint("second");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter for ADD  + or A or a, Sub - or S or s, for mull * or M or m: ");
            var operation = Console.ReadLine();

            
            if(operation == "+" || operation == "A"|| operation == "a")
            {
                GetResult(num0, num1, operation, num0 + num1);
            }

            if (operation == "-" || operation == "S" || operation == "s")
            {
                GetResult(num0, num1, operation, num0 + num1);

            }

            if (operation == "*" || operation == "M" || operation == "m")
            {
                int result = num0 * num1;
                Console.WriteLine(num0 + "*" + num1 + "=" + result);
            }

            void GetNumberPrint(string order)
            {
                Console.Write($"please Eneter {order} Input: ");
            }

            void GetResult(int num0, int num1, string operation,int result)
            {
                Console.WriteLine($"{num0} {operation} {num1} = {result}");

            }







        }
    }


}