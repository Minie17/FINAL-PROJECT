using System;

namespace delegate_example
{
    class Program
    {
        public delegate void addnum(int a, int b);
        public delegate void mulnum(int a, int b);
        public void sum(int a, int b)
        {
            Console.WriteLine("(34+45)={0}", a + b);
        }
        public void mul(int a, int b)
       {
            Console.WriteLine("(3*17)={0}", a * b);
        }
        public static void Main(String[] args)
        {
            Program obj = new Program();
            addnum del_obj1 = new addnum(obj.sum);
            mulnum del_obj2 = new mulnum(obj.mul);
            del_obj1(34, 45);
            del_obj2(3, 17);
        }
    }
}
