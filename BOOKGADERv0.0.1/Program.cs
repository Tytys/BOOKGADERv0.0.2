using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKGADERv0._0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "", newline = "";
            string path = "C:/Users/ififi/OneDrive/Документы/ProggrammText/BookGNIDA.txt";
            Random random = new Random();
            int x = 0;
            using(StreamReader read = new StreamReader(path))
            {
                line = read.ReadToEnd();
            }
            line = line?.Replace("старуха", "ГОВНЯК");
            line = line?.Replace("старик", "Я СРРУ");
            line = line?.Replace("колобок", "КАТЫШЕК ГОВНА");
            line = line?.Replace("Колобок", "КАТЫШЕК ГОВНА");
            line = line?.Replace("зай", "ПАДЛА");
            line = line?.Replace("заяц", "ПАДЛА");
            line = line?.Replace("волк", "ЖОПА С ГОВНОМ ФУУУУ");
            List<string> rep = new List<string>();
            string[] prikol = line.Split(' ');
            foreach (string a in prikol)
            {
                rep.Add(a);
            }
            for (int i = 0; i < 10; i++)
            {
                x += 15 + random.Next(10);
                rep.Insert(x, "ИИХИХИИ ПЕРДЕЖ");
            }
            foreach (string a in rep)
            {
                newline += a + " ";
            }
            using (StreamWriter writer = new StreamWriter("C:/Users/ififi/OneDrive/Документы/ProggrammText/BookGNIDA3.txt"))
            {
                writer.Write(newline);
            }
        }
    }
}
