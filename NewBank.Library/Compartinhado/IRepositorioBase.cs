namespace NewBank.Dominio.Compartilhado
{
    public interface IRepositorio<T> where T : EntidadeBase
    {
        void Cadastrar(T novoRegistro);
        bool Editar(int id, T novaEntidade);
        bool Excluir(int id);
        T SelecionarPorId(int id);
        List<T> SelecionarTodos();
    }
}
