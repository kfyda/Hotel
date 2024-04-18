using Hotel.Models;
using Hotel.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hotel.Views
{
    public partial class NewVisitPage : ContentPage
    {
        public Visit visit { get; set; }

        public NewVisitPage()
        {
            InitializeComponent();
            BindingContext = new NewVisitViewModel();
        }
    }
}
