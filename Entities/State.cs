using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class State : BaseEntity
    {
        [Key]
        public int IdState { get; set; }

        public int IdCountry { get; set; }

        public Country Country { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }
    }
}