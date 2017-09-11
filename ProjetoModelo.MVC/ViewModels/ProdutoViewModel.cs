using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModelo.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoID { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage ="Preencha um valor")]
        public decimal Valor { get; set; }

        [DisplayName("Disponível")]
        public bool Disponivel { get; set; }

        
        public int ClienteID { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
    }
}