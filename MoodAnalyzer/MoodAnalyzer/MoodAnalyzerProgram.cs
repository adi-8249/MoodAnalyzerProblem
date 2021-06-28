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
            try 
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not Empty");
                }
                if (this.message.Contains("Sad")) //Contains is inbuilt method
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not null");
            }
            catch (MoodAnalyserCustomException exception)
            {
                return exception.Message;
            }
        }
    }
}
