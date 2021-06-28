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
            object resultobj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyzer.MoodAnalyser", "MoodAnalyser");
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
        //TestCase-5.1
        [Test]
        public void Given_MoodAnalyser_Class_Name_Should_Return_MoodAnalyser_Object_Using_Parametrized_Constructor()
        {
            //Arrange
            string className = "MoodAnalyzer.MoodAnalyser";
            string constructorName = "MoodAnalyser";
            MoodAnalyzerProgram expectedObj = new MoodAnalyzerProgram("HAPPY");
            //Act
            object resultObj = MoodAnalyzerFactory.CreateMoodAnalyserObjectUsingParametzisedConstructor(className, constructorName);
            //Assert
            expectedObj.Equals(resultObj);
        }
        //TestCase-5.2
        [Test]
        public void Given_Wrong_Class_Name_Should_Throw_MoodAnalysisException_For_Parameterized_Constructor()
        {
            try
            {
                //Arrange
                string className = "WrongNameSpace.MoodAnalyser";
                string constructorName = "MoodAnalyser";
                MoodAnalyzerProgram expectedObj = new MoodAnalyzerProgram("HAPPY");
                //Act
                object resultObj = MoodAnalyzerFactory.CreateMoodAnalyserObjectUsingParametzisedConstructor(className, constructorName);
            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Class Not Found", e.Message);
            }
        }
        //TC5.3:-Pass Wrong Constructor parameter, cactch the Exception and throw indicating No such method Error
        [Test]
        public void Given_Improper_Constructor_Name_Should_Throw_MoodAnalysisException_For_Parameterized_Constructor()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyzer.MoodAnalyser";
                string constructorName = "WrongConstructorName";
                MoodAnalyzerProgram expectedObj = new MoodAnalyzerProgram("HAPPY");
                //Act
                object resultObj = MoodAnalyzerFactory.CreateMoodAnalyserObjectUsingParametzisedConstructor(className, constructorName);
            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Class Not Found", e.Message);
            }
        }


    }
}