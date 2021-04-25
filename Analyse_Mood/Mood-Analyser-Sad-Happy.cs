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
        public AnalyseMood(string message)//Add Method 
        {
            this.message = message;//Instance Variable           
        }
        public string Analyser()//Add Method
        {
            //ToLower to return copy of the string
            if (this.message.ToLower().Contains("happy"))
            {
                //If Happy Print 
                return "happy";
            }
            else
            {
                //If not Happy Print 
                return "sad";
            }
        }
    }
}