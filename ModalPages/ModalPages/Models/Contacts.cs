using System;
using System.Collections.Generic;
using System.Text;

namespace ModalPages.Models
{
    public class Contacts
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Country { get; set; }

        public string Occupation { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
