using Intro.DataAccess.Abstracts;
using Intro.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concretes
{
    public class CategoryDal:ICategoryDal
    {
        public List<Category> categories;
        public CategoryDal()
        {
            categories = new List<Category>() { new Category { Name="Kategori1",Id=1,Description="Açıklama1"},
            new Category { Name="Kategori2",Id=2,Description="Açıklama2"}};

        }
        public void Insert(Category entity)
        {
            categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            var deletedCategory = categories.First(c => c.Id == entity.Id);
            categories.Remove(deletedCategory);
        }

        public Category GetById(int id)
        {
            return categories.First(c => c.Id == id); ;
        }

        public List<Category> List()
        {
            return categories;
        }

        public void Update(Category entity)
        {
            var updatedCategory = categories.First(c => c.Id == entity.Id);
            updatedCategory.Id = entity.Id;
            updatedCategory.Description = entity.Description;
            updatedCategory.Name = entity.Name;


        }
    }
}
