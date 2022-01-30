using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Microsoft.JSInterop;

namespace LotusTransformation.Services
{
    public class LogInPreValidation
    {
        private string EmailOrUsername;
        private string Password;


        public LogInPreValidation(string EmailOrUsername, string Password)
        {
            this.EmailOrUsername = EmailOrUsername;
            this.Password = Password;
        }


        //// TODO: Check if user is logging into their account with an email address (Regular Expressions) if it is not an email, then proceed with entry as if it were a user name
        //// TODO: Ensure that any entered data is escaped 
        //// TODO: see if Username/Email is in database before attempting password verification
        //// TODO: If checks clear, escape password for any unwanted characters (not allowed in password generation anyways)
        //// TODO: Check Password against matching username/email.
        //// TODO: 3 attempts before temporary lock out, prompt for password reset suggestion. 

        [JSInvokable]
        public static string UserNameOrEmail(string EmailOrUsername)
        {
            Regex email = new Regex("(?<user>[^@] +)@(?<host>.+)");
            if (email.IsMatch(EmailOrUsername))
            {
                return "Email";
            }
            else return "UserName";
        }
    }
}
