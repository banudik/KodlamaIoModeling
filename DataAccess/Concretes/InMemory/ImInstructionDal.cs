using KodlamaIoModelleme.DataAccess.Abstracts;
using KodlamaIoModelleme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoModelleme.DataAccess.Concretes.InMemory;

public class ImInstructionDal : IInstructionDal
{
    List<Instruction> instructions = new List<Instruction>();

    public ImInstructionDal()
    {
        instructions.Add(new Instruction() { Id = 1, Name = "Programlamaya Giriş İçin Temel Kurs", Description = "PYTHON, JAVA, C# gibi tüm programlama dilleri için temel programlama mantığını anlaşılır örneklerle öğrenin.", InstructorId = 1, ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://www.filepicker.io/api/file/BBLmG3XFTtm8XBTrzg4v", Price = "Ücretsiz" });
        instructions.Add(new Instruction() { Id = 2, Name = "Senior Yazılım Geliştirici Yetiştirme Kampı(.NET)", Description = "Ücretsiz ve profesyonel bir programla, ileri seviye yazılım geliştirme öğreniyoruz.", InstructorId = 1, ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/ujZYJ3lwSOihtnbP9LsG", Price = "Ücretsiz" });
        instructions.Add(new Instruction() { Id = 3, Name = "Yazılım Geliştirici Yetiştirme Kampı(C# + Angular)", Description = "2 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.", InstructorId = 1, ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://www.filepicker.io/api/file/Zk7d1MdoSJ6cEShVbfd0", Price = "Ücretsiz" });
        instructions.Add(new Instruction() { Id = 4, Name = "Yazılım Geliştirici Yetiştirme Kampı (JAVA & REACT)", Description = "2 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.", InstructorId = 1, ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://www.filepicker.io/api/file/qi4s19xSKCmtaaRUqUFI", Price = "Ücretsiz" });
        instructions.Add(new Instruction() { Id = 5, Name = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)", Description = "1,5 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.", InstructorId = 1, ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://www.filepicker.io/api/file/Cs7lHNsJSCi1mkPzo8fT", Price = "Ücretsiz" });
        instructions.Add(new Instruction() { Id = 6, Name = "(2022) Yazılım Geliştirici Yetiştirme Kampı (JAVA)", Description = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.", InstructorId = 1, ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/qUyYtyzXTrOSH2M2ApBh", Price = "Ücretsiz" });
        instructions.Add(new Instruction() { Id = 7, Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı (Python & Selenium)", Description = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.", InstructorId = 2, ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/3nqAGqHARL6uEULbaQvr", Price = "Ücretsiz" });
        instructions.Add(new Instruction() { Id = 8, Name = "2024 - Yazılım Geliştirici Yetiştirme Kampı C#", Description = "Ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.", InstructorId = 1, ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/We86Zc3xQy6FUqhyBJJc", Price = "Ücretsiz" });
    }
    public void Add(Instruction instruction)
    {
        instructions.Add(instruction);
    }

    public void Delete(Instruction instruction)
    {
        var value = instructions.FirstOrDefault(i => i.Id == instruction.Id);
        instructions.Remove(value);
    }

    public Instruction GetById (int id)
    {
        var value = instructions.FirstOrDefault(i => i.Id == id);
        return value;
    }

    public List<Instruction> GetInstructions()
    {
        return instructions;
    }

    public void Update(Instruction instruction)
    {
        var value = instructions.FirstOrDefault(i => i.Id == instruction.Id);
        value.Name = instruction.Name;
        value.Description = instruction.Description;
        value.InstructorId = instruction.InstructorId;
        value.ImageUrl = instruction.ImageUrl;
        value.Price = instruction.Price;

        
    }
}
