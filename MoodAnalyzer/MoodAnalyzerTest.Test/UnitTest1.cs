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
    }
}