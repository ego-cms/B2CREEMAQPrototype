using MvvmCross.Platforms.Android.Core;
using MvvmCross.ViewModels;

namespace B2CPrototype.Droid
{
    public class Setup: MvxAndroidSetup
    {
        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}