using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using CalibrationTest.Model;
using CalibrationTest.Helpers;

namespace CalibrationTest.ViewModel
{
    class ViewModelMain : ViewModelBase
    {
        public ObservableCollection<Transmitter> Transmitters { get; set; }

        object _SelectedTransmitter;
        public object SelectedTransmitter
        {
            get
            {
                return _SelectedTransmitter;
            }
            set
            {
                if (_SelectedTransmitter != value)
                {
                    _SelectedTransmitter = value;
                    RaisePropertyChanged("SelectedTransmitter");
                }
            }
        }

        string _TextProperty1;
        public string TextProperty1
        {
            get
            {
                return _TextProperty1;
            }
            set
            {
                if (_TextProperty1 != value)
                {
                    _TextProperty1 = value;
                    RaisePropertyChanged("TextProperty1");
                }
            }
        }

        //public RelayCommand AddUserCommand { get; set; }

        public ViewModelMain()
        {
            //People = new ObservableCollection<Person>
            //{
            //    new Person { FirstName="Tom", LastName="Jones", Age=80 },
            //    new Person { FirstName="Dick", LastName="Tracey", Age=40 },
            //    new Person { FirstName="Harry", LastName="Hill", Age=60 },
            //};
            //TextProperty1 = "Type here";

            //AddUserCommand = new RelayCommand(AddUser);
        }

        void AddUser(object parameter)
        {
            //if (parameter == null) return;
            //People.Add(new Person { FirstName = parameter.ToString(), LastName = parameter.ToString(), Age = DateTime.Now.Second });
        }

    }
}
