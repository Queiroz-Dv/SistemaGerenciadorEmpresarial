namespace BLL.Interfaces
{
    /// <summary> /// Interface genérica para todas as entidades /// </summary>
    /// <typeparam name="T">Tipo é o tipo da entidade ou objeto</typeparam>
    public interface IRepository<T>
    {
        T ObterPorId(int id);

        T Carregar(int id);

        void Gravar(T entity);

        void Deletar(T entity);
    }
}
