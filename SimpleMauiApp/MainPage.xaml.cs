using SimpleMauiApp.Model;
using SimpleMauiApp.Services;
using System;
using System.Collections.Generic;
namespace SimpleMauiApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            var service = new ServiceUser();
            List<User> users = service.GetUsers();

            
            UserCollectionView.ItemsSource = users;


        }


    }

}
