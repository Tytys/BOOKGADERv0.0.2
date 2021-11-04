using System;

namespace BOOKGADERv0._0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathIn = "C:/Users/ififi/OneDrive/Документы/ProggrammText/BookGNIDA.txt";
            string pathOut = "C:/Users/ififi/OneDrive/Документы/ProggrammText/BookGNIDA1.txt";

            TextOut textOut = new TextOut(pathIn);
            string line = textOut.TextProchitan();

            TextReplacer replacer = new TextReplacer();
            line = replacer.PutRandomInText(line);

            TextIn textIn = new TextIn(pathOut);
            textIn.TextWrite(line);
        }
    }   
}
