using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    internal class Contact
    {

        //Här bygger vi upp vad en kontaktperson skall innehålla


        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string StreetAddress { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;    


    }
}
