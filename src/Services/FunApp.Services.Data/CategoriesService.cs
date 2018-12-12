﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FunApp.Data.Common;
using FunApp.Data.Models;
using FunApp.Services.Mapping;
using FunApp.Services.Models;

namespace FunApp.Services.DataServices
{
    public class CategoriesService : ICategoriesService
    {
        private readonly IRepository<Category> _repository;

        public CategoriesService(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public IEnumerable<CategoryIdAndNameViewModel> GetAll()
        {
            return _repository.All().To<CategoryIdAndNameViewModel>().ToList();
        }

        public bool IsCategoryIdValid(int id)
        {
            return _repository.All().Any(c => c.Id == id);
        }
    }
}
