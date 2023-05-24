using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Java.Util;

namespace PhotoGallery2.Droid
{
    [Activity(Label = "PhotoGallery2", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity


    {

        public static MainActivity Current { get; private set;}
/*
    public override void OnRequestPemissionsResult(
        int requestCode
        , string[] permission
        , [GeneratedEnum] Android.Content.PM.Permission[] grantResults


        
        )

    {
        Xamarin.Essentials.Platform.OnRequestPermissionsResult(

            requestCode, permission, grantResults);

        if (requestCode == 33 ) { 
            
            // var import = (PhotoImporte)Resolver}
    }
*/
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}