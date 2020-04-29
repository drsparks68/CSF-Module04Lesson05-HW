using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public string FullInfo
        {
            get
            {
                string output = $"{ FirstName } { LastName } { BirthDate }";
                return output;
            }
        }

    }
}
