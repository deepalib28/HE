using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolitaryString
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter string");
        //    string str=Console.ReadLine();
        //    int temp=0,temp1 = 0;
        //    int flag = 0;
        //    char[] string1 = str.ToCharArray();
        //    for (int i = 0; i < string1.Length-1; i++)
        //    {
        //        for (int j = string1.Length-1; j >=0; j--)
        //        {
        //            if (string1[i] == string1[j])
        //            {
        //             //count   
        //                temp1 = (j - i) - 1;
        //                if (temp1 > temp)
        //                {
        //                    temp = temp1;
        //                    flag = 1;
        //                }

        //            }

        //        }
        //    }

        //    if (flag == 0)
        //    {
        //        Console.WriteLine("1");
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(temp);
        //        Console.ReadLine();
        //    }
        //}




        static void Main(string[] args)
        {
            List<string> strList=new List<string>();
            //Console.WriteLine("Enter no of testcase");
            int testcases= Convert.ToInt32(Console.ReadLine());
            for (int z = 0; z < testcases; z++)
            {
          //      Console.WriteLine("Enter string");
                strList.Add(Console.ReadLine());
            }
            foreach (var str in strList)
            {
                int temp = 0, temp1 = 0;
                int flag = 0;
                char[] string1 = str.ToCharArray();
                for (int i = 0; i < string1.Length - 1; i++)
                {
                    for (int j = string1.Length - 1; j >= 0; j--)
                    {
                        if (string1[i] == string1[j])
                        {
                            //count   
                            temp1 = (j - i) - 1;
                            if (temp1 > temp)
                            {
                                temp = temp1;
                                flag = 1;
                            }

                        }

                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("1");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(temp);
                    Console.ReadLine();
                }
            }
          
        }

        //testing 
    }
}
