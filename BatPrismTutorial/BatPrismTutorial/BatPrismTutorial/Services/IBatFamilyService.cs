using BatPrismTutorial.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BatPrismTutorial.Services
{
    public interface IBatFamilyService
    {
        IEnumerable<BatFamily> GetAll();
        BatFamily GetById(int id);
        void Update(BatFamily BatParent);
        void Insert(BatFamily BatParent);
        void Delete(int id);
    }
}
