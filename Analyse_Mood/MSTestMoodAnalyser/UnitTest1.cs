using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Analyse_Mood;

namespace MSTestMoodAnalyser
{/// <summary>
 /// //Tc5.1Given MoodAnalyser When Proper Return MoodAnalyser Object       
 /// </summary>
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenHappyMessage_UsingReflection_Should_ReturnHappy()
        {
            string message = MoodAnalyzerFactory.InvokeMethod("MoodAnalyzer.MoodAnalyser", "GetMood", "HAPPY");
            Assert.AreEqual("HAPPY", message);
        }

        /// <summary>
        /// Test Case 6.2 
        /// Given Happy message when improper method should throw MoodAnalyserException
        /// </summary>
        [TestMethod]
        public void GivenHappyMessage_UsingReflection_WhenIncorrectMethod_shouldThrow_MoodAnayserException()
        {
            try
            {
                string message = MoodAnalyzerFactory.InvokeMethod("MoodAnalyzer.MoodAnalyser", "getMethod", "HAPPY");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.INVALID_INPUT, e.Message);
            }
        }
    }
}
