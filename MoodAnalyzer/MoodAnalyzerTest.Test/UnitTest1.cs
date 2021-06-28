using MoodAnalyzer;
using NUnit.Framework;
using System.Runtime.Serialization;


namespace MoodAnalyzerTest.Test
{
    public class Tests
    {
        [Test]// Test case 1.1
        public void method_Returns_sad_mood()
        {
            //Arrange
            string expected = "Sad";
            //Act
            MoodAnalyzerProgram analyzer = new MoodAnalyzerProgram("I am in Sad mood");
            //Assert
            Assert.AreEqual(expected, analyzer.Analyzer());
        }
        [Test]//Test case 1.2
        public void Method_Returns_Happy_mood()
        {
            //Arrange
            string expected = "Happy";
            //Act
            MoodAnalyzerProgram analyzer = new MoodAnalyzerProgram("I am in Happy Mood");
            //Assert
            Assert.AreEqual(expected, analyzer.Analyzer());
        }
        [Test]//Test case 2.1
        public void NullMood_Return_Happy()
        {
            //Arrange
            string expected = "Mood should not Empty";
            //Act
            MoodAnalyzerProgram moodAnalyser = new MoodAnalyzerProgram("");
            string actual = moodAnalyser.Analyzer();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        //Test case:- 3.1
        public void Given_Empty_Mood_Should_Thow_Mood_AnalysisException()
        {
            try
            {
                string message = "";
                MoodAnalyzerProgram moodAnalyser = new MoodAnalyzerProgram(message);
                string mood = moodAnalyser.Analyzer();
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual("Mood Should not Empty", ex.Message);
            }
        }
        [Test]
        //Test case 3.2-:
        public void GivenEmptyUsingCustomException()
        {
            //Arrange
            string expected = "Mood should not Empty";
            //Act
            MoodAnalyzerProgram moodAnalyser = new MoodAnalyzerProgram("");
            string actual = moodAnalyser.Analyzer();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}