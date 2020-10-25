using StockTask.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockTask.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public Inavigator Navigator { get; set; } = new Navigator();
    }
}
