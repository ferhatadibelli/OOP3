using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(KrediManager krediManager, ILoggerService loggerService)
        {
            //Basvuran bilgilerini değerlendirme 

            // 

            
            krediManager.Hesapla();
            loggerService.Log();

        }

        public void KrediOnBilgilendirmesiYap(List<KrediManager> krediler)
        {

            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
       

        }
    }
}
