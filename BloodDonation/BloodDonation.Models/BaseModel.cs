using System;
using System.Collections.Generic;
using System.Text;

namespace BloodDonation.Models
{
    public class BaseModel
    {
        public int? Id { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
