using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.CorralSnakeYellow.DomainModel
{
    public class Carta
    {
        public DateTime DataAttivazione { get; set; }
        public Cliente Cliente { get; set; }
        public ContoCorrente Conto { get; set; }
    }
}