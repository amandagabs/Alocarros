using ControleAcesso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Controller
{
    public class FuncionarioController
    {
        private Contexto contexto = new Contexto();
        public void Adicionar(Funcionario funcionario)
        {
            contexto.Funcionarios.Add(funcionario);
            contexto.SaveChanges();
        }

        public IList<Funcionario> ListarFuncionarios(string find = "")
        {
            if(find.Length == 0) return contexto.Funcionarios.ToList();

            return contexto.Funcionarios.Where(f => f.CPF.Contains(find) || f.Nome.ToLower().Contains(find.ToLower())).ToList();
        }

        public void Atualizar(Funcionario entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
        public void Desativar(Funcionario funcionario)
        {
            contexto.Entry(funcionario).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }
    }
}
