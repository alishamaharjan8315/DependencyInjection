using PeopleViewer.Common;
using PersonDataReader.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PeopleViewer.Presentation
{
    public class PeopleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected IPersonReader DataReader;

        private IEnumerable<Person> _people;
        public IEnumerable<Person> People;

        public PeopleViewModel()
        {
            DataReader = new ServiceReader();
        }
        public void RefreshPeople()
        {
            People = DataReader.GetPeople();
        }

        public void ClearPeople()
        {
            People = new List<Person>();
        }
        public string DataReaderType
        {
            get { return DataReader.GetType().ToString();  }
        }
    }
}
