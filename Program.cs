using System;
using System.Collections.Generic;

namespace Daily_Coding_Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Given a list of numbers and a number k, 
             * return whether any two numbers 
             * from the list add up to k.
             */
            List<int> list = new List<int> { 0, 1, 2, 3, 4, 5 };
            int K = 9;
            Console.WriteLine(Function(list, K));//9 is the limiting sum in this list
        }
        static bool Function(List<int> list,int K)
        {
            //carry out the revision of the possible sums by brute force method in the most optimal way in my opinion
            for (int numA = 0; numA < list.Count-1; numA++)
                for (int numB = numA + 1; numB < list.Count; numB++)
                    if (list[numA] + list[numB] == K)
                        return true;
            return false;
        }
    }
}
