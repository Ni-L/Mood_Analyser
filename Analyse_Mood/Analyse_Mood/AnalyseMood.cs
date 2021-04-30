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
        string message;

        /// <summary>
        /// parameterless constructor
        /// </summary>
        public AnalyseMood()
        {
        }

        /// <summary>
        /// Parameterised constructor for initializing instance member
        /// </summary>
        public AnalyseMood(string message)
        {
            this.message = message;
        }


        ///Analyser method to find mood        
        public string Analyser(string message)
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be EMPTY");
                }
                if (this.message.Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_EXCEPTION, "Mood should not be NULL");
            }
        }

    }
}