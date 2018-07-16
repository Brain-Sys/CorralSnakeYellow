using System;
using System.Collections.Generic;

namespace Aula5.CorralSnakeYellow.DomainModel
{
    public class ContoCorrente : OggettoDominio
    {
        public DateTime DataApertura { get; set; }
        public string Valuta { get; set; }
        public Cliente Cliente { get; set; }
        public double SaldoDisponibile { get; set; }
        public List<Movimento> Movimenti { get; set; }
    }
}