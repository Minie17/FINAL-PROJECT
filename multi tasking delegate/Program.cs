using System;

namespace multi_tasking_delegate
{
    public delegate void multidelegate(int num1, int num2);
}
 public class Program
{
    public static void add(int p, int q)
    {

        Console.WriteLine("The result is :" + (p + q));
       }
          static void sub(int p, int q)
        {
         Console.WriteLine("The result is:" +(p - q));
        }
          static void mul(int p, int q)
        {
         Console.WriteLine("The result is:" + (p * q));
        }
          static void div(int p, int q)
        {
         Console.WriteLine("The result is:" + (p / q));
        }
  
    
