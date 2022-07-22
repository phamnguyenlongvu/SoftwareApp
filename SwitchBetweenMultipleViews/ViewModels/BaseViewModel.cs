﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SwitchBetweenMultipleViews.ViewModels
{
    public class BaseViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
