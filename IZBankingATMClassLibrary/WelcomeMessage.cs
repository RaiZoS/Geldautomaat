using System;
using System.Collections.Generic;
using System.Text;

namespace IZBankingATMClassLibrary
{
    public class WelcomeMessage
    {
        public static void AdminWelcomeMessage(string Data)
        {
            Console.WriteLine("je naam is " + AdminInfo.AdminName);

        }

        public string welcomeMessage()
        {
            return "Welkom " + AdminInfo.AdminName + ", kies een van de opties.";
        }
    }
}
