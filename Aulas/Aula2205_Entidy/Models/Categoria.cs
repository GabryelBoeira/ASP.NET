using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula2205_Entidy.Models
{
    public class Categoria
    {

        public int CategoriaID { get; set; }

        [Required, StringLength(30)]
        public String Nome { get; set; }

        public bool Ativo { get; set; }


    }
}