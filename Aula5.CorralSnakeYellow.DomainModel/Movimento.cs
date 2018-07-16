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
    }
}