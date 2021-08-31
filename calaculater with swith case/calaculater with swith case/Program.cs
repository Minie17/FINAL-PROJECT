using System;

namespace calaculater_with_swith_case
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, result, op;
                Convert.ToChar(Console.ReadLine());
                Console.WriteLine("-------Calculater--------");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Enter [number 1] [+ - * /] [number 2]");
                
            switch (op)
                { 
                    case '+':
                    result = num1 + num2;
                    Console.WriteLine("the sum is {0}", result);
                        break;
                    
                     case '-':
                        result = num1 - num2;
                    Console.WriteLine("the sum is{0}", result);
                        break;

                    case '*':
                        result = num1 * num2;
                    Console.WriteLine("the sum is{0}", result);
                        break;

                    case '/':
                        result = num1 / num2;
                    Console.WriteLine("the sum is{0}", result);
                        break;

                    default:
                    Console.WriteLine("Invalid operator");
                        break;
                }

                Console.WriteLine("%.2f %c %.2f = %.2f",num1, num2 );
            }
    }
}
