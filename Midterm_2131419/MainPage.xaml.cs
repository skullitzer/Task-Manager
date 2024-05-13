using SQLite;
using System.Threading.Tasks;
using System;
using Xamarin.Forms;

namespace Midterm_2131419
{
    public partial class MainPage : ContentPage
    {
        private SQLiteConnection conn;

        public MainPage()
        {
            InitializeComponent();
            conn = DependencyService.Get<ISQLiteDb>().GetConnection();
            conn.CreateTable<Task>();
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            var task = new Task
            {
                Name = taskEntry.Text,
                Priority = priorityEntry.Text
            };

            conn.Insert(task);
            Navigation.PushAsync(new SecondPage());
        }
    }
}