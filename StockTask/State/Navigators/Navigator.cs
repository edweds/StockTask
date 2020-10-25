using StockTask.WPF.Commands;
using StockTask.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace StockTask.WPF.State.Navigators
{
    public class Navigator : Inavigator
    {
        
        public ViewModelBase CurrentViewModel { get; set; }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
    }
}
