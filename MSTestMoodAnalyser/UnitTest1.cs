using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Analyse_Mood;

namespace MSTestMoodAnalyser
{/// <summary>
 /// TC3.1 Nullmood Using CustomException Return Null
 /// </summary>
    [TestClass]
    public class UnitTest1
    {/// <summary>
     /// TC3.1 Nullmood Using CustomException Return Null
     /// </summary>
        [TestMethod]
        public void Given_Nullmood_Using_CustomException_Return_Null()
        {
            //Arrange;
            AnalyseMood mood = new AnalyseMood(null);
            string expected = "Mood should not be null";
            try
            {
                //Act
                string actual = mood.AnalyserMethod();
            }
            catch (MoodAnalyserException exception)
            {
                //Asert
                Assert.AreEqual(expected, exception.Message);
            }
        }
        /// <summary>
        /// TC3.2 Emptymood Using CustomException Return empty
        /// </summary>
        [TestMethod]
        public void Given_Emptymood_Using_CustomException_Return_Empty()
        {
            //Arrange;
            AnalyseMood mood = new AnalyseMood("");
            string expected = "Mood should not be empty";
            try
            {
                //Act
                string actual = mood.AnalyserMethod();
            }
            catch (MoodAnalyserException exception)
            {
                //Asert
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}