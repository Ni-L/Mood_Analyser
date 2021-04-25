using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Analyse_Mood;

namespace MSTestMoodAnalyser
{/// <summary>
/// Creating TestCase1 of UnitTest1 for Dispalying I am in sad mood
/// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TC2.1 nullmood should return happy
        /// </summary>
        [TestMethod]
        public void Given_nullmood_Expecting_Happy_Results()
        {
            //Arrange;
            AnalyseMood mood = new AnalyseMood(null);
            string expected = "happy";

            //Act
            string actual = mood.AnalyserMethod();

            //Asert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC2.1 nullmood should return happy
        /// </summary>
        [TestMethod]
        public void GivenNull_Expecting_Happy_Results()
        {
            //Arrange;
            AnalyseMood mood = new AnalyseMood(null);
            string expected = "happy";

            //Act
            string actual = mood.AnalyserMethod();

            //Asert
            Assert.AreEqual(expected, actual);
        }
    }
}
   