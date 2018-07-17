using Aula5.CorralSnakeYellow.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Aula5.CorralSnakeYellow.BusinessLayer
{
    public static class DependencyResolver
    {
        public static IRepo Get()
        {
            string tipo = ConfigurationManager.AppSettings["ActiveRepo"];
            Type t = Type.GetType(tipo);

            if (t != null)
            {
                // Metodo Factory
                IRepo obj = Activator.CreateInstance(t) as IRepo;

                return obj;
            }
            else
            {
                return null;
            }
        }
    }
}