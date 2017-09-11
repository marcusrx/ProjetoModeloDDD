using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModelo.MVC.ViewModels
{
    public class CommodityViewModel
    {
        [Key]
        public int CommodityID { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descricao")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Descricao { get; set; }

        public int TipoMaoObraID { get; set; }
        public int DisciplinaID { get; set; }

        public virtual DisciplinaViewModel Disciplina { get; set; }
        public virtual TipoMaoObraViewModel TipoMaoDeObra { get; set; }
    }
}