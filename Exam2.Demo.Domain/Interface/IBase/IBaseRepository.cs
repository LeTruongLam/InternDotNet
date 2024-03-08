using Exam2Demo.Models;
using System.Collections.Generic;

namespace Exam2Demo.Domain.Interface
{
    public interface IBaseRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}