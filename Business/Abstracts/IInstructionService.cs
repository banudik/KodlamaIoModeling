using KodlamaIoModelleme.Business.Dtos.Requests.Instruction;
using KodlamaIoModelleme.Business.Dtos.Responses.Instruction;

namespace KodlamaIoModelleme.Business.Abstracts;

public interface IInstructionService
{
    void Add(CreateInstructionRequest instruction);
    void Delete(DeleteInstructionRequest instruction);
    void Update(UpdateInstructionRequest instruction);
    List<GetAllInstructionResponse> GetAll();
    List<GetByIdInstructionResponse> GetById(int id);
    
}
