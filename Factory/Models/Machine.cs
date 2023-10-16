using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
    {
        public int MachineId { get; set; }
        [Required(ErrorMessage = "Machine has to have a type.")]
        public string type { get; set; }
        public List<EngineerMachine> JoinEntities { get;}
    }
}