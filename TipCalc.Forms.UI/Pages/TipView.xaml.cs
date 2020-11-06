using MvvmCross.Forms.Views;
using TipCalc.Core.ViewModels;

namespace TipCalc.Forms.UI.Pages
{
    // [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TipView :  MvxContentPage<TipViewModel>
    {
        public TipView()
        {
            InitializeComponent();
        }
    }
}