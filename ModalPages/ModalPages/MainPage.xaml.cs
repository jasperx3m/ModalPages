using ModalPages.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ModalPages
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<Contacts> contact;
        public MainPage()
        {
            InitializeComponent();
            SetUpdata();
            Listview.ItemsSource = contact;
        }
        async void Listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (Listview.ItemsSource != null)
            {
                var detailpage = new DetailsPageCS();
                detailpage.BindingContext = e.SelectedItem as Contacts;
                Listview.SelectedItem = null;
                await Navigation.PushAsync(detailpage);
            }
        }
        void SetUpdata()
        {
            contact = new List<Contacts>();
            contact.Add(new Contacts
            {
                Name = "Logesh",
                Age = 20,
                Occupation = "Farmer",
                Country = "India"
            });
            contact.Add(new Contacts
            {
                Name = "Hari",
                Age = 20,
                Occupation = "Software Engineer",
                Country = "India"
            });
            contact.Add(new Contacts
            {
                Name = "Mani",
                Age = 20,
                Occupation = "Farmer",
                Country = "India"
            });
            contact.Add(new Contacts
            {
                Name = "Guna Seker",
                Age = 20,
                Occupation = "Farmer",
                Country = "India"
            });
            contact.Add(new Contacts
            {
                Name = "Palani",
                Age = 20,
                Occupation = "Farmer",
                Country = "India"
            });
            contact.Add(new Contacts
            {
                Name = "Laxman",
                Age = 30,
                Occupation = "Driver",
                Country = "India"
            });
        }
    }
}
