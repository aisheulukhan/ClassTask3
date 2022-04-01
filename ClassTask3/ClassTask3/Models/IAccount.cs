using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask3.Models
{
    interface IAccount
    {
       public static bool PasswordChecker(string password)
       {
            return false;
       }
        
       public void ShowInfo();

    }
}
