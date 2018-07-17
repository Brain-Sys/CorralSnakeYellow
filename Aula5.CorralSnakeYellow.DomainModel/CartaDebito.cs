using Aula5.CorralSnakeYellow.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.CorralSnakeYellow.DomainModel
{
    public class CartaDebito : Carta, IAggregateRoot
    {
        public override void Annulla()
        {
            base.Annulla();
            // Log
            // Mail, telefonata
            // Aggiornamento database XYZ
            // gdngdfngkjdfn
        }
    }
}