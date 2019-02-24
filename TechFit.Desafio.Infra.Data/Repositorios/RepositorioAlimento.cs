using Dapper;
using System.Collections.Generic;
using System.Linq;
using TechFit.Desafio.Dominio.Entidades;
using TechFit.Desafio.Dominio.Interfaces.Repositorios;

namespace TechFit.Desafio.Infra.Data.Repositorios
{
    public class RepositorioAlimento : RepositorioBase, IRepositorioAlimento
    {  
        public void Adicionar(Alimento obj)
        {
            using (var conn = TechFitConnection)
            {
                obj.IdAlimento = conn.Execute(@"INSERT INTO Alimento(Nome, QtdGramas, Calorias, Carboidratos, Proteinas, GordurasTotais,
                GordurasSaturadas, FibraAlimentar, Sodio, Medida, Tag) 
                VALUES(@Nome, @QtdGramas, @Calorias, @Carboidratos, @Proteinas, @GordurasTotais, @GordurasSaturadas, @FibraAlimentar, 
                @Sodio, @Medida, @Tag)", obj);
            }
        }

        public void Alterar(Alimento obj)
        {
            using (var conn = TechFitConnection)
            {
                obj.IdAlimento = conn.Execute(@"Update Alimento
                set Nome = @Nome, 
                    QtdGramas = @QtdGramas, 
                    Calorias = @Calorias, 
                    Carboidratos = @Carboidratos, 
                    Proteinas = @Proteinas, 
                    GordurasTotais = @GordurasTotais,                
                    GordurasSaturadas = @GordurasSaturadas, 
                    FibraAlimentar = @FibraAlimentar, 
                    Sodio = @Sodio, 
                    Medida = @Medida, 
                    Tag = @Tag 
                    where IdAlimento = @IdAlimento", obj);
            }
        }

        public void Deleta(int idAlimento)
        {
            using (var conn = TechFitConnection)
            {
                conn.Execute(@"delete Alimento where IdAlimento = @idAlimento", new { IdAlimento = idAlimento });
            }
        }

        public void Deletar(Alimento obj)
        {
            using (var conn = TechFitConnection)
            {
                conn.Execute(@"delete Alimento where IdAlimento = @IdAlimento",  new { obj.IdAlimento });
            }
        }

        public Alimento ObterPorId(int id)
        {
            using (var conn = TechFitConnection)
            {
                return conn.Query<Alimento>("SELECT * FROM Alimento WHERE IdAlimento = @IdAlimento",
                    new { IdAlimento = id }).FirstOrDefault();
            }
        }

        public Alimento ObterPorNome(string nome)
        {
            using (var conn = TechFitConnection)
            {
                return conn.Query<Alimento>("SELECT * FROM Alimento WHERE Nome = @Nome",
                    new { Nome = nome }).FirstOrDefault();
            }
        }

        public IEnumerable<Alimento> ObterTotos()
        {
            using (var cn = TechFitConnection)
            {
                return cn.Query<Alimento>("SELECT * FROM Alimento");
            }
        }
    }
}
