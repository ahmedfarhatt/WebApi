using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DataAccessLayer.Entities
{
    public class Doctor
    {
        public int SSN { get; set; }
        public string  Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Grade { get; set; }
    }
}
