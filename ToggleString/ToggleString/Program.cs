using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToggleString
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = string.Empty;
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            char[] charArray = str.ToCharArray();
            for(int i=0;i<str.Length;i++)
            {
                if (char.IsLower(charArray[i]))
                {
                    temp = temp + charArray[i].ToString().ToUpper();
                }
                else
                {
                    temp = temp + charArray[i].ToString().ToLower();
                }
            }
            Console.WriteLine(temp);
            Console.ReadLine();

        }
    }
}
