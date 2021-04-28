using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Analyse_Mood;

namespace MSTestMoodAnalyser
{/// <summary>
 ///         //UC4-reflection to create mood analyser
 /// </summary>
    [TestClass]
    public class UnitTest1
    {/// <summary>
     /// TC4.1 Given MoodAnalyser Class Name Should Return MoodAnalyser Object
     /// </summary>
        [TestMethod]
        public void Given_MoodAnalyserClass_Name_ShouldReturn_MoodAnalyserObject()
        {
            string message = null;
            object expected = new AnalyseMood(message);
            MoodAnalyzerFactory factory = new MoodAnalyzerFactory();
            object obj = factory.CreateMoodAnalyzerObject("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }
        /// <summary>
        ///  TC 4.2:- Given Class Name When Improper Should Throw MoodAnalysisException
        /// </summary>
        [TestMethod]
        public void Given_MoodAnalyseClass_GivenWrongClassName_ShouldReturn_NOClassException()
        {
            string expected = "Class not found";
            try
            {
                string message = null;
                object moodAnalyser = new AnalyseMood(message);
                MoodAnalyzerFactory factory = new MoodAnalyzerFactory();
                object obj = factory.CreateMoodAnalyzerObject("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
                moodAnalyser.Equals(obj);
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
        /// <summary>
        /// TC 4.3:- Given Class When Constructor Not Proper Should Throw MoodAnalysisException
        /// </summary>
        [TestMethod]
        public void Given_MoodAnalyseClass_GivenWrongConstructorName_ShouldReturn_NoConstructorException()
        {
            string expected = "Constructor not found";
            try
            {
                string message = null;
                object moodAnalyser = new AnalyseMood(message);
                MoodAnalyzerFactory factory = new MoodAnalyzerFactory();
                object obj = factory.CreateMoodAnalyzerObject("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
                moodAnalyser.Equals(obj);
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
    }
}