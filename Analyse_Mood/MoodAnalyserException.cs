using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyse_Mood
{
        public class MoodAnalyserException : Exception
        {
            /// <summary>
            /// Enum of exception type.
            /// </summary>
            /// creating type variable of type ExceptionType
            ExceptionType type;
            public enum ExceptionType
            {
                NULL_EXCEPTION, EMPTY_EXCEPTION
            }
            /// <summary>
            /// parameterized contructor sets the Exception Type and message.
            /// </summary>
            public MoodAnalyserException(ExceptionType type, string message) : base(message)
            {
                this.type = type;
            }
        }
    }


