using BatPrismTutorial.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BatPrismTutorial.Services
{
    public interface IBatFamilyService
    {
        /* IEnumerable<BatFamily> GetAll();
         BatFamily GetById(int id);
         void Update(BatFamily BatParent);
         void Insert(BatFamily BatParent);
         void Delete(int id);*/

        Task<IEnumerable<BatFamily>> GetAllAsync();
        Task<BatFamily> GetByIdAsync(int id);
        Task UpdateAsync(BatFamily todoItem);
        Task InsertAsync(BatFamily todoItem);
        Task DeleteAsync(BatFamily todoItem);
    }
}
