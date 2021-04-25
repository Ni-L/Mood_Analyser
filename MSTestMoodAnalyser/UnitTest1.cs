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
        [TestMethod]
        //Adding Method 
        public void Given_Sad_Mood_message()
        {
            //Arrange
            //Creating Object of Class 
            AnalyseMood mood = new AnalyseMood("I am in Sad Mood");
            //expected sad message
            string expected = "sad";

            //Act
            //actual value present in analyser
            string actual = mood.Analyser();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        // Creating TestCase2 of UnitTest1 for Dispalying I am in happy mood
        [TestMethod]
        //Adding Method 
        public void Given_Happy_Mood_message()
        {
            //Arrange
            //Creating Object of Class
            AnalyseMood mood2 = new AnalyseMood("I am in happy Mood");
            //expected sad message
            string expected = "happy";

            //Act
            //actual value present in analyser
            string actual = mood2.Analyser();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}