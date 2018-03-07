using Entities.Enum;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class StudentPhone : BaseEntity
    {
        [Key]
        public int IdStudentPhone { get; set; }

        public int IdStudent { get; set; }

        public Student Student { get; set; }

        public PhoneType Type { get; set; }

        public int CountryCode { get; set; }

        public int AreaCode { get; set; }

        public string Number { get; set; }
    }
}