using KodlamaIoModelleme.DataAccess.Abstracts;
using KodlamaIoModelleme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoModelleme.DataAccess.Concretes.InMemory;

public class ImCategoryDal:ICategoryDal
{
    List<Category> categories = new List<Category>();

    public ImCategoryDal()
    {
        categories.Add(new Category(1, "Programlama"));
        
    }

    public void Add(Category category)
    {
        categories.Add(category);
    }

    public void Delete(Category category)
    {
        var value=categories.FirstOrDefault(c => c.Id == category.Id);
        categories.Remove(value);
    }

    public List<Category> GetCategories()
    {
        return categories;
    }

    public Category GetCategory(int id)
    {
        var value = categories.FirstOrDefault(c => c.Id == id);
        return value;
    }

    public void Update(Category category)
    {
        var value = categories.FirstOrDefault(c => c.Id == category.Id);
        value.Name = category.Name;
    }
}
