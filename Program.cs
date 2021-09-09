using System;

namespace Hw_12
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>("-1");
            for (int i = 0; i < 20; i++)
            {
                linkedList.Add(i.ToString());
            }
            foreach (var item in linkedList) 
            {
                Console.WriteLine("\t"+item);
            }
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
