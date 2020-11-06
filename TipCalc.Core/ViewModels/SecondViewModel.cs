using System.Threading;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace TipCalc.Core.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _mvxNavigationService;

        public SecondViewModel(IMvxNavigationService navigationService)
        {
            _mvxNavigationService = navigationService;

            NavigateCommand = new MvxAsyncCommand(Navigation);
        }

        async Task Navigation(CancellationToken arg)
        {
            await _mvxNavigationService.Navigate<TipViewModel>();
        }

        public IMvxAsyncCommand NavigateCommand { get; }
    }
}