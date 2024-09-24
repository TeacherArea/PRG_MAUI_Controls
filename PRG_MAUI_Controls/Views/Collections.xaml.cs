using System.Collections.ObjectModel;
using PRG_MAUI_Controls.ViewModels;
using PRG_MAUI_Controls.Models;

namespace PRG_MAUI_Controls
{
    public partial class Collections : ContentPage
    {
        private TableSection StudentSection => this.FindByName<TableSection>("StudentSectionTable");

        public Collections()
        {
            InitializeComponent();

            var students = new ObservableCollection<Students>
            {
                new Students { Name = "Pelle", Age=23, Course = "Matematik"},
                new Students { Name = "Abdullah", Age=32, Course = "Filosofi" },
                new Students { Name = "Miranda", Age=24, Course = "Programmering" },
            };


            var viewModel = new StudentViewModel { Students = students };
            BindingContext = viewModel;

            UpdateTableView(viewModel.Students);

            // Lyssna på ändringar i Studentkollektionen
            viewModel.Students.CollectionChanged += (sender, args) =>
            {
                UpdateTableView(viewModel.Students);
            };
        }

        private void UpdateTableView(ObservableCollection<Students> students)
        {
            StudentSection.Clear();

            foreach (var student in students)
            {
                var textCell = new TextCell
                {
                    Text = student.Name,
                    Detail = student.Course
                };

                StudentSection.Add(textCell);
            }
        }

        private async void GoToStart(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Main");
        }
    }
}
