using Aula5.CorralSnakeYellow.DomainModel;
using System;

namespace Aula5.CorralSnakeYellow.ScheduledTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ContoCorrente conto = new ContoCorrente();

            if (DateTime.Now.Day == 16)
            {
                conto = new ContoCorrente();
                conto.Cliente = null;
            }
            else
            {
                // conto = leggereDaFileCsv();
            }

            conto.DataApertura = DateTime.Now;

            Cliente io = new Cliente();
            io.Cognome = "Rossi";
            io.Nome = "Mario";
            io.DataNascita = new DateTime(1976, 2, 28);

            var cc = new CartaCredito();
            var cd = new CartaDebito().DataAttivazione.Month == 2;


            cc = null;
            cc.LimiteMensile = 560;
        }
    }
}
