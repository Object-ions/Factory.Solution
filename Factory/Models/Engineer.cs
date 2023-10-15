using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "Engineer has to have a Name. Please type in.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Engineer has to have a Name. Please type in.")]
    public string Speciality { get; set; }
    public List<EngineerMachine> JoinEntities { get;}
  }
}