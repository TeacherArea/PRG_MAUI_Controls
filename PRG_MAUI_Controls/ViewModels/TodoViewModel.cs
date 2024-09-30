using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PRG_MAUI_Controls
{
    public class TodoViewModel : BindableObject
    {
        public ObservableCollection<string> Todos { get; set; } = new ObservableCollection<string>();

        public ICommand AddTodoCommand { get; }
        public ICommand RemoveTodoCommand { get; }

        public TodoViewModel()
        {
            AddTodoCommand = new Command<string>(AddTodo);
            RemoveTodoCommand = new Command<string>(RemoveTodo);
        }

        private void AddTodo(string newTodo)
        {
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                Todos.Add(newTodo);
            }
        }

        private void RemoveTodo(string todo)
        {
            if (Todos.Contains(todo))
            {
                Todos.Remove(todo);
            }
        }
    }
}
