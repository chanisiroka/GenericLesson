using System;

namespace GenericLesson
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Check<int> checkInt = new Check<int>();
            bool check = checkInt.Compare(3, 4);
            Console.WriteLine(check);
            Console.WriteLine();
            Console.WriteLine("bla bla...");
            Check<string> checkStr = new Check<string>();
            Console.WriteLine(checkStr.Compare("aaaa", "aaaa"));
            Console.WriteLine("my change ....dov siroka....");
            Console.WriteLine("bla bla...");
            Console.Read();
        }
    }
}
