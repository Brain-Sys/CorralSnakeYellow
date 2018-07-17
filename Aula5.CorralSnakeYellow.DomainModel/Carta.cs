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

        // camelCase    (privato)
        // PascalCase   (pubblico)
        public virtual void Annulla()
        {
            // Qui faccio tutto ciò che è in comune...
            // Log
            // Mail, telefonata
        }

        // Privato esternamente alla classe
        // Pubblico per carta e per le sue derivate
        // camelCase
        protected virtual void acquista()
        {

        }

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