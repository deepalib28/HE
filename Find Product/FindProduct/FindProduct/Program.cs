using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindProduct
{
    class Program
    {

        static void Main(string[] args)
        {
            int answer = 1;
            Console.WriteLine("Enter Array length");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[len];
            if (len < 1 || len > 1000)
                return;

            else
            {
                Console.WriteLine("Enter array elements");
                string str = Console.ReadLine();
                string[] arr = str.Split();
                //string[] arr = Console.ReadLine().Split();
                for (int i = 0; i < arr.Length; i++)
                    a[i] = int.Parse(arr[i]);
            }

            for (int j = 0; j < a.Length; j++)
            {
                int exp = ((10 ^ 9) + 7);
                answer = ((answer * a[j]) % exp) + ((answer * a[j] / exp) * exp);

            }

            Console.WriteLine(answer);
            Console.ReadLine();
        }
        //static void Main(string[] args)
        //{
        //     int  answer = 1;
        //    Console.WriteLine("Enter Arrey length");
        //    int len = Convert.ToInt32(Console.ReadLine());
        //    int[] a = new int[len];
        //    if (len < 1 || len > 1000)
        //        return;

        //    else
        //    {
        //        Console.WriteLine("Enter array elements");
        //        for (int i = 0; i <= len - 1; i++)
        //        {
        //             a[i] = Convert.ToInt32(Console.ReadLine());
        //          
        //        }

        //        for (int j = 0; j < a.Length; j++)
        //        {
        //            int exp = ((10 ^ 9) + 7);
        //            answer = ((answer*a[j])%exp)+((answer*a[j]/ exp) * exp);

        //            //-- other approach--

        //            //int temp = ((answer*a[j])%exp);
        //            //int temp1 = ((answer * a[j] / exp)*exp);
        //            //  answer = temp + temp1;
        //        }
        //    }
        //    Console.WriteLine(answer);
        //    Console.ReadLine();
        //}


        //-------------
        //input           output
        //5                 120
//1 2 3 4 5    
    }
}
