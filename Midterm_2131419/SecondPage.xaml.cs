using SQLite;
using System.Linq;
using Xamarin.Forms;

namespace Midterm_2131419
{
    public partial class SecondPage : ContentPage
    {
        private SQLiteConnection conn;

        public SecondPage()
        {
            InitializeComponent();
            conn = DependencyService.Get<ISQLiteDb>().GetConnection();
            RefreshTasks();
        }

        private void RefreshTasks()
        {
            var tasks = conn.Table<Task>().ToList();
            foreach (var task in tasks)
            {
                task.PriorityColor = GetPriorityColor(task.Priority);
            }
            taskListView.ItemsSource = tasks;
        }

        private Color GetPriorityColor(string priority)
        {
            switch (priority.ToLower())
            {
                case "high":
                    return Color.Red;
                case "medium":
                    return Color.Yellow;
                default:
                    return Color.Green;
            }
        }
    }
}