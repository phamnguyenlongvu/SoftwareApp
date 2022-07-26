﻿using SwitchBetweenMultipleViews.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SwitchBetweenMultipleViews.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;
        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter.ToString() == "Home")
            {
                Console.WriteLine("hi");
                viewModel.SelectedViewModel = new HomeViewModel();
            }
            else if(parameter.ToString() == "Account")
            {
                viewModel.SelectedViewModel = new AccountViewModel();
            }
            else if (parameter.ToString() == "Menu")
            {
                viewModel.SelectedViewModel = new MenuViewModel();
            }
        }
    }
}
