using MoodAnalyzer;
using NUnit.Framework;
using System;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

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
        [Test]//TestCase-4.1 
        public void GivenMoodAnalyserClassName_WhenAnalse_ShouldReturnObject()
        {
            //Arrange
            string message = null;
            //Act
            object expected = new MoodAnalyzerProgram(message);
            object resultobj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyzer.MoodAnalyzer", "MoodAnalyser");
            //Assert
            expected.Equals(resultobj);
        }
        [Test]
        //TC4.2:-Given class Name when improper should throw MoodAnalyserCustomException
        public void Given_Improper_Class_Name_Should_Throw_MoodAnalyserCustomException_Indicating_No_Such_Class()
        {
            try
            {
                //Arrange
                string className = "WrongNamespace.MoodAnalyser";
                string constructorName = "MoodAnalyser";
                //Act
                object resultObj = MoodAnalyzerFactory.CreateMoodAnalyse(className, constructorName);
            }
            catch (MoodAnalyserCustomException ex)
            {
                //Assert
                Assert.AreEqual("Class Not Found", ex.Message);
            }
        }
        [Test]
        //TC4.3:-Given class when constructor improper should throw MoodAnalysisException
        public void Given_Improper_Constructor_Name_Should_Throw_MoodAnalyserCustomException_Indicating_No_Such_Constuctor()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyzer.MoodAnalyser";
                string constructorName = "WrongConstructorName";
                //Act
                object resultObj = MoodAnalyzerFactory.CreateMoodAnalyse(className, constructorName);
            }
            catch (MoodAnalyserCustomException ex)
            {
                //Assert
                Assert.AreEqual("Constructor is not Found", ex.Message);
            }
        }
    }
}