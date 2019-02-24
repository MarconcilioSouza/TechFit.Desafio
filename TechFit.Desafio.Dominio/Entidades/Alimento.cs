using System;
using TechFit.Desafio.Dominio.Enumeradores;

namespace TechFit.Desafio.Dominio.Entidades
{
    public class Alimento
    {
        public int IdAlimento { get; set; }
        public string Nome { get; set; }
        public string QtdGramas { get; set; }
        public string Calorias { get; set; }
        public string Carboidratos { get; set; }
        public string Proteinas { get; set; }
        public string GordurasTotais { get; set; }
        public string GordurasSaturadas { get; set; }
        public string FibraAlimentar { get; set; }
        public string Sodio { get; set; }
        public string Medida { get; set; }
        public byte[] Tag { get; set; }
    }
}
