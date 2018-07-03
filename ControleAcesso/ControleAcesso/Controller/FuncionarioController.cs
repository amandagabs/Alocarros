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
            contexto.SaveChanges()
        }
    }
}
