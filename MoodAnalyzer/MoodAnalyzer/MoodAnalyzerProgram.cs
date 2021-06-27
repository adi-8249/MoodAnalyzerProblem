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
            try //this block will test for exception
            {
                if (this.message.Contains("sad"))
                {
                    return "sad";
                }
                if (this.message.Contains("Happy"))
                {
                    return "Happy";
                }
                if (this.message.Contains(null))
                {
                    return "Happy";
                }
            }

            catch // this block will catch the exception if there
            {
                return "Happy";
            }
            return null;
        }
    }
}
