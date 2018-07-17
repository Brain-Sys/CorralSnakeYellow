using Aula5.CorralSnakeYellow.DomainModel;
using System;

namespace Aula5.CorralSnakeYellow.ScheduledTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = Cliente.Factory.Crea();

            CartaCredito miaCarta1 = Carta.Factory.CreateInstance("C") as CartaCredito;
            //System.Threading.ThreadPool.QueueUserWorkItem();

            Carta miaCarta2 = Carta.Factory.CreateInstance("D");

            ContoCorrente conto = new ContoCorrente();
            Movimento mov = Movimento.Factory.Crea();
            mov.Data = DateTime.Now;
            mov.Importo = 170.23;

            //conto.CreaMovimento()







            
            OggettoDominio od = conto;

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
            io.Stampa();

            var cc = new CartaCredito();
            var cd = new CartaDebito().DataAttivazione.Month == 2;
        }
    }
}
