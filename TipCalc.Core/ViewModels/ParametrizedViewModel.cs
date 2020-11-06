using MvvmCross.ViewModels;

namespace TipCalc.Core.ViewModels
{
    public class ParametrizedViewModel : MvxViewModel<string>
    {
        public override void Prepare(string text)
        {
            TextParameter = text;
        }

        public string TextParameter { get; set; }
    }
}