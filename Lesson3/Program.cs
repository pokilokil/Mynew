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
            List<string> man = new List<string>();
            Queue<string> vs = new Queue<string>();
            vs.Enqueue("aaa");
            vs.Enqueue("bbb");
            vs.Enqueue("ccc");
            //FIFO - first in first out 
            string res = vs.Dequeue();
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "aaa");
            keyValuePairs.Add(2, "bbb");

            string str1 ="Иванов Иван Иванович ; iviviv@mail.ru";
            string str2 = "Петров Петр Петрович ; petr@yandex.ru";
            string str3 = "Сергеев Сергей Сергеевич ; serega@yahoo.com";
            man.Add(str1);
            man.Add(str2);
            man.Add(str3);

            man.Sort();
            for (int i = 0; i < man.Count; i++)
            {
                Console.WriteLine(man[i]);
            }
            foreach (var strs in man)
            {
                string[] mails = strs.Split(';');
                string[] adress1s = mails[1].Split('@');
                if (adress1s[0]=="yandex.ru")
                {
                    //do something
                    Console.WriteLine(adress1s);
                    //прервать цикл
                    break;
                }
            }
            int ch = 0;
            while (ch!=2)
            {
                //if ch==1 
                //if ch==2
                if (ch == 3) break;
            }

            for (int i = 0; i < 10; i++)
            {
                //если и===1 я не хочу делать кучу действий но я хочу чтоб цикл продолжился дальше
                if (i == 1) continue;
                //many do
                //many do
            }
            string[] mail1 = str1.Split(';');
            Console.WriteLine(mail1[1]);
            string[] mail2 = str2.Split(';');
            Console.WriteLine(mail2[1]); 
            string[] mail3 = str3.Split(';');
            Console.WriteLine(mail3[1]);

            string[] adress1 = mail1[1].Split('@');
            Console.WriteLine(adress1[1]);
            string[] adress2 = mail2[1].Split('@');
            Console.WriteLine(adress2[1]);
            string[] adress3 = mail3[1].Split('@');
            Console.WriteLine(adress3[1]);
        }
    }
}