﻿using MvvmCross.Commands;
using MvvmCross.ViewModels;
using MvxStarter.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvxStarter.Core.ViewModels
{

    public class GuestBookViewModel : MvxViewModel
    {
        public GuestBookViewModel()
        {
            AddGuestCommand = new MvxCommand(AddGuest);
        }
        public IMvxCommand AddGuestCommand { get; set; }
        public void AddGuest()
        {
            PersonModel p = new PersonModel
            {
                FirstName = FirstName,
                LastName = LastName
            };
            FirstName = string.Empty;
            LastName = string.Empty;
            People.Add(p);
        }
        private MvxObservableCollection<PersonModel> _people = new MvxObservableCollection<PersonModel>();

        public MvxObservableCollection<PersonModel> People
        {
            get { return _people; }
            set { SetProperty(ref _people, value); }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                SetProperty(ref _firstName, value);
                RaisePropertyChanged(() => FullName);

            }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set
            {
                SetProperty(ref _lastName, value);
                RaisePropertyChanged(() => FullName);
            }
        }

        public string FullName => $"{FirstName} {LastName}";
    }
}