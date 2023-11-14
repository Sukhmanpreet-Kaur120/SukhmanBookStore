using SukhmanBooks.DataAccess.Repository.IRepository;
using SukhmanBooks.Models;
using SukhmanBookStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SukhmanBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);

    }
}
