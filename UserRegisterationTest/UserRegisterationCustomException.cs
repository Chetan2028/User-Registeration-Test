using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegisterationTest
{
    public class UserRegisterationCustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRSTNAME,INVALID_LASTNAME,INVALID_MOBILENUMBER,INVALID_PASSWORD,INVALID_EMAIL
        }

        public ExceptionType type;

        public UserRegisterationCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
