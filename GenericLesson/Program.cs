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

            Check<string> checkStr = new Check<string>();
            Console.WriteLine(checkStr.Compare("aaaa", "aaaa"));
            Console.Read();
        }
    }
}
