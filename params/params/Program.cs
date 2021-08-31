using System;

namespace param
{ 
    class Program
{
    static void Main(string[] args)
    {
        int add1 = Addition(1);
        int add2 = Addition(2, 2, 2, 2);
        int[] addarray = new int[3] { 3, 3, 3 };
        int add3 = Addition(addarray);

    }

    static int Addition(params int[] values)
    {
        int answer = 0;
        foreach (int value in values)
        {
            answer += value;
        }
        return answer;
    }
}
}
