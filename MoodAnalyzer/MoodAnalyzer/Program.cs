using System;

namespace MoodAnalyzer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MoodAnalyzer program");
            //UC_1- returning sad mood here
            MoodAnalyzerProgram analyzer = new MoodAnalyzerProgram("I am in sad mood");
            Console.WriteLine(analyzer.Analyzer());
        }
    }
}
