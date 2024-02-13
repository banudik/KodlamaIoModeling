using KodlamaIoModelleme.Business.Abstracts;
using KodlamaIoModelleme.Business.Dtos.Requests;
using KodlamaIoModelleme.Business.Dtos.Responses;
using KodlamaIoModelleme.DataAccess.Abstracts;
using KodlamaIoModelleme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoModelleme.Business.Concretes;

public class CategoryManager : ICategoryService
{
    private ICategoryDal _categoryDal;
    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }
    public void Add(CreateCategoryRequest category)
    {
        Category categoryToCreate = new Category();
        categoryToCreate.Name = category.Name;

        _categoryDal.Add(categoryToCreate);
    }

    public List<GetAllCategoryResponse> GetCategories()
    {
        List<GetAllCategoryResponse> categories = new List<GetAllCategoryResponse>();

        foreach (var item in _categoryDal.GetCategories())
        {
            GetAllCategoryResponse getAllCategoryResponse = new GetAllCategoryResponse();
            getAllCategoryResponse.Name = item.Name;

            categories.Add(getAllCategoryResponse);
        }
        return categories;
    }
}
