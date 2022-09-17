using System;

namespace Strings
{
    class Program
    {
        public static string Reversestring(string str1)
        {
            char[] chars = str1.ToCharArray();
            for (int i = 0, j = str1.Length - 1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }
            return new string(chars);
        }
        public static string Extract(string str1)
        {
            string chars= str1.Substring(2);
            return new string(chars);
        }
        public static string Replacestring(string str1,char l)
        {
            char[] chars = str1.ToCharArray();
            for (int i = 0;i<chars.Length ; i++)
            {
                if (chars[i] == l)
                {
                    chars[i] = '$';
                }
            }
            return new string(chars);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the operation\n1-Reverse a String\n2-Extract part of string from 2nd to end\n3-replace a char by $\n4-Modify and print both the strings");
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Console.WriteLine(Reversestring(str));
                    break;
                case 2:
                    Console.WriteLine(Extract(str));
                    break;
                case 3:
                    Console.WriteLine("Enter the Letter");
                    char a = Console.ReadLine()[0];
                    Console.WriteLine(Replacestring(str,a));
                    break;
                case 4:
                    Console.WriteLine("Enter the String to replace");
                    string strrps = Console.ReadLine();
                    Console.WriteLine("Enter the String to replace with");
                    string strrp = Console.ReadLine();
                    var replacement = str.Replace(strrps, strrp);
                    Console.WriteLine($"The source string is <{str}>");
                    Console.WriteLine($"The updated string is <{replacement}>");
                    break;
                default:
                    break;
            }

        }
    }
}
