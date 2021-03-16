﻿using Project.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsDiss : ContentPage
    {
        public ConsDiss()
        {
            InitializeComponent();
            label.Text = AppResource.pri;
            label1.Text = AppResource.pri1;
            label2.Text = AppResource.pri2;
            label3.Text = AppResource.pri3;
            disslabel.Text = AppResource.diss;
            btn.Text = AppResource.btnsend;
        }
        public void OnImageNameTapped(object sender, EventArgs args)
        {
            try
            {
                Navigation.PushModalAsync(new MainMenu());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}