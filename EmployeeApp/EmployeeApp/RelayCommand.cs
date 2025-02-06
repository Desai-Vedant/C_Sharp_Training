using System;
using System.Windows.Input;

namespace EmployeeApp
{
    public class RelayCommand(Action execute, Func<bool>? canExecute = null) : ICommand
    {
        private readonly Action execute = execute ?? throw new ArgumentNullException(nameof(execute));
        private readonly Func<bool>? canExecute = canExecute;

        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object? parameter) => canExecute == null || canExecute();

        public void Execute(object? parameter) => execute();
    }
}