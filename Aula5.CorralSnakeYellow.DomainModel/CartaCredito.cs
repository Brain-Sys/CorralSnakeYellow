using Aula5.CorralSnakeYellow.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.CorralSnakeYellow.DomainModel
{
    public class CartaCredito : Carta, IAggregateRoot
    {
        public double LimiteMensile { get; set; }

        public override void Annulla()
        {
            // throw new InvalidOperationException();
        }
    }
}