using Aula5.CorralSnakeYellow.Anagrafiche.DomainModel;
using Aula5.CorralSnakeYellow.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.CorralSnakeYellow.Anagrafiche.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            CartaCredito cc = new CartaCredito();
            CartaCreditoUI carta = new CartaCreditoUI(cc);
            carta.Plafond = 800;
        }
    }
}