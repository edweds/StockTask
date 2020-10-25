using StockTask.WPF.State.Navigators;
using StockTask.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using static StockTask.WPF.State.Navigators.Navigator;

namespace StockTask.WPF.Commands
{
    class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Inavigator _navigator;

        public UpdateCurrentViewModelCommand(Inavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           if(parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;
                switch (viewType)
                {
                    case ViewType.Received:
                        _navigator.CurrentViewModel = new ReceivedViewModel();
                        break;
                    case ViewType.Stock:
                        _navigator.CurrentViewModel = new StockViewModel();
                        break;
                    case ViewType.Sold:
                        _navigator.CurrentViewModel = new SoldViewModel();
                        break;
                    case ViewType.Report:
                        _navigator.CurrentViewModel = new ReportViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}