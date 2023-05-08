using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bs_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] arr = new int[5];
            Console.WriteLine("array is");

            for (int i = 0; i< arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            //bubble sorting

            for (int j= 0; j<arr.Length-2; j++)
            {
                for(int i =0;i<= arr.Length-2;i++)
                {

                    count = count + 1;
                    if (arr[i] > arr[i+1])
                    {
                        int tem = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i+1] = tem; 
                    }
                }
            }



            Console.WriteLine("sorted array is");
            foreach (int it in arr)
            {
                Console.WriteLine(it+" ");  
            }
            Console.WriteLine();
            Console.WriteLine("Loop iterates "+ count);

            Console.WriteLine();




        }
    }
}
