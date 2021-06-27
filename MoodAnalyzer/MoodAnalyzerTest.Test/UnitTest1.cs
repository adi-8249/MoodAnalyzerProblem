using MoodAnalyzer;
using NUnit.Framework;


namespace MoodAnalyzerTest.Test
{
    public class Tests
    {

        [Test]// Test case 1.1
        public void method_Returns_sad_mood()
        {
            //Arrange
            string expeted = "sad";
            //Act
            MoodAnalyzerProgram analyzer = new MoodAnalyzerProgram("I am in sad mood");
            //Assert
            Assert.AreEqual(expeted, analyzer.Analyzer());
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
        public void Null_Mood_Return_Happy()
        {
            //Arrange
            string expected = "Happy";
            //Act
            MoodAnalyzerProgram moodAnalyser = new MoodAnalyzerProgram(null);
            //Assert
            Assert.AreEqual(expected, moodAnalyser.Analyzer());
        }
    }
}