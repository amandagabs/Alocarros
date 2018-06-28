using ControleAcesso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Controller
{
    public class VisitanteController : IBaseController<Visitante>
    {
        private Contexto contexto = new Contexto();

        public void Adicionar(Visitante);
        {
            contexto.Visitante.Add(entity);
            contexto.SaveChanges();
        }

        public void Atualizar(Visitante entity)
        {
            contexto.Entry(entity).State =
                System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

        public Visitante BuscarPorId (int VisitanteId)
        {
            return contexto.Visitante.Find(VisitanteId);
        }

        public void Excluir(int VisitanteId)
        {
            Visitante a = BuscarPorID(VisitanteId);

            if (a != null)
            {
                // forma 1
                contexto.Visitante.Remove(a);

                // forma 2
                //contexto.Entry(a).State = System.Data.Entity.EntityState.Deleted;

                contexto.SaveChanges();
            }
        }

        public IList<Visitante> ListarPorId(string Nome)
        {
            // LINQ
            //var VisitanteComNome = from a in contexto.Visitante
            //            where a.Nome.ToLower() == Nome.ToLower()
            //            select a;

            //return VisitanteComNome.ToList();

            // LAMBDA
            return contexto.Visitante
                .Where(a => a.Nome.ToLower() == Nome.ToLower()).ToList();
        }

        public IList<Visitante> ListarTodos()
        {
            return contexto.Visitante.ToList();
        }
    }
}
}
