using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "Good bue";
            string str3 = "Hi,Aloha,Privet";
            Console.WriteLine(str1[0]);
            Console.WriteLine(String.IsNullOrEmpty(str2));
            Console.WriteLine(str2.ToLower());
            Console.WriteLine(str2.ToUpper());
            Console.WriteLine(str2.Contains ("Bue"));
            Console.WriteLine(str2.StartsWith ("Good"));
            Console.WriteLine(str2.EndsWith("Bye"));
            Console.WriteLine(str1.Insert (5, " world"));
            Console.WriteLine(str1.Remove (4));
            Console.WriteLine(str1.Replace ("llo", "y"));
            string[] greetings = str3.Split(',');
            Console.WriteLine(greetings[2]);
            Console.ReadLine();
        }
    }
}
