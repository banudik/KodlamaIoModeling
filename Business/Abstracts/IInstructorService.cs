using KodlamaIoModelleme.Business.Dtos.Requests.Instruction;
using KodlamaIoModelleme.Business.Dtos.Requests.Instructor;
using KodlamaIoModelleme.Business.Dtos.Responses.Instruction;
using KodlamaIoModelleme.Business.Dtos.Responses.Instructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoModelleme.Business.Abstracts;

public interface IInstructorService
{
    void Add(CreateInstructorRequest instructor);
    void Delete(DeleteInstructorRequest instructor);
    void Update(UpdateInstructorRequest instructor);
    List<GetAllInstructorResponse> GetAll();
    List<GetByIdInstructorResponse> GetById(int id);
}
