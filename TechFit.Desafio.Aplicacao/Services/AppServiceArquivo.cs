using System.IO;
using TechFit.Desafio.Aplicacao.Interfaces;

namespace TechFit.Desafio.Aplicacao.Services
{
    public class AppServiceArquivo : IAppServiceArquivo
    {
        /// <summary>
        /// Retorna um array de bytes do arquivos
        /// </summary>
        /// <param name="localArquivo">local fisico do arquivos</param>
        /// <returns></returns>
        public byte[] ObterArquivos(string localArquivo)
        {
            FileStream stream = new FileStream(localArquivo, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;
        }
    }
}
