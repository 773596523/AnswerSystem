﻿using System;
using System.Windows.Input;

namespace AnswerSystemWPF.Command
{
    public class DelegateCommand : ICommand
    {
        private readonly Action<object> executeAction;
        private readonly Func<object, bool> canExecuteFunc;
        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action<object> execute)
            : this(execute, null)
        { }

        public DelegateCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            if (execute == null)
            {
                return;
            }
            executeAction = execute;
            canExecuteFunc = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (canExecuteFunc == null)
            {
                return true;
            }
            return canExecuteFunc(parameter);
        }

        public void Execute(object parameter)
        {
            executeAction?.Invoke(parameter);
        }
    }
}
