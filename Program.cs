using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int, string> myList = new MyList<int, string>();
            myList.Add(600, "Ali");
            myList.Add(601, "Ayşe");
            myList.Add(602,"Hakan");
            myList.Add(603, "Asya");
            myList.Add(604, "Fatma");

            Console.WriteLine(myList.Count);
        }
    }
}
