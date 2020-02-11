﻿using System;

namespace PeopleViewer.Common
{
    public class Person
    {
        public int Id { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public DateTime StartDate { get; set; }
        public int Rating { get; set; }
    }
}
