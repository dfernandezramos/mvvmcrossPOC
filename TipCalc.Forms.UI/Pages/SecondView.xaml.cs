using MvvmCross.Forms.Views;
using TipCalc.Core.ViewModels;

namespace TipCalc.Forms.UI.Pages
{
    // [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondView :  MvxContentPage<SecondViewModel>
    {
        public SecondView()
        {
            InitializeComponent();
        }
        
        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            NavigationButton.Command = ViewModel.NavigateCommand;
        }
    }
}