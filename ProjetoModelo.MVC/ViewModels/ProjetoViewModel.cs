using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace ProjetoModelo.MVC.ViewModels
{
    public class ProjetoViewModel
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="Preencha o campo Empresa")]
        [MaxLength(150, ErrorMessage ="Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public string Empresa { get; set; }

        [Required(ErrorMessage = "Preencha o campo AreaAtuacao")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public string AreaAtuacao { get; set; }

        [Required(ErrorMessage = "Preencha o campo Regiao")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public string Regiao { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public virtual IEnumerable<ProdutoViewModel> CentrosCusto { get; set; }
    }
}