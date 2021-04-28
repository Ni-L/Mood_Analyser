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
            NULL_EXCEPTION, EMPTY_EXCEPTION, CONSTRUCTOR_NOT_FOUND, CLASS_NOT_FOUND, NO_SUCH_METHOD, NO_SUCH_FIELD, NULL_MESSAGE, FIELD_NULL, NULL
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


