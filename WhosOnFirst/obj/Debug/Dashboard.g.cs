﻿#pragma checksum "C:\Users\j.aleksandrowicz\Documents\Visual Studio 2013\Projects\WhosOnFirst\WhosOnFirst\Dashboard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "27FECCDAF3E4B5BC013764E3A2866410"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace WhosOnFirst {
    
    
    public partial class Dashboard : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button Add_Person;
        
        internal System.Windows.Controls.Button MyProfile;
        
        internal System.Windows.Controls.Button MyProfile_Copy;
        
        internal System.Windows.Controls.Button Teams;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WhosOnFirst;component/Dashboard.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Add_Person = ((System.Windows.Controls.Button)(this.FindName("Add_Person")));
            this.MyProfile = ((System.Windows.Controls.Button)(this.FindName("MyProfile")));
            this.MyProfile_Copy = ((System.Windows.Controls.Button)(this.FindName("MyProfile_Copy")));
            this.Teams = ((System.Windows.Controls.Button)(this.FindName("Teams")));
        }
    }
}

