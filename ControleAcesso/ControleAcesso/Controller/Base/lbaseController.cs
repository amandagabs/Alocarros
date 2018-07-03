using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Controller.Base
{
    public interface IBaseController<T> where T : class
    {
        void Cadastro(T entity);

        IList<T> ListarTodos();

        IList<T> ListarPorNome(string nome);

        IList<T> ListarPorID(string VisitanteID);


        void Atualizar(T entity);

        void Excluir(int VisitanteID);
    }
}

