using MvvmCross.Forms.Views;
using TipCalc.Core.ViewModels;
using Xamarin.Forms;

namespace TipCalc.Forms.UI.Pages
{
    // [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TipView :  MvxContentPage<TipViewModel>
    {
        public TipView()
        {
            InitializeComponent();
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            NavigationButton.Command = ViewModel.NavigateCommand;
            NavigationParamsButton.Command = ViewModel.NavigateWithParametersCommand;
        }
    }
}