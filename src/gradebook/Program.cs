using System;
using System.Collections.Generic;
namespace gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1=new Book();
            book1.Student("Rahul");
            book1.AddMarks(98.0);
            book1.AddMarks(80.7);
            book1.AddMarks(45.6);
            book1.AddMarks(77.6);
            book1.showStats();
            
        }
    }
}