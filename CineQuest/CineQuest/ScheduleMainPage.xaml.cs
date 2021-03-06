﻿/** This is the page that can display the schedules offered by Cinequest. It's a listbox that can be
 * populated from from a related ViewModel.
 * 
 */

using System;
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

namespace CineQuest
{
    public partial class ScheduleMainPage : PhoneApplicationPage
    {
        public ScheduleMainPage()
        {
            InitializeComponent();
        }

        /* Each button in the button part of the screen gets it's own click listener. Currently
         * they redirect to the other pages.
         */
        void eventsButton_Click(object sender, EventArgs e)
        {
            /* Navigate to Events page */
            NavigationService.Navigate(new Uri("/EventsMainPage.xaml", UriKind.Relative));
        }

        void forumsButton_Click(object sender, EventArgs e)
        {
            /* Navigate to Forums page */
            NavigationService.Navigate(new Uri("/ForumsMainPage.xaml", UriKind.Relative));
        }

        void dvdsButton_Click(object sender, EventArgs e)
        {
            /* Navigate to DVD page */
            NavigationService.Navigate(new Uri("/DVDMainPage.xaml", UriKind.Relative));
        }

        void filmsButton_Click(object sender, EventArgs e)
        {
            /* Navigate to Schedule page */
            NavigationService.Navigate(new Uri("/FilmMainPage.xaml", UriKind.Relative));
        }
    }
}