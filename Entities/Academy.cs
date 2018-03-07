using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Academy : BaseEntity
    {
        [Key]
        public int IdAcademy { get; set; }

        public int IdTeam { get; set; }

        public Team Team { get; set; }

        public string Name { get; set; }

        public bool Main { get; set; }

        public List<AcademyPhone> Phones { get; set; }

        public List<AcademyAddress> Addresses { get; set; }
    }
}