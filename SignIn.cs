using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeApp
{
    public class SignIn
    {
        public string Authenticate(string username, string password)
        {
            string msg;
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) 
            {
                msg = "User name and password required"; 
                    
             }  
            else
            {
                if((username=="Mama") && (password=="Mama@123"))
                {
                    msg = "Authentication Pass";
                }
                else
                {
                    msg = "Authentication Fail";
                }
            }
            return msg;
        }
    }
}
