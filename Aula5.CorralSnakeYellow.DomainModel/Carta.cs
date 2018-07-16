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
    }
}