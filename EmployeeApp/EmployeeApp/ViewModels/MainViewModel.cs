using EmployeeApp.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace EmployeeApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Employee> Employees { get; set; }
        public Employee SelectedEmployee { get; set; } = null!; // Fix for CS8618
        public string SearchTerm { get; set; } = string.Empty; // Fix for CS8618

        public ICommand AddCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand SearchByIdCommand { get; }
        public ICommand SearchByNameCommand { get; }

        public MainViewModel()
        {
            Employees = new ObservableCollection<Employee>
            {
                new() { Id = 1, Name = "A", DOB = new DateTime(1990, 1, 1) },
                new() { Id = 2, Name = "B", DOB = new DateTime(1985, 5, 15) },
                new() { Id = 3, Name = "C", DOB = new DateTime(1782, 7, 20) },
                new() { Id = 3, Name = "D", DOB = new DateTime(1782, 7, 20) }
            };

            AddCommand = new RelayCommand(AddEmployee);
            DeleteCommand = new RelayCommand(DeleteEmployee, () => SelectedEmployee != null);
            SearchByIdCommand = new RelayCommand(SearchById);
            SearchByNameCommand = new RelayCommand(SearchByName);
        }

        private void AddEmployee()
        {
            Employees.Add(new Employee { Id = Employees.Count + 1, Name = "New Employee", DOB = DateTime.Today });
        }

        private void DeleteEmployee()
        {
            Employees.Remove(SelectedEmployee);
        }

        private void SearchById()
        {
            if (int.TryParse(SearchTerm, out int id))
            {
                var result = Employees.FirstOrDefault(e => e.Id == id);
                if (result != null)
                {
                    Employees.Clear();
                    Employees.Add(result);
                }
            }
        }

        private void SearchByName()
        {
            var results = Employees.Where(e => e.Name.Contains(SearchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
            Employees.Clear();
            results.ForEach(e => Employees.Add(e));
        }
    }
}