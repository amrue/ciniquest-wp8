﻿#pragma checksum "C:\Users\Steven\Documents\GitHub\ciniquest-wp8\CineQuest\CineQuest\EventsMainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8E0A663FD0C4319D4C294B6C9453AAEB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace CineQuest {
    
    
    public partial class EventsMainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton filmsButton;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton forumsButton;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton dvdsButton;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton scheduleButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/CineQuest;component/EventsMainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.filmsButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("filmsButton")));
            this.forumsButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("forumsButton")));
            this.dvdsButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("dvdsButton")));
            this.scheduleButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("scheduleButton")));
        }
    }
}

