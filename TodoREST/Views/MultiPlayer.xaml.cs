﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoREST.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoREST.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Multiplayer : ContentPage
    {

        bool isNewItem;
        public Multiplayer(bool isNew = false)
        {
            InitializeComponent();
            
            isNewItem = false;
        }

        async void OnFindModstander(object sender, EventArgs e)
        {
            QueueModstander modstander = new QueueModstander();
            await App.TodoManager.GetFirstPlayerInQueue(modstander);

            await Navigation.PushAsync(new Multiplayer_2());

        }

    }
}