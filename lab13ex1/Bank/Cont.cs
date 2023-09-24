using lab13ex1.Cards;
using lab13ex1.Exceptions;
using System;
using System.Collections.Generic;


namespace lab13ex1.Bank
{
    class Cont
    {
        private readonly Guid id =Guid.NewGuid();
        private double sold = 0.0;

        public Guid Id { get=>id;}

        private List<Card> cards = new List<Card>();


        
        public void AddCard(Card c)
        {
            if (cards.Count >= 2)
            {
                throw new TooManyCardtException();
            }


            cards.Add(c); 
        }

        public bool DetineCard(Guid cardId)
        {
            return cards.Exists(c=>c.Id==cardId);
        }

        public void DepunereNumerar(double suma)

         => sold += suma;

        

        public  double ExtragereNumerar(double suma)
        {
            if (suma <= sold)
            {
                sold -= suma;
                return suma;
            }
            throw new InsufficientFundsException();
        }

    }

}
