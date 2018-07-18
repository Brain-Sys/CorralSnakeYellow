using Aula5.CorralSnakeYellow.DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Aula5.CorralSnakeYellow.Anagrafiche.DomainModel
{
    public class CartaCreditoUI
    {
        // Variabile privata (field)
        private CartaCredito carta;
        private List<Movimento> ultimi5Movimenti;
        private ContoCorrente conto;

        // Evento

        // Proprietà
        [Required]
        public double Plafond
        {
            get
            {
                return carta.LimiteMensile;
            }
            set
            {
                carta.LimiteMensile = value;
            }
        }

        // Proprietà readonly
        public string FormattedPlafond
        {
            get
            {
                return "€." + this.Plafond;
            }
        }

        public double SaldoDiOggi
        {
            get
            {
                return this.conto.SaldoDisponibile;
            }
        }

        // Costruttori
        public CartaCreditoUI(CartaCredito carta)
        {
            this.carta = carta;
        }

        // Metodo
        public int SospendiContratto(string reason)
        {
            this.carta.Annulla();
            return 5;
        }
    }
}