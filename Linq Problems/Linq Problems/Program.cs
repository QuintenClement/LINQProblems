using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var outputList = words.Where(x => x.Contains("th")).ToList();
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }



            List<string> classGrades = new List<string>()
           {
           "80,100,92,89,65",
           "93,81,78,84,69",
           "73,88,83,99,64",
           "98,100,66,74,55"
           };

            var gradeAverage = classGrades.ToList();
            List<int> studentGrade = new List<int>();
            double studentGradeAverage = 0;
            foreach (var result in gradeAverage)
            {
                studentGrade = result.Split(',').Select(m => int.Parse(m)).ToList();
                //Console.WriteLine(result);
                var studentAverage = studentGrade.Where(x => x != studentGrade.Min()).Average();
                studentGradeAverage += studentAverage;
            }
            Console.WriteLine("Class Average is: " + studentGradeAverage / 4);
            Console.ReadLine();



            string userInput = Console.ReadLine();
            var counts = from x in userInput
                         group x by x into y
                         select y;

            foreach (var ArrEle in counts)
            {
                Console.WriteLine("Character " + ArrEle.Key + ": " + ArrEle.Count() + " times");
            }
            Console.ReadLine();
            




        }
    }
}
