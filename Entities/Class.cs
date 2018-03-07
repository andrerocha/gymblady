using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Class : BaseEntity
    {
        [Key]
        public int IdClass { get; set; }

        public int IdAcademy { get; set; }

        public Academy Academy { get; set; }

        public string Name { get; set; }
    }
}