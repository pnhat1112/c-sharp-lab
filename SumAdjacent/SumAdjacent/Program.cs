using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Number in Array List");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int i;
            Console.WriteLine("-----------------------------------------");

            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Elements in array are: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");
            var numberList = arr.ToList();
            for (i = 0; i < numberList.Count - 1; i++)
            {
                if (numberList[i] == numberList[i + 1])
                {
                    numberList[i] = numberList[i] + numberList[i + 1];
                    numberList.Remove(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine("Elements in array are: ");
            for (i = 0; i < numberList.Count; i++)
            {
                Console.Write("{0}  ", numberList[i]);
            }
        }
    }
}