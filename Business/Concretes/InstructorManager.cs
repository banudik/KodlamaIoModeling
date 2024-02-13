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

    public List<GetAllInstructorResponse> GetInstructors()
    {
        List<GetAllInstructorResponse> instructors = new List<GetAllInstructorResponse>();

        foreach (var item in _instructorDal.GetInstructors())
        {
            GetAllInstructorResponse getAllInstructorResponse = new GetAllInstructorResponse();
            getAllInstructorResponse.InstructorId = item.InstructorId;
            getAllInstructorResponse.FirstName = item.FirstName;
            getAllInstructorResponse.LastName = item.LastName;
            getAllInstructorResponse.ImageUrl = item.ImageUrl;

            instructors.Add(getAllInstructorResponse);
        }
        return instructors;
    }
}
