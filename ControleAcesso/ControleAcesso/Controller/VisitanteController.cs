using ControleAcesso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Controller
{
    public class IBaseController<Visitante>
    {
        private List<Visitante> LsitaVisitate { get; set; }

        private Contexto contexto = new Contexto();
        private IList<Visitante> listarvisitante;

        public void Cadastro(Visitante entity)
        {
            contexto.Visitante.Add(entity);
            contexto.SaveChanges();
        }

        public IList<Visitante> ListarTodos()
        {
            return listarvisitante;
        }


        public void Atualizar(Visitante entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int VisitanteID)
        {
           Visitante v = BuscarPorVisitanteID(VisitanteID.ToString());

            if (v != null)
            {
                contexto.Entry(v).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

        private Visitante BuscarPorVisitanteID(string v)
        {
            throw new NotImplementedException();
        }
    }
}
            
        

