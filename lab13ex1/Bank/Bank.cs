using lab13ex1.Cards;
using lab13ex1.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;


namespace lab13ex1.Bank
{
    class BankSingleton
    {
        #region singleton
        private static BankSingleton instance = null;

        public static BankSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BankSingleton();
                }
                return instance;
            }

        }


        private BankSingleton()
        {

        }
        #endregion


       private List<Cont> conturi=new List<Cont>();
       private int conexiuniActive = 0;


        public Guid CreeazaCont()
        {
            var cont = new Cont();
            conturi.Add(cont);
            return cont.Id;
        }

        public Card EmiteCard(Guid idCont)
        {
           var cont= conturi.Find(c=>c.Id == idCont);
            if(cont==null)
            {
                throw new ContInvalidException();
            }

            var card = new Card();
            cont.AddCard(card);
            return card;
        }


        public void DepuneNumerar(Guid contId,double suma)
        {
            var cont=conturi.Find(c => c.Id == contId);
            if (cont == null)
            {
                throw new ContInvalidException();
            }
            cont.DepunereNumerar(suma);
        }


        public void PlatesteDinCont(Guid contId, double suma)
        {
            var cont = conturi.Find(c => c.Id==contId);
            if (cont == null)
            {
                throw new ContInvalidException();
            }
            cont.ExtragereNumerar(suma);
        }



        public void Plateste(Guid cardId,double suma)
        {
           var cont= conturi.Find(c=>c.DetineCard(cardId));
            if (cont == null)
            {
                throw new ContInvalidException();
            }
            cont.ExtragereNumerar(suma);
        }

        public void Connect()
        {
            if (conexiuniActive > 2)
            {
                throw new TooManyConnectionsException();
            }
            conexiuniActive++;
        }

        public void Disconnect()
        {
            conexiuniActive--;
        }
    }
}
