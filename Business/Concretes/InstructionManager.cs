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

    public List<GetAllInstructionResponse> GetInstructions()
    {
        List<GetAllInstructionResponse> instructions = new List<GetAllInstructionResponse>();

        foreach (var item in _instructionDal.GetInstructions())
        {
            GetAllInstructionResponse getAllInstructionResponse = new GetAllInstructionResponse();
            getAllInstructionResponse.Id = item.Id;
            getAllInstructionResponse.Name = item.Name;
            getAllInstructionResponse.Description = item.Description;
            getAllInstructionResponse.InstructorId = item.InstructorId;
            getAllInstructionResponse.ImageUrl = item.ImageUrl;
            getAllInstructionResponse.Price = item.Price;

            instructions.Add(getAllInstructionResponse);
        }
        return instructions;
    }
}
