using System.ComponentModel;

namespace TechFit.Desafio.Dominio.Enumeradores
{
    public enum UnidadeMedida
    {
        [Description("kg")]
        Quilograma,
        [Description("g")]
        Grama,
        [Description("mg")]
        Miligrama,
        [Description("kcal")]
        Caloria,
    }
}
