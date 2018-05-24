using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula2205_Entidy.Models
{
    public class Atividade
    {
        public int AtividadeID { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }
        
        public string Descricao { get; set; }

        public bool Ativo { get; set; }
    }
}