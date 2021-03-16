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
    public partial class Machine2 : ContentPage
    {
        public Machine2()
        {
            InitializeComponent();
        }
        public void OnImageNameTapped(object sender, EventArgs args)
        {
            try
            {
                Navigation.PushModalAsync(new MachineLearn());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}