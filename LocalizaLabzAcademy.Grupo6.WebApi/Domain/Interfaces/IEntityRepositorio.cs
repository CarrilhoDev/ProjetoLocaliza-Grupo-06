using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces
{
    public interface IEntityRepositorio<T> : IDisposable where T : Entity
    {
        Task<bool> Create(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(int id);
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> CreateAndReturn(T entity);
    }
}