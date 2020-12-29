using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ClassSeparator separator = new ClassSeparator();
                Console.WriteLine("Enter text");
                string text = Console.ReadLine();
                
                Console.WriteLine(separator.ReverseWordWithoutSymbol(text));
            }
        }
        
    }


}
