using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NestedCollectionModelMVC.Models
{
    public partial class Employee
    {
        public Employee()
        {
            this.Phones = new HashSet<Phone>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }

        internal void CreatePhoneNumbers(int count = 1)
        {
            for (int i = 0; i < count; i++)
            {
                Phones.Add(new Phone());
            }
        }
    }

    public partial class Phone
    {
        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string Number { get; set; }
        public bool DeletePhone { get; set; }
    }

}