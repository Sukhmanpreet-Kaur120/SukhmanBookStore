
using SukhmanBooks.DataAccess.Repository.IRepository;
using SukhmanBookStore.DataAccess.Data;
using SukhmanBooks.Models;
using SukhmanBookStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SukhmanBooks.DataAccess.Repository.IRepository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();

            }
        }

        /*void ICategoryRepository.Update(Category category)
        {
            throw new NotImplementedException();
        }*/
    }
}
