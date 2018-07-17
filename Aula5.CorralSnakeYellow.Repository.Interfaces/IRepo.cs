using Aula5.CorralSnakeYellow.DomainModel;
using System;
using System.Linq;
// LINQ = Language INtegrated Query

namespace Aula5.CorralSnakeYellow.Repository.Interfaces
{
    public interface IRepo
    {
        IQueryable<Cliente> Clienti { get; set; }
        IQueryable<ContoCorrente> ContiCorrente { get; set; }
    }
}