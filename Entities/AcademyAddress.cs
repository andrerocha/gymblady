using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class AcademyAddress : BaseEntity
    {
        [Key]
        public int IdAcademyAddress { get; set; }

        public int IdAcademy { get; set; }

        public Academy Academy { get; set; }

        public int IdCity { get; set; }

        public City City { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
        
        public int Number { get; set; }

        public string Complement { get; set; }

        public string Neighborhood { get; set; }

        public string ZipCode { get; set; }
    }
}