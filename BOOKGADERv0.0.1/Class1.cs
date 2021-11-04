using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BOOKGADERv0._0._1
{
    // Класс с операциями
    public class TextReplacer
    {
        // Ввод и проверка числа, число ли это
        static int In(string s)
        {
            bool True;
            int x;

            do
            {
                Console.WriteLine(s);
                True = int.TryParse(Console.ReadLine(), out x);
            } while (!True);
            return x;
        }

        // Делаем первую букву заглавной
        static string FirstUpper(string str)
        { 

            string[] s = str.Split(' ');

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > 1)
                {
                    s[i] = s[i].Substring(0, 1).ToUpper() + s[i].Substring(1, s[i].Length - 1).ToLower();
                }
                else
                {
                    s[i] = s[i].ToUpper();
                }
            }
            return string.Join(" ", s);
        }

        // Замена определенных слов текса на другие
        static string Replacer(string stroke)
        {
            bool True;
            string slovFirst, slovZamena;

            Console.WriteLine("");
            int kol = In("Введите кол во слов которые вы хотите испоганить");
            for (int i = 0; i < kol; i++)
            {
                Console.WriteLine($"Слово номер {i + 1}");

                do
                {
                    Console.WriteLine("Введите слово которое вы хотите заменить");
                    slovFirst = Console.ReadLine();

                    True = slovFirst != "" ? false : true;
                    if (True)
                    {
                        Console.WriteLine("Вы ничего не ввели");
                    }

                } while (True);


                do
                {
                    Console.WriteLine("Введите слово которым вы хотите заменить это слово");
                    slovZamena = Console.ReadLine();
                    True = slovZamena != "" ? false : true;
                    if (True)
                    {
                        Console.WriteLine("Вы ничего не ввели");
                    }
                } while (True);

                string slovFirstUp = FirstUpper(slovFirst);
                string slovFirstDown = slovFirst.ToLower();

                stroke = stroke?.Replace(slovFirst, slovZamena);
                stroke = stroke?.Replace(slovFirstUp, slovZamena);
                stroke = stroke?.Replace(slovFirstDown, slovZamena);
            }
            return stroke;
        }

        // Вводим текст который будет случайным словом
        public string PutRandomInText(string str)
        {

            str = Replacer(str);

            Random random = new Random();
            string[] Words = str.Split(' ');

            str = string.Empty;

            string rndWord = InRandomText();
            int first = RandomGenerator(out int second);

            foreach (string word in Words)
            {
                if (random.Next(first) > second)
                {
                    str += (rndWord + " ");
                }
                else
                {
                    str += word + " ";
                }
            }
            return str;
        }

        // Тоже самое что ввод числа, только мы вводим рандомное слово и проверяем
        static string InRandomText()
        {
            bool True;
            string str;
            do
            {
                Console.WriteLine("Введите слово которое будет заменять случайное слово в тексте");
                str = Console.ReadLine();
                True = str != "" ? false : true;
                if (True)
                {
                    Console.WriteLine("Вы ничего не ввели");
                }
            } while (True);
            return str;
        }

        // Делаем частоту рандома
        static int RandomGenerator(out int num2)
        {
            bool True;
            int num1 = 0;
            do
            {
                Console.WriteLine("Введите частоту случайного слова: 1 - часто, 2 - средне, 3 - мало");
                string chas = Console.ReadLine();
                if (chas == "1")
                {
                    num1 = 1;
                    num2 = 0;
                    True = false;
                }
                else if (chas == "2")
                {
                    num1 = 6;
                    num2 = 4;
                    True = false;
                }
                else if (chas == "3")
                {
                    num1 = 20;
                    num2 = 15;
                    True = false;
                }
                else
                {
                    Console.WriteLine("Введите 1, 2 или 3");
                    num2 = 0;
                    True = true;
                }
            } while (True);
            return num1;
        }
    }

    // Читаем файл
    public class TextOut
    {
        string path;
        public string TextProchitan()
        {
            string line;
            using (StreamReader read = new StreamReader(path))
            {
                line = read.ReadToEnd();
            }
            return line;
        }
        public TextOut(string In)
        {
            this.path = In;
        }
    }

    // Пишем в файл
    public class TextIn
    {
        string path;
        public void TextWrite(string line)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(line);
            }
        }
        public TextIn(string In)
        {
            this.path = In;
        }
    }
}
