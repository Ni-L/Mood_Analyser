using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserReflection;

namespace MSTestMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
     
            /// <summary>
            /// Test Case 7.1
            /// set Happy message with Reflector should return HAPPY
            /// </summary>
            [TestMethod]
            public void WhenHappyMessage_ShouldReturnHappy()
            {
                dynamic result = MoodAnalyserFactory.ChangeMoodDynamically("MoodAnalyser.MoodAnalyserMain", "HAPPY");
                Assert.AreEqual("HAPPY", result);
            }

            /// <summary>
            /// Test Case 7.2 set field when improper should throw Exception 
            /// </summary>
            [TestMethod]
            public void WhenImproperMessage_ShouldThrowException()
            {
                try
                {
                    string message = MoodAnalyserFactory.ChangeMoodDynamically("MoodToAnalyse.getMood","Happy");
                }
                catch (MoodAnalyserException e)
                {
                    Assert.AreEqual(MoodAnalyserException.ExceptionType.INVALID_INPUT, e.Message);
                }
            }

            /// <summary>
            /// Test Case 7.3 setting Null message with Reflector should throw Exception
            /// </summary>
            [TestMethod]
            public void WhenNull_ShouldThrowException()
            {
                try
                {
                    dynamic result = MoodAnalyserFactory.ChangeMoodDynamically("MoodAnalyzer.MoodAnalyser", null);
                }
                catch (MoodAnalyserException e)
                {
                    Assert.AreEqual(MoodAnalyserException.ExceptionType.NULL_EXCEPTION, e.Message);
                }
            }
        }
    }
