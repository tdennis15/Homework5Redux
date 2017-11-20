using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework5.Models
{
    public class User
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime DOB { get; set; }

        public string NAddress { get; set; }

        public string NCity { get; set; }

        public string NState { get; set; }

        public int NZipCode { get; set; }

        public string NCounty { get; set; }

        public DateTime CurrDate { get; set; }

    }
}
