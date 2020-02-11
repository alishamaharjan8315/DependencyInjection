using Newtonsoft.Json;
using PeopleViewer.Common;
using System;
using System.Collections.Generic;
using System.Net;

namespace PersonDataReader.Service
{
    public class ServiceReader : IPersonReader
    {
        //Can use HttpClient
        WebClient client = new WebClient();
        string baseUri = "http://localhost:9874/api/people";

        public IEnumerable<Person> GetPeople()
        {
            string result = client.DownloadString(baseUri);
            var people = JsonConvert.DeserializeObject<IEnumerable<Person>>(result);
            return people;
        }
    }
}
