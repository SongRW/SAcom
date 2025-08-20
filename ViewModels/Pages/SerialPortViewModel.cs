using System.Threading.Tasks;
using Wpf.Ui.Abstractions.Controls;

namespace SAcom.ViewModels.Pages
{
    public partial class SerialPortViewModel : ObservableObject, INavigationAware
    {
        public Task OnNavigatedToAsync() => Task.CompletedTask;

        public Task OnNavigatedFromAsync() => Task.CompletedTask;
    }
}
