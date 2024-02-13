using KodlamaIoModelleme.Business.Dtos.Requests;
using KodlamaIoModelleme.Business.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoModelleme.Business.Abstracts;

public interface IInstructorService
{
    void Add(CreateInstructorRequest instructor);
    List<GetAllInstructorResponse> GetInstructors();
}
