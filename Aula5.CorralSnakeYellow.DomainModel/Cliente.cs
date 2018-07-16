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
    }
}