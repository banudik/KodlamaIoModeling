using KodlamaIoModelleme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoModelleme.Business.Dtos.Responses;

public class GetAllCategoryResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    //public List<Instruction> Instructions { get; set; }
}
