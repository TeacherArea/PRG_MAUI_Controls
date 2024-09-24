using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using PRG_MAUI_Controls.Models;

namespace PRG_MAUI_Controls.ViewModels
{
    public class StudentViewModel : BindableObject
    {
        public ObservableCollection<Students> Students { get; set; } = new ObservableCollection<Students>();

        private ObservableCollection<Students> _filteredStudents;
        public ObservableCollection<Students> FilteredStudents
        {
            get => _filteredStudents;
            set
            {
                _filteredStudents = value;
                OnPropertyChanged();
                NoResultsFound = !_filteredStudents.Any();
            }
        }

        private bool _noResultsFound;
        public bool NoResultsFound
        {
            get => _noResultsFound;
            set
            {
                _noResultsFound = value;
                OnPropertyChanged();
            }
        }

        private bool _isSearchActive;
        public bool IsSearchActive
        {
            get => _isSearchActive;
            set
            {
                _isSearchActive = value;
                OnPropertyChanged();
            }
        }

        private bool _showNoResultsMessage;
        public bool ShowNoResultsMessage
        {
            get => _showNoResultsMessage;
            set
            {
                _showNoResultsMessage = value;
                OnPropertyChanged();
            }
        }

        private void PerformSearch()
        {
            if (string.IsNullOrWhiteSpace(SearchText))
            {
                FilteredStudents = new ObservableCollection<Students>(Students);
                IsSearchActive = false;
                ShowNoResultsMessage = false;
            }
            else
            {
                var filtered = Students.Where(s =>
                    s.Name.ToLower().Contains(SearchText.ToLower()) ||
                    s.Course.ToLower().Contains(SearchText.ToLower()))
                    .ToList();

                FilteredStudents = new ObservableCollection<Students>(filtered);
                IsSearchActive = true;
                ShowNoResultsMessage = !FilteredStudents.Any();
            }

            OnPropertyChanged(nameof(FilteredStudents));
        }

        public string NewStudentName { get; set; }
        public string NewStudentAge { get; set; }
        public string NewStudentCourse { get; set; }
        public string SearchText { get; set; }


        #region Felmeddelanden
        private string nameError;
        private bool isNameErrorVisible;
        private string ageError;
        private bool isAgeErrorVisible;
        private string courseError;
        private bool isCourseErrorVisible;

        public string NameError
        {
            get => nameError;
            set
            {
                nameError = value;
                OnPropertyChanged();
            }
        }

        public bool IsNameErrorVisible
        {
            get => isNameErrorVisible;
            set
            {
                isNameErrorVisible = value;
                OnPropertyChanged();
            }
        }

        public string AgeError
        {
            get => ageError;
            set
            {
                ageError = value;
                OnPropertyChanged();
            }
        }

        public bool IsAgeErrorVisible
        {
            get => isAgeErrorVisible;
            set
            {
                isAgeErrorVisible = value;
                OnPropertyChanged();
            }
        }

        public string CourseError
        {
            get => courseError;
            set
            {
                courseError = value;
                OnPropertyChanged();
            }
        }

        public bool IsCourseErrorVisible
        {
            get => isCourseErrorVisible;
            set
            {
                isCourseErrorVisible = value;
                OnPropertyChanged();
            }
        }

        #endregion

        private Students _selectedStudent;
        public Students SelectedStudent
        {
            get => _selectedStudent;
            set
            {
                _selectedStudent = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddStudentCommand { get; }
        public ICommand SearchCommand { get; }

        public StudentViewModel()
        {
            AddStudentCommand = new Command(AddStudent);
            SearchCommand = new Command(PerformSearch);

            FilteredStudents = new ObservableCollection<Students>(Students);
        }

        private void AddStudent()
        {
            IsNameErrorVisible = false;
            IsAgeErrorVisible = false;
            IsCourseErrorVisible = false;

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(NewStudentName))
            {
                NameError = "Namn kan inte vara tomt.";
                IsNameErrorVisible = true;
                isValid = false;
            }

            if (!int.TryParse(NewStudentAge, out int age) || age <= 0 || age > 120)
            {
                AgeError = "Ange en giltig ålder större än 0.";
                IsAgeErrorVisible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(NewStudentCourse))
            {
                CourseError = "Kurs kan inte vara tomt.";
                IsCourseErrorVisible = true;
                isValid = false;
            }

            if (isValid)
            {
                Students.Add(new Students
                {
                    Name = NewStudentName,
                    Age = age,
                    Course = NewStudentCourse
                });

                NewStudentName = string.Empty;
                NewStudentAge = "0";
                NewStudentCourse = string.Empty;

                OnPropertyChanged(nameof(NewStudentName));
                OnPropertyChanged(nameof(NewStudentAge));
                OnPropertyChanged(nameof(NewStudentCourse));

                FilteredStudents = new ObservableCollection<Students>(Students);
            }
        }
    }
}