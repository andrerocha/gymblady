using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class City : BaseEntity
    {
        [Key]
        public int IdCity { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }
    }
}