using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromicString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            if (str.Length > 100 || str.Length <= 0)
                return;
            else
            {
                string lowerStr = str.ToLowerInvariant();
                char[] charArr = lowerStr.ToCharArray();

                if ((str.Length % 2) == 0)
                {
                    //even logic
                    int i = 0;
                    for (int j = str.Length - 1; j > 0; j--)
                    {
                        if (charArr[i] == charArr[j])
                        {
                             i++;
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("YES");
                    Console.ReadLine();
                }
                else
                {
                    //odd logic 
                    int i = 0;
                    for (int j = str.Length - 1; j > str.Length / 2; j--)
                        {
                            if (charArr[i] == charArr[j])
                            {
                                i++;
                                j--;
                            }
                            else
                            {
                                Console.WriteLine("NO");
                                Console.ReadLine();
                                return;
                            }
                        }
          
                    Console.WriteLine("YES");
                    Console.ReadLine();
                }

            }
        }
    }
}
