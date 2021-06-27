using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyzerProgram
    {
        public string message;
        /// <summary>
        /// Creating constructor and passing parameter
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalyzerProgram(string message)
        {
            this.message = message;
        }
        public string Analyzer()
        {
            if (this.message.Contains("sad"))
            {
                return "sad";
            }
            if (this.message.Contains("Happy"))
            {
                return "Happy";
            }
            return null;
        }
    }
}
