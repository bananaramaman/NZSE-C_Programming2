using System;

namespace TextTypingDelayExample
{
    class Program
    {
        public static void Main(String[] args)
        {
            var myString = "...Initializing Text repsonses..."+"\n"+"\n"+"\n"+"\n"+"Hello Mr.Anderson..."+"\n"+"\n"+"We missed you...";
            foreach (var character in myString)
            {
                Random waitTime = new Random();
                int seconds = waitTime.Next(10,250);

                Console.Write(character);
                System.Threading.Thread.Sleep(seconds);
            }
            Console.ReadKey();
        }
    }
}
