using System;

namespace Lesson5
{
    internal class ParkCarException : Exception
    {
        public ParkCarException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Ctor for inner exception
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public ParkCarException(string message, Exception ex)
        : base(message, ex)
        {
        }

    }
}