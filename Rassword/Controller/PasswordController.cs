using Rassword.Model;
using Rassword.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rassword.Controller
{
    public class PasswordController
    {
        Display myDisplay = new Display();
        Password myPassword;

        public PasswordController()
        {
            myDisplay.Input();
            myPassword = new Password(myDisplay.N, myDisplay.L);
            myDisplay.GeneratePassword = myPassword.GeneratePassword();
            myDisplay.Output();
        }
    }
}

