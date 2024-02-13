using KodlamaIoModelleme.Business.Dtos.Requests.Category;
using KodlamaIoModelleme.Business.Dtos.Responses.Category;

namespace KodlamaIoModelleme.Business.Abstracts;

public interface ICategoryService
{
    void Add(CreateCategoryRequest category);
    void Delete(DeleteCategoryRequest category);
    void Update(UpdateCategoryRequest category);
    List<GetAllCategoryResponse> GetAll();
    List<GetByIdCategoryResponse> GetById(int id);
}
