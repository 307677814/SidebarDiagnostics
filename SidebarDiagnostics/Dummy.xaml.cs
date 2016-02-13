﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using SidebarDiagnostics.Windows;

namespace SidebarDiagnostics
{
    /// <summary>
    /// Interaction logic for Dummy.xaml
    /// </summary>
    public partial class Dummy : AppBarWindow
    {
        public Dummy()
        {
            InitializeComponent();
        }

        public void Reposition()
        {
            int _screen;
            DockEdge _edge;
            WorkArea _windowWA;
            WorkArea _appbarWA;

            Monitor.GetWorkArea(this, out _screen, out _edge, out _windowWA, out _appbarWA);

            Move(_windowWA);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Reposition();
        }
    }
}
