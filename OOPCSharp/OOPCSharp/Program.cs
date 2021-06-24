using System;

namespace OOPCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] lines = { "This is line1", "This is line2", "This is line3" };
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(@"D:\C-AndDotNet\OOPCSharp\OOPCSharp\some.text"))
            {
                foreach(var line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
