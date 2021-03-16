﻿using System.Text.RegularExpressions;
using System.Windows.Input;
using Project.Helper;
using Project.Services;
using Project.Views;
using Xamarin.Forms;

namespace Project.Models
{
	public class LoginViewModel
	{
		private readonly ApiService _apiService = new ApiService();
		private Regex EmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
		private Regex passwordRegExp = new Regex("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})");
		public LoginViewModel()
		{
			Username = Settings.Username;
			Password = Settings.Password;
			LoginCommand = new Command<string>((arg) => OpenPage(arg));
		}

		public string Username { get; set; }
		public string Password { get; set; }
		public ICommand LoginCommand { get; set; }
	
		private async void OpenPage(string value)
		{

			if (string.IsNullOrWhiteSpace(Username) ||  string.IsNullOrWhiteSpace(Password) )
			{
				await App.Current.MainPage.DisplayAlert(AppResource.er, AppResource.body, AppResource.ok);

			}
			else if (!passwordRegExp.IsMatch(Password))
			{
				await App.Current.MainPage.DisplayAlert(AppResource.er, AppResource.passv, AppResource.ok);
			}

			else if (!EmailRegex.IsMatch(Username))
			{
				await App.Current.MainPage.DisplayAlert(AppResource.er, AppResource.emv, AppResource.ok);
			}

			else {
				DependencyService.Get<IProgressInterface>().Show();

				var accessToken = await _apiService.LoginAsync(Username, Password);
				DependencyService.Get<IProgressInterface>().Hide();

				if (accessToken == null)
                {
					await App.Current.MainPage.DisplayAlert(AppResource.er, AppResource.reg, AppResource.ok);
				
					await Application.Current.MainPage.Navigation.PushModalAsync(new SignUp());
				}
				else
                {
					Settings.AccessToken = accessToken;
					if(Settings.Mobile == "") {
						await Application.Current.MainPage.Navigation.PushModalAsync(new Form());
					}
					else
                    {
						await Application.Current.MainPage.Navigation.PushModalAsync(new MainMenu());
					}
					
				}
				




				
			}






			}
		}
	
}