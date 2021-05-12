using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IProductsDL
    {
        Task<List<Contact>> GetAllAsync();
        Task AddContactAsync(Contact c);
        Task UpdateContactAsync(Contact c);
        Task DeleteContactAsync(int id);
        Task<List<Contact>> GetByGroupAsync(int category);
    }
}
