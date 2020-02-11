using PeopleViewer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.Service.Models
{
    interface IPeopleProvider
    {
        List<Person> GetPeople();
    }
}
