using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoModelleme.Entities;

public class Instruction
{
    public Instruction()
    {
        
    }
    public Instruction(int id, string name, string description, int instructorId, string imageUrl, string price)
    {
        Id = id;
        Name = name;
        Description = description;
        InstructorId = instructorId;
        ImageUrl = imageUrl;
        Price = price;
        
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int InstructorId { get; set; }
    public string ImageUrl { get; set; }
    public string Price { get; set; }
    
}
