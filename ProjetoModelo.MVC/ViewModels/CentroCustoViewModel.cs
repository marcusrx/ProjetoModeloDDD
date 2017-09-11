using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoModelo.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModelo.MVC.ViewModels
{
    public class CentroCustoViewModel
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Preencha o campo Empresa")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public String CodCentroCusto { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descrição")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Descrição")]
        public string Desc { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public int ProjetoID { get; set; }
        public virtual ProjetoViewModel Projeto { get; set; }
    }
}