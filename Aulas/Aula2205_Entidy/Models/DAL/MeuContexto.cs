using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aula2205_Entidy.Models.DAL
{

    public class MeuContexto : DbContext 
    {
        public MeuContexto() : base("strConn")
        {

            //DropCreateDatabaseAlways (Usar durante a crição da model)

            //Database.SetInitializer<DropCreateDatabaseIfModelChanges>

            //Migrantions (Utilizar para produção)
            Database.SetInitializer<MeuContexto>(new DropCreateDatabaseIfModelChanges<MeuContexto>());

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Atividade> Atividades { get; set; }

        internal class ToList : List<Usuario>
        {
        }
    }
}