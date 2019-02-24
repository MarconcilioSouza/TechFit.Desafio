using System;
using System.ComponentModel.DataAnnotations;
using TechFit.Desafio.Dominio.Enumeradores;

namespace TechFit.Desafio.Aplicacao.ViewModels
{
    public class AlimentosViewModel
    {
        [Key]
        public int IdAlimento { get; set; }
        [Required(ErrorMessage = "Prencha o campo Nome")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [Display(Name = "Nome", AutoGenerateFilter = true)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Prencha o campo Quantidade")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [Display(Name = "Quantidade")]
        public string QtdGramas { get; set; }
        [Required(ErrorMessage = "Prencha o campo Calorias")]
        [MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
        [Display(Name = "Calorias")]
        public string Calorias { get; set; }
        [Required(ErrorMessage = "Prencha o campo Carboidratos")]
        [MaxLength(10, ErrorMessage = "Máximo {0} caracteres")]
        [Display(Name = "Carboidratos")]
        public string Carboidratos { get; set; }
        [Required(ErrorMessage = "Prencha o campo Proteinas")]
        [MaxLength(10, ErrorMessage = "Máximo {0} caracteres")]
        [Display(Name = "Proteinas")]
        public string Proteinas { get; set; }
        [Required(ErrorMessage = "Prencha o campo Gorduras Totais")]
        [MaxLength(10, ErrorMessage = "Máximo {0} caracteres")]
        [Display(Name = "Gorduras Totais")]
        public string GordurasTotais { get; set; }
        [Required(ErrorMessage = "Prencha o campo Gorduras Saturadas")]
        [MaxLength(10, ErrorMessage = "Máximo {0} caracteres")]
        [Display(Name = "Gorduras Saturadas")]
        public string GordurasSaturadas { get; set; }
        [Required(ErrorMessage = "Prencha o campo Fibra Alimentar")]
        [MaxLength(10, ErrorMessage = "Máximo {0} caracteres")]
        [Display(Name = "Fibra Alimentar")]
        public string FibraAlimentar { get; set; }
        [Required(ErrorMessage = "Prencha o campo Sódio")]
        [MaxLength(10, ErrorMessage = "Máximo {0} caracteres")]
        [Display(Name = "Sódio")]
        public string Sodio { get; set; }
        [Required(ErrorMessage = "Prencha o campo Medida")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [Display(Name = "Medida")]
        public string Medida { get; set; }
        [Display(Name = "Tag")]
        public byte[] Tag { get; set; }
    }
}