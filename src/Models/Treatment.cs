using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DentalSoftware.Models
{
    public class Treatment
    {
        public int ID { get; set; }
        public int PATIENT_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public float PRICE { get; set; }
        public float PAID { get; set; }
        public DateTime DATE { get; set; }
    }
}
