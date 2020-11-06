using MvvmCross.Forms.Views;
using TipCalc.Core.ViewModels;
using Xamarin.Forms.Xaml;

namespace TipCalc.Forms.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThirdView : MvxContentPage<ParametrizedViewModel>
    {
        public ThirdView()
        {
            InitializeComponent();
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            TextLabel.Text = ViewModel.TextParameter;
        }
    }
}