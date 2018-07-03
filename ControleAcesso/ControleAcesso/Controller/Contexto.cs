using ControleAcesso.Model;
using System;
using System.Data.Entity;

namespace ControleAcesso.Controller
{
    internal class Contexto : DbContext
    {

        public Contexto() : base("srtConn")
        {
        
        }

        public DbSet<Visitante> Visitantes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }



    }
}