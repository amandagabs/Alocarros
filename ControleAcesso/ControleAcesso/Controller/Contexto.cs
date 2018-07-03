using System;

namespace ControleAcesso.Controller
{
    internal class Contexto : DbContext
    {
        public Contexto() : base("srtConn")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Contexto>());
        }

        public DbSet<Model.Visitante> Visitante { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}