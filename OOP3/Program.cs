﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacCreditManager = new IhtiyacCreditManager();
            

            ICreditManager tasitCreditManager = new TasitCreditManager();
            

            ICreditManager konutCreditManager = new KonutCreditManager();
            BasvuruManager basvuruManager = new BasvuruManager();
            

            List<ICreditManager> credits = new List<ICreditManager>() { ihtiyacCreditManager};
            basvuruManager.KrediOnBilgilendirmesiYap(credits);

        }
    }
}
