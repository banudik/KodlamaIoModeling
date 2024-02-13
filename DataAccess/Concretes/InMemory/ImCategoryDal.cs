using KodlamaIoModelleme.DataAccess.Abstracts;
using KodlamaIoModelleme.Entities;

namespace KodlamaIoModelleme.DataAccess.Concretes.InMemory;

public class ImCategoryDal:ICategoryDal
{
    List<Category> categories = new List<Category>();

    public ImCategoryDal()
    {
        categories.Add(new Category (1, "Tümü" ));
        categories.Add(new Category(2, "Programlama"));
        
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

    public Category GetById(int id)
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
