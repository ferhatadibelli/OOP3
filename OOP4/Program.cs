using System;
using System.Collections.Generic;

namespace OOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            KrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
       
            KrediManager tasitKrediManager = new TasitKrediManager();
           
            KrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);

            List<KrediManager> krediler = new List<KrediManager>() { ihtiyacKrediManager, tasitKrediManager };


            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
        }
    }

    
}
