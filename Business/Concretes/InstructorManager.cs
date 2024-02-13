using KodlamaIoModelleme.Business.Abstracts;
using KodlamaIoModelleme.Business.Dtos.Requests.Instructor;
using KodlamaIoModelleme.Business.Dtos.Responses.Instructor;
using KodlamaIoModelleme.DataAccess.Abstracts;
using KodlamaIoModelleme.DataAccess.Concretes.InMemory;
using KodlamaIoModelleme.Entities;

namespace KodlamaIoModelleme.Business.Concretes;

public class InstructorManager : IInstructorService
{
    private IInstructorDal _instructorDal;
    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public void Add(CreateInstructorRequest instructor)
    {
        Instructor instructorToCreate = new Instructor();
        instructorToCreate.FirstName = instructor.FirstName;
        instructorToCreate.LastName = instructor.LastName;
        instructorToCreate.ImageUrl = instructor.ImageUrl;

        _instructorDal.Add(instructorToCreate);
    }

    public void Delete(DeleteInstructorRequest instructor)
    {
        Instructor instructorToDelete = new Instructor();
        instructorToDelete.InstructorId = instructor.Id;
        _instructorDal.Delete(instructorToDelete);

    }

    public List<GetByIdInstructorResponse> GetById(int id)
    {
        List<GetByIdInstructorResponse> instructors = new List<GetByIdInstructorResponse>();
        _instructorDal.GetById(id);
        return instructors;

    }

    public List<GetAllInstructorResponse> GetAll()
    {
        List<GetAllInstructorResponse> instructors = new List<GetAllInstructorResponse>();

        foreach (var instructor in _instructorDal.GetAll())
        {
            GetAllInstructorResponse getAllInstructorResponse = new GetAllInstructorResponse();
            getAllInstructorResponse.InstructorId = instructor.InstructorId;
            getAllInstructorResponse.FirstName = instructor.FirstName;
            getAllInstructorResponse.LastName = instructor.LastName;
            getAllInstructorResponse.ImageUrl = instructor.ImageUrl;

            instructors.Add(getAllInstructorResponse);
        }
        return instructors;
    }

    public void Update(UpdateInstructorRequest instructor)
    {
        Instructor instructorToUpdate = new Instructor();
        instructorToUpdate.InstructorId = instructor.InstructorId;
        instructorToUpdate.FirstName = instructor.FirstName;
        instructorToUpdate.LastName = instructor.LastName;
        instructorToUpdate.ImageUrl = instructor.ImageUrl;
        _instructorDal.Update(instructorToUpdate);
    }
}
