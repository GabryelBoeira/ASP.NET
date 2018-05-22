﻿using System.ComponentModel.DataAnnotations;

namespace Aula1505_MVC1.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        //
        [Display(Name ="Titulo")]
        [Required(ErrorMessage ="Campo Obrigado")]
        public string Nome { get; set; }

        public bool Ativo { get; set; }

    }
}