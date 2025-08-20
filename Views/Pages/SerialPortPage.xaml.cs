using SAcom.ViewModels.Pages;
using Wpf.Ui.Abstractions.Controls;

namespace SAcom.Views.Pages
{
    public partial class SerialPortPage : INavigableView<SerialPortViewModel>
    {
        public SerialPortViewModel ViewModel { get; }

        public SerialPortPage(SerialPortViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
