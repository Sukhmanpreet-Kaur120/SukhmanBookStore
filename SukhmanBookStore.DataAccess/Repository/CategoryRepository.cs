using SukhmanBooks.DataAccess.Repository.IRepository;
using SukhmanBookStore.DataAccess.Data;
using SukhmanBookStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SukhmanBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _bd;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            db = db;
        }
    }
}
