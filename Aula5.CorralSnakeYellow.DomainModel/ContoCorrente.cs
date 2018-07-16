using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.CorralSnakeYellow.DomainModel
{
    public class ContoCorrente
    {
        public DateTime DataApertura { get; set; }
        public string Valuta { get; set; }
        public Cliente Cliente { get; set; }
        public double SaldoDisponibile { get; set; }
        public List<Movimento> Movimenti { get; set; }
    }
}