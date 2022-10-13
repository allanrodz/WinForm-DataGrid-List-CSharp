using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Customer
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string County { get; set; }
        public string DOB { get; set; }
        public int AccountNumber { get; set; }
        public string Bank { get; set; }

        public Customer(string fn, string sn, string cy, string dob, int ac, string bk)
        {
            Firstname = fn;
            Surname = sn;
            County = cy;
            DOB = dob;
            AccountNumber = ac;
            Bank = bk;
        }
    }
}
