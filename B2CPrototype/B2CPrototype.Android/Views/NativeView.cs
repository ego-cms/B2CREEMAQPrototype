using Android.App;
using Android.OS;
using Android.Widget;
using B2CPrototype.ViewModels;
using MvvmCross.Forms.Platforms.Android.Views;

namespace B2CPrototype.Droid.Views
{
    [Activity(Label = "NativeActivity",Icon = "@mipmap/icon", Theme = "@style/MainTheme")]
    public class NativeView: MvxFormsAppCompatActivity<NativeViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.native_layout);

            var close = FindViewById<Button>(Resource.Id.closeButton);

            close.Click += delegate
            {
                ViewModel.CloseCommand?.Execute();
            };
        }
    }
}