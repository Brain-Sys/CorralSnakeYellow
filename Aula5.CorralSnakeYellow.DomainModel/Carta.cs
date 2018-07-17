using Aula5.CorralSnakeYellow.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.CorralSnakeYellow.DomainModel
{
    public class Carta : OggettoDominio, IAggregateRoot
    {
        public DateTime DataAttivazione { get; set; }
        public Cliente Cliente { get; set; }
        public ContoCorrente Conto { get; set; }

        // Classe factory
        public static class Factory
        {
            public static Carta CreateInstance(string tipoCarta)
            {
                Carta c;

                if (tipoCarta.ToUpper() == "D")
                {
                    c = new CartaDebito();
                }
                else if (tipoCarta.ToUpper() == "C")
                {
                    CartaCredito cc = new CartaCredito();
                    cc.LimiteMensile = 430;
                    c = cc;
                }
                else
                {
                    throw new ArgumentException("Carta non riconosciuta!");
                }

                return c;
            }
        }
    }
}