using System.Collections.Generic;
using System.Threading.Tasks;
using Exam2Demo.Domain;
using Exam2Demo.Domain.Entities;
using Exam2Demo.Dtos;

namespace Exam2Demo.Services
{
    public interface IBaseService<T, TDto>
        where T : BaseEntity
        where TDto : BaseDtos
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Add(TDto dto);
        Task Update(int id, TDto dto);
        Task Delete(int id);
    }
}