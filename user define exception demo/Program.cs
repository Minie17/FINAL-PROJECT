using System;

namespace user_define_exception_demo
{
    class Addition
    {
        public int Totalsum(int p, int q)
        {
            int sum = p + q;
            return sum;
        }
    }
    public class SecoundNumCantBeZeroException : ApplicationException
    {
        public SecoundNumCantBeZeroException(string message) : base(message)
        {

        }
    }
    class program
    {
        
        private static int res;
        static void Main(string []args)
        {
            int p, q;
            Console.WriteLine("Enter the first Number:");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the secound Number:");
            try
            {
                q = Convert.ToInt32(Console.ReadLine());
                Addition addition = new Addition();
                if (q == 0 || q >= 10000)
                {
                    throw (new SecoundNumCantBeZeroException("Enter number secound or next number grater than 1 and 10000"));

                }
                Addition Calculation  = new Addition();
                res = addition.Totalsum(p, q);
            }
            catch (SecoundNumCantBeZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The Total is {0}", res);
            }
        }
    }
}


