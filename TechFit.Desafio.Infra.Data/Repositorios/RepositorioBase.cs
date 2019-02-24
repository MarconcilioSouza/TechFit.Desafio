using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TechFit.Desafio.Infra.Data.Repositorios
{
    public class RepositorioBase : IDisposable
    {
        public IDbConnection TechFitConnection
        {
            get
            {
                return new SqlConnection(ConfigurationManager
                    .ConnectionStrings["TechFitEntities"]
                    .ConnectionString);
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
