using KodlamaIoModelleme.Business.Dtos.Requests;
using KodlamaIoModelleme.Business.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoModelleme.Business.Abstracts;

public interface ICategoryService
{
    void Add(CreateCategoryRequest category);
    List<GetAllCategoryResponse> GetCategories();
}
