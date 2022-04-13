using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CORE.Models
{
    public class Account
    {
        public long AccountID { get; set; }
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(250)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Code { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime LastLogin { get; set; }
        public long CreatedBy { get; set; }
    }
}
