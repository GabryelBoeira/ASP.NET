using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
    public partial class Atividade
    {
        public int IdAtividade { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Datalimite { get; set; }
        public Categoria _Categoria { get; set; }


    }
}
