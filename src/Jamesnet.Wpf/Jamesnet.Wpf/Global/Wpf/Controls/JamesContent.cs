﻿using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Jamesnet.Wpf.Global.Composition;
using Jamesnet.Wpf.Mvvm;
using Prism.Mvvm;

namespace Jamesnet.Wpf.Controls
{
    public abstract class JamesContent : ContentControl, IViewable
    {
        private readonly AutoWireManager _autoWireManager;

        public FrameworkElement View => _autoWireManager.GetView();
        public INotifyPropertyChanged ViewModel => _autoWireManager.GetDataContext();

        public JamesContent()
        {
            _autoWireManager = new AutoWireManager();
            _autoWireManager.InitializeAutoWire(this);
        }
    }
}