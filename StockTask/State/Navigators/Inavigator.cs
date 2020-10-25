using StockTask.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace StockTask.WPF.State.Navigators
{
    public interface Inavigator
    {
        public enum ViewType
        {
            Received,
            Stock,
            Sold,
            Report
        }
        ViewModelBase CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
