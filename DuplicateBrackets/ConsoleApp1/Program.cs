using System;

namespace ConsoleApp1
{
    public static class Program
    {
        public static string DuplicateEncode(string word)
        {
            string nword = word.ToLower();
            for (int j = 0; j < nword.Length; j++)
            {
                for (int k = j + 1; k < nword.Length; k++)
                {
                    if (nword[j] == nword[k] && j != k)
                    {
                        nword = nword.Replace(nword[j], ')');
                    }
                }
            }
        
            Console.WriteLine(nword);
            return nword;
        }
        static void Main(string[] args)
        {
            DuplicateEncode("() ");
        }
    }
}