using Aula5.CorralSnakeYellow.DomainModel;
using Aula5.CorralSnakeYellow.BusinessLayer;
using System;
using Aula5.CorralSnakeYellow.Repository.Interfaces;

namespace Aula5.CorralSnakeYellow.ScheduledTask
{
    class Program
    {
        private static readonly bool solaLettura;

        static Program()
        {
            solaLettura = DateTime.Now.Second % 2 == 0;
        }

        static void Main(string[] args)
        {
            IRepo repo = DependencyResolver.Get();
            Console.WriteLine("Sto accedendo al database con:");
            Console.WriteLine(repo.GetType().Name);

            var tabella = repo.Clienti;

            const int costante = 23;
            // int y = solaLettura * 2;
            // solaLettura = 90;

            ImpostazioniUtente.FavoriteColor = "Green";
            ImpostazioniUtente.ItemsNumber = 20;
            ImpostazioniUtente.Username = "igor.damiani";

            Cliente c1 = Cliente.Factory.Crea();
            string numero = c1.Stampa();

            CartaCredito miaCarta1 = Carta.Factory.CreateInstance("C") as CartaCredito;
            miaCarta1.Annulla();

            CartaDebito debito = new CartaDebito();
            debito.Annulla();
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

            Console.ReadLine();
        }
    }
}
