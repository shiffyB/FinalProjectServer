using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ProductsDL : IProductsDL
    {
        public Task AddContactAsync(Contact c)
        {
            throw new NotImplementedException();
        }

        public Task DeleteContactAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Contact>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Contact>> GetByGroupAsync(int category)
        {
            throw new NotImplementedException();
        }

        public Task UpdateContactAsync(Contact c)
        {
            throw new NotImplementedException();
        }
    }
}
