using lab13ex1.Bank;
using lab13ex1.Cards;
using lab13ex1.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab13ex1
{
     class Pos
    {
        public void Plateste(Card card, double sumaDePlata)
        {
            Connect();
          
            try
            {
                card.IntroduCard();
                BankSingleton.Instance.Plateste(card.Id, sumaDePlata);
                Console.WriteLine($"Plata de {sumaDePlata} a fost efectuata cu succes");
            }
            finally
            {
                card.ExtrageCard();
                BankSingleton.Instance.Disconnect();
            }
        }

        private void Connect()
        {
            var connected = false;
            int incercari = 0;
            while (!connected && incercari < 2)
            {
                incercari++;
                try
                {
                    BankSingleton.Instance.Connect();
                    connected = true;
                }
                catch
                {

                }
            }
            if (!connected)
            {
                throw new CannotConnectToBankException();
            }
        }

    }
}
