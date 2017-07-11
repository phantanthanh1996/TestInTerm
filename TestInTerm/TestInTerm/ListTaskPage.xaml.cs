using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestInTerm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListTaskPage : ContentPage
    {
        public ListTaskPage()
        {
            InitializeComponent();
        }

        private void Add_Task(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditTaskPage());
        }

        private void Upload_To_Server(object sender, EventArgs e)
        {

        }

        private void Edit_Task(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditTaskPage());
        }

        private void Delete_Task(object sender, EventArgs e)
        {

        }
    }
}