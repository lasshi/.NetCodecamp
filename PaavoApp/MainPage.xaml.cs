﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;



namespace PaavoApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            ImageBrush saa_background = new ImageBrush();
            saa_background.ImageSource = new System.Windows.Media.Imaging.BitmapImage(new Uri("Resources/saa.png", UriKind.Relative));
            Saa.Background = saa_background;

            ImageBrush ruut_background = new ImageBrush();
            ruut_background.ImageSource = new System.Windows.Media.Imaging.BitmapImage(new Uri("Resources/ruut.png", UriKind.Relative));
            RuutCam.Background = ruut_background;

            ImageBrush tentit_background = new ImageBrush();
            tentit_background.ImageSource = new System.Windows.Media.Imaging.BitmapImage(new Uri("Resources/tentit.png", UriKind.Relative));
            Tentit.Background = tentit_background;
        }

		private void AalefTap(object sender, GestureEventArgs e)
		{
			NavigationService.Navigate(new Uri("/StudentUnion.xaml", UriKind.Relative));
		}
        private void KurniekkaTap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Kurniekka.xaml", UriKind.Relative));
        }

        private void UniSodexoTap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/UniSodexo.xaml", UriKind.Relative));
        }

        private void CampusSodexoTap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CampusSodexo.xaml", UriKind.Relative));
        }


        private void Weather_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Weather.xaml", UriKind.Relative));
        }
        private void ExamButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Tentit.xaml", UriKind.Relative));
        }

        private void Selam_Click(object sender, RoutedEventArgs e)
        {
            Stream stream = TitleContainer.OpenStream("Resources/seeelam.wav");
            SoundEffect effect = SoundEffect.FromStream(stream);
            FrameworkDispatcher.Update();
            effect.Play();
            NavigationService.Navigate(new Uri("/SelamPage.xaml", UriKind.Relative));
        }

		private void RuutButtonClick(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new Uri("/Ruut.xaml", UriKind.Relative));
		}
	}
}