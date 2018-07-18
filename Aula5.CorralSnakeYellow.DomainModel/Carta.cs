using Aula5.CorralSnakeYellow.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.CorralSnakeYellow.DomainModel
{
    public class Carta : OggettoDominio, IAggregateRoot, IDisposable, IEquatable<Carta>
    {
        public DateTime DataAttivazione { get; set; }
        public Cliente Cliente { get; set; }
        public ContoCorrente Conto { get; set; }
        public byte[] Foto { get; set; }

        // camelCase    (privato)
        // PascalCase   (pubblico)
        public virtual void Annulla()
        {
            // Qui faccio tutto ciò che è in comune...
            // Log
            // Mail, telefonata
        }

        public void Dispose()
        {
            // Ripulite a mano la memoria
            this.Foto = null;
        }

        public bool Equals(Carta other)
        {
            return this.ID == other.ID;

            if (this.ID == other.ID)
                return true;
            else
                return false;
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

                #region Programmazione difensiva
                // Difensiva
                // if
                #endregion

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