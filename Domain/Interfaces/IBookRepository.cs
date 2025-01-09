using System.Collections.Generic;
using System.Threading.Tasks;
using EFCoreAssignment.Domain.Models;

namespace EFCoreAssignment.Domain.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllAsync();
        Task<Book> GetByIdAsync(int id);
        Task AddAsync(Book book);
        Task UpdateAsync(Book book);
        Task DeleteAsync(int id);
    }
}