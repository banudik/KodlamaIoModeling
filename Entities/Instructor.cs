using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoModelleme.Entities;

public class Instructor
{
    public Instructor()
    {
        
    }
    public Instructor(int instructorId, string firstName, string lastName, string imageUrl) 
    {
        InstructorId = instructorId;
        FirstName = firstName;
        LastName = lastName;
        ImageUrl = imageUrl;

    }
    public int InstructorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ImageUrl { get; set; }
    public List<Instruction> Instructions { get; set;}
    
}
