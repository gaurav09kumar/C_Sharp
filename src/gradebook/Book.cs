using System;
using System.Collections.Generic;
namespace gradebook{
    class Book{
         List <double>marks = new List<double>();
       
        public string student_name="";
        
        public void Student(string n){
            student_name=n;
        }
        public void AddMarks(double mark){
                System.Console.WriteLine(mark);
                marks.Add(mark);
        } 
        public void showStats(){
            var highestMark= double.MinValue;
            var lowestmark=double.MaxValue;
            var result=0.0;
            foreach(var number in marks){
                //find the highest marks for a student
                if(number>highestMark){
                    highestMark=number;
                }
                //lowest marks for a student;
                lowestmark=Math.Min(number,lowestmark);
                //adding up all the marks
                result+=number;
            }
            //calculating average
            result /=marks.Count;
            System.Console.WriteLine($"The highest mark is: {highestMark}");
            System.Console.WriteLine($"The lowest mark is: {lowestmark}");
            System.Console.WriteLine($"{result:N2}");
        }
    }
}