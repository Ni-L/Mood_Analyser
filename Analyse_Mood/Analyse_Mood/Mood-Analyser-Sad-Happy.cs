using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyse_Mood
{/// <summary>
 /// Create Class For Analyse Mood
 /// </summary>
    public class AnalyseMood
    {
        //Add Instance Variable string type
        public string message;

        public AnalyseMood(string message)//Parametrised Constructor 
        {
            this.message = message;//Instance Variable           
        }
        //Default Constructor
        public string AnalyserMethod()//Add Method
        {
            //NULL Scenario using try catch and return Happy
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty");
                }
                if (this.message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException)
            {
                //return ex.Message;
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_EXCEPTION, "Mood should not be null");
            }
        }

    }
}