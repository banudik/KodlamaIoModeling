using KodlamaIoModelleme.Business.Abstracts;
using KodlamaIoModelleme.Business.Dtos.Requests.Instruction;
using KodlamaIoModelleme.Business.Dtos.Responses.Category;
using KodlamaIoModelleme.Business.Dtos.Responses.Instruction;
using KodlamaIoModelleme.DataAccess.Abstracts;
using KodlamaIoModelleme.DataAccess.Concretes.InMemory;
using KodlamaIoModelleme.Entities;

namespace KodlamaIoModelleme.Business.Concretes;

public class InstructionManager : IInstructionService
{
    private IInstructionDal _instructionDal;
    public InstructionManager(IInstructionDal instructionDal)
    {
        _instructionDal = instructionDal;
    }
    public void Add(CreateInstructionRequest instruction)
    {
        Instruction instructionToCreate = new Instruction();
        instructionToCreate.Name = instruction.Name;
        instructionToCreate.Description = instruction.Description;
        instructionToCreate.InstructorId = instruction.InstructorId;
        instructionToCreate.ImageUrl = instruction.ImageUrl;
        instructionToCreate.Price = instruction.Price;

        _instructionDal.Add(instructionToCreate);
    }

    public void Delete(DeleteInstructionRequest instruction)
    {
        Instruction instructionToDelete = new Instruction();
        instructionToDelete.Id = instruction.Id;
        _instructionDal.Delete(instructionToDelete);
    }

    public List<GetByIdInstructionResponse> GetById(int id)
    {
        List<GetByIdInstructionResponse> instructions = new List<GetByIdInstructionResponse>();
        _instructionDal.GetById(id);
        return instructions;
    }

    public List<GetAllInstructionResponse> GetAll()
    {
        List<GetAllInstructionResponse> instructions = new List<GetAllInstructionResponse>();

        foreach (var instruction in _instructionDal.GetAll())
        {
            GetAllInstructionResponse getAllInstructionResponse = new GetAllInstructionResponse();
            getAllInstructionResponse.Id = instruction.Id;
            getAllInstructionResponse.Name = instruction.Name;
            getAllInstructionResponse.Description = instruction.Description;
            getAllInstructionResponse.InstructorId = instruction.InstructorId;
            getAllInstructionResponse.ImageUrl = instruction.ImageUrl;
            getAllInstructionResponse.Price = instruction.Price;

            instructions.Add(getAllInstructionResponse);
        }
        return instructions;
    }

    public void Update(UpdateInstructionRequest instruction)
    {
        Instruction instructionToUpdate = new Instruction();
        instructionToUpdate.Id = instruction.Id;
        instructionToUpdate.Name = instruction.Name;
        _instructionDal.Update(instructionToUpdate);
    }
}
