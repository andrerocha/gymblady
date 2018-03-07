using Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Student : BaseEntity
    {
        [Key]
        public int IdStudent { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public string Email { get; set; }

        public DateTime StartDate { get; set; }

        public bool HasHealthProblem { get; set; }

        public string HelthProblemDescription { get; set; }

        public bool UseDrugs { get; set; }

        public string DrugsDescription { get; set; }

        public bool HasSurgery { get; set; }

        public string SurgeryDescription { get; set; }

        public BloodType BloodType { get; set; }

        public bool AcceptedTerms { get; set; }

        public List<StudentPhone> Phones { get; set; }

        public List<StudentAddress> Addresses { get; set; }
    }
}