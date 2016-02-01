using System.Collections.Generic;

namespace HelpDesk.Models.Repositorios
{
    public interface IRepositorio<T> where T : IEntidad
    {
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(int? Id);
    }
}