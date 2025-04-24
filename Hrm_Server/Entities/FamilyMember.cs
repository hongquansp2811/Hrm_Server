using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm_Server.Entities
{
    [Table("FamilyMember")]
    public class FamilyMember
    {
        [Key]
        public int FamilyMemberId { get; set; }
        public int EmployeeId { get; set; }
        public string RelationshipType { get; set; }
        public string FullName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Occupation { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsDependent { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual Employee Employee { get; set; }

        public FamilyMember()
        {
            CreatedDate = DateTime.Now;
            IsDependent = false;
        }
    }
} 