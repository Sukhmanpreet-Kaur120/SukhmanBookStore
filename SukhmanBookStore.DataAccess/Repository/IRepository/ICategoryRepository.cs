﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SukhmanBooks.DataAccess.Repository.IRepository
{
    public class ICategoryRepository
    {
        public static implicit operator ICategoryRepository(CategoryRepository v)
        {
            throw new NotImplementedException();
        }
    }
}
