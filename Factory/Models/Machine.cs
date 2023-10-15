using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
    {
        public int MachineId { get; set; }
        [Required(ErrorMessage = "Machine has to have a Name. Please type in.")]
        public string Name { get; set; }
        public List<EngineerMachine> JoinEntities { get;}
    }
}