using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm_Server.Entities
{
    [Table("Certificate")]
    public class Certificate
    {
        public int CertificateId { get; set; }
        public int EmployeeId { get; set; }
        public string CertificateName { get; set; }
        public string Major { get; set; }
        public string IssuedBy { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual Employee Employee { get; set; }
        public Certificate()
        {
            CreatedDate = DateTime.Now;
        }
    }
} 