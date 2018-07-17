using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.CorralSnakeYellow.DomainModel
{
    public class Movimento : OggettoDominio
    {
        public DateTime Data { get; set; }
        public double Importo { get; set; }
        public ContoCorrente Conto { get; set; }

        // Ctor privato
        private Movimento()
        {

        }

        // Classe factory
        public static class Factory
        {
            // Metodo statico factory
            public static Movimento Crea()
            {
                Movimento m = new Movimento();
                m.Data = DateTime.Now;
                return m;
            }

            // Metodo statico factory
            public static Movimento Crea(DateTime data, double importo)
            {
                Movimento m = new Movimento();
                m.Data = data;
                m.Importo = importo;
                return m;
            }
        }
    }
}