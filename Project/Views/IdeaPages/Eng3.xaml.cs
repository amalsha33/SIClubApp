﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project.Views.IdeaPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Eng3 : ContentPage
    {
        public Eng3()
        {
            InitializeComponent();
        }
        public void OnImageNameTapped(object sender, EventArgs args)
        {
            try
            {
                Navigation.PushModalAsync(new EngineeringInventions());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}