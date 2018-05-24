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

        Database.se



    }
}