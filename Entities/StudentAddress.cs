using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class StudentAddress : BaseEntity
    {
        [Key]
        public int IdStudentAddress { get; set; }

        public int IdStudent { get; set; }

        public Student Student { get; set; }

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