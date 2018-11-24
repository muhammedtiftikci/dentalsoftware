using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DentalSoftware.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string ADDRESS { get; set; }
        public string PHONE_NUMBER { get; set; }
        public string BOOK_NAME { get; set; }
        public int BOOK_PAGE_NUMBER { get; set; }
    }
}
