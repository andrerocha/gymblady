using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class City : BaseEntity
    {
        [Key]
        public int IdCity { get; set; }

        public int IdState { get; set; }

        public State State { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }
    }
}