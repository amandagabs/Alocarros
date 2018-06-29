namespace ControleAcesso.Controller
{
            public interface IBaseController<T> where T : class
        {
            void Adicionar(T entity);
            IList<T> ListarTodos();
            IList<T> ListarPorNome(string nome);
            T BuscarPorID(int id);
            void Atualizar(T entity);
            void Excluir(int id);
        }
    }
}