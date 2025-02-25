﻿using System;
using System.Windows.Input;

namespace EasySaveProject_V2
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        //method that return void
        private Action<object> _Execute { get; set; }
     
        //method that return a boolean
        private Predicate<object> _CanExecute { get; set; }
        
        //constructor
        public RelayCommand(Action<object> ExecuteMethod, Predicate<object> CanExecuteMethod) 
        { 
            _Execute = ExecuteMethod;
            _CanExecute = CanExecuteMethod;
        }

        public bool CanExecute(object? parameter)
        {
            return _CanExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _Execute(parameter);
        }
    }
}
