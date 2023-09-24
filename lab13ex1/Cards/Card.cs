using System;

namespace lab13ex1.Cards
{
     class Card
    {
        private readonly Guid id;

        public Card()
        {
            this.id = Guid.NewGuid();   
        }

        public Guid Id { get => id; }  /* sau {get{return id};}*/

        public void IntroduCard() =>
            Console.WriteLine("Am introdus cardul");

        public void ExtrageCard() =>
           Console.WriteLine("Am extras cardul");
    }
}
