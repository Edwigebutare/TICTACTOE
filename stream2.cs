using System;

namespace stream2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string Date = DateTime.Today.ToString("D");



            //put intro here in form of xxxxx(); ( make a static void for xxxxxx())



            while (true)
            {
                input = Console.ReadLine();
                if (input == "start")
                    break;




            }
            using (StreamWriter Journal = new StreamWriter(Date + ".txt", true))
            {
                Console.Clear();
                Console.WriteLine("Start writing");



                while (true)
                {
                    input = Console.ReadLine();
                    if (input == "stop") break;
                    Journal.WriteLine(input);
                    Journal.Flush();



                }
            }
    }
}
