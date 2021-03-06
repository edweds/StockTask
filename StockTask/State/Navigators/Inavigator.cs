﻿using StockTask.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace StockTask.WPF.State.Navigators
{
    public enum ViewType
    {
        Received,
        Stock,
        Sold,
        Report
    }
    public interface Inavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
