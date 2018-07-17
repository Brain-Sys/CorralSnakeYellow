using Aula5.CorralSnakeYellow.DomainModel;
using Aula5.CorralSnakeYellow.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula5.CorralSnakeYellow.Repository.SqlServer
{
    public class SqlServerRepo : IRepo
    {
        public IQueryable<Cliente> Clienti { get; set; }
        public IQueryable<ContoCorrente> ContiCorrente { get; set; }
    }
}