using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Matcha.BackgroundService.Droid;
using Android.Content;
//using Com.Vivalnk.Vdireaderimpl;
//using Com.Vivalnk.Vdireader;

namespace BackgroundJob.Droid
{
    [Activity(Label = "BackgroundJob", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            BackgroundAggregator.Init(this);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            LoadApplication(new App());

            var alarmIntent = new Intent(this, typeof(BackgroundReceiver));
            var pending = PendingIntent.GetBroadcast(this, 0, alarmIntent, PendingIntentFlags.UpdateCurrent);

            var alarmManager = GetSystemService(AlarmService).JavaCast<AlarmManager>();
            alarmManager.SetRepeating(AlarmType.RtcWakeup, 0, 1 * 10, pending);

            //IVDICommonBleReader mBleReader;
            //if (Build.VERSION.PreviewSdkInt >= 21)
            //    mBleReader = new VDIBleThermometerL();
            //else
            //    mBleReader = new VDIBleThermometer(mContext);

            //mBleReader.de;

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}