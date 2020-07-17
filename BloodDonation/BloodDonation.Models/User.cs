using System;
using System.Collections.Generic;
using System.Text;

namespace BloodDonation.Models
{
    public class User : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string BoodGroup { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return string.Concat(FirstName, " ", LastName);
        }
    }
}
