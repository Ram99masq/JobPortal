using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobsPortal.DBContext.DTO
{
    public class JobPosting
    {
        [Key]
        public int JobPostingID { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public string Experience { get; set; }
        public string JobRole { get; set; }
        public string JobDescription { get; set; }
        public string ContactEmailId { get; set; }
        public string ContactPhoneNo { get; set; }
        public string EmploymentType { get; set; }
        public string IndustryType { get; set; }
        public string Education { get; set; }
        public string Skills { get; set; }


    }
}
