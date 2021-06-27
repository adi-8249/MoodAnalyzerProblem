using MoodAnalyzer;
using NUnit.Framework;


namespace MoodAnalyzerTest.Test
{
    public class Tests
    {
        [Test]
        public void method_Returns_sad_mood()
        {
            //Arrange
            string expeted = "sad";
            //Act
            MoodAnalyzerProgram analyzer = new MoodAnalyzerProgram("I am in sad mood");
            //Assert
            Assert.AreEqual(expeted, analyzer.Analyzer());
        }
        [Test]
        public void Method_Returns_Happy_mood()
        {
            //Arrange
            string expected = "Happy";
            //Act
            MoodAnalyzerProgram analyzer = new MoodAnalyzerProgram("I am in Happy Mood");
            //Assert
            Assert.AreEqual(expected, analyzer.Analyzer());
        }
    }
}