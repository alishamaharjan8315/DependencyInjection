using PeopleViewer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.Service.Models
{
    public class StaticPeopleProvider : IPeopleProvider
    {
        public List<Person> GetPeople()
        {
            var p = new List<Person>()
            {
                new Person(){Id = 1, GivenName = "Alisha", FamilyName = "Maharjan", StartDate = new DateTime(1996, 02, 13), Rating = 8},
                new Person(){Id = 2, GivenName = "Ritesh", FamilyName = "Tamrakar", StartDate = new DateTime(1996, 02, 13), Rating = 8},
                new Person(){Id = 3, GivenName = "Utsab", FamilyName = "Dhungana", StartDate = new DateTime(1996, 02, 13), Rating = 8},
                new Person(){Id = 4, GivenName = "Santosh", FamilyName = "Tamang", StartDate = new DateTime(1996, 02, 13), Rating = 8},
                new Person(){Id = 5, GivenName = "Enju", FamilyName = "Rai", StartDate = new DateTime(1996, 02, 13), Rating = 8},
                new Person(){Id = 6, GivenName = "Corion", FamilyName = "Pradhan", StartDate = new DateTime(1996, 02, 13), Rating = 8},
                new Person(){Id = 7, GivenName = "Prayan", FamilyName = "Shakya", StartDate = new DateTime(1996, 02, 13), Rating = 8}
            };
            return p; 
        }
    }
}
