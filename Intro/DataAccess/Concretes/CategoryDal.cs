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
        public void Insert(Category category)
        {
            //DB İşlemleri
            categories.Add(category);
        }

        public void Delete(Category category)
        {
            //DB İşlemleri
            var deletedCategory = categories.First(o => o.Id == category.Id);
            categories.Remove(deletedCategory);
        }

        public Category GetById(int id)
        {
            //DB İşlemleri
            return categories.First(o => o.Id == id); ;
        }

        public List<Category> List()
        {
            //DB İşlemleri
            return categories;
        }

        public void Update(Category category)
        {
            //DB İşlemleri
            var updatedCategory = categories.First(o => o.Id == category.Id);
            updatedCategory.Id = category.Id;
            updatedCategory.Description = category.Description;
            updatedCategory.Name = category.Name;


        }
    }
}
