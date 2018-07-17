using Aula5.CorralSnakeYellow.Interfaces;
using System;
using System.Collections.Generic;

namespace Aula5.CorralSnakeYellow.DomainModel
{
    public class Cliente : OggettoDominio, IAggregateRoot
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string Nazionalità { get; set; }
        public List<ContoCorrente> Conti { get; set; }

        public Cliente()
        {
            this.Nazionalità = "IT";
            this.Conti = new List<ContoCorrente>(5);
        }

        public Cliente(string cognome)
        {
            this.Cognome = cognome;
        }

        public Cliente(string cognome, string nome)
        {
            this.Cognome = cognome;
            this.Nome = nome;
        }

        public void Stampa()
        {
            int pagine = calcolaPagine();
            preparaTestata();
            preparaPièDiPagina();
        }

        private byte[] preparaTestata()
        {
            return null;
        }

        private byte[] preparaPièDiPagina()
        {
            return null;
        }

        private int calcolaPagine()
        {
            return 1;
        }

        // Classe di factory
        public static class Factory
        {
            private static int usedInstances = 0;
            private static List<Cliente> PoolDiClienti { get; set; }

            // Costruttore statico, chiamato automaticamente
            // dal framework al primo utilizzo di Factory
            static Factory()
            {
                PoolDiClienti = new List<Cliente>(1000);
                for (int i = 0; i < PoolDiClienti.Capacity; i++)
                {
                    PoolDiClienti.Add(new Cliente());
                }
            }

            public static Cliente Crea()
            {
                // Bisognerebbe controllare che non si raggiunga il limite degli oggetti nel pool
                Cliente c = PoolDiClienti[usedInstances++];
                return c;
            }
        }
    }
}