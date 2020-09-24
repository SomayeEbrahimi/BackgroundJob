using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Matcha.BackgroundService.Droid;
using Android.Content;
using Com.Vivalnk.Vdireader;
using System;
using Com.Vivalnk.Vdireaderimpl;
using Com.Vivalnk.Model;

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

           // LoadApplication(new App());

            var alarmIntent = new Intent(this, typeof(BackgroundReceiver));
            var pending = PendingIntent.GetBroadcast(this, 0, alarmIntent, PendingIntentFlags.UpdateCurrent);

            var alarmManager = GetSystemService(AlarmService).JavaCast<AlarmManager>();
            alarmManager.SetRepeating(AlarmType.RtcWakeup, 0, 1 * 10, pending);


            IVDICommonBleReader mBleReader;
#pragma warning disable CS0618 // Type or member is obsolete
            var sdk = Convert.ToInt32(Build.VERSION.Sdk);
#pragma warning restore CS0618 // Type or member is obsolete
            if (sdk >= 21)
            {
                mBleReader = new VDIBleThermometerL(this);
            }
            else
            {
                mBleReader = new VDIBleThermometer(this);
            }
           // mBleReader.SetListener();
            mBleReader.StartDeviceDiscovery();
            mBleReader.StopDeviceDiscovery();
            var bluetoothStatus = mBleReader.CheckBle();
            if (bluetoothStatus == VDIType.CHECKBLE_STATUS_TYPE.SystemBleNotEnabled)
            {
                // Do Sth
            }
            else if (bluetoothStatus == VDIType.CHECKBLE_STATUS_TYPE.SystemLocationNotEnabled)
            {
                // Do Sth
            }
            else if (bluetoothStatus == VDIType.CHECKBLE_STATUS_TYPE.SystemNotSupportBle)
            {
                // Do Sth
            }
            else if (bluetoothStatus == VDIType.CHECKBLE_STATUS_TYPE.ResultOk)
            {
                // Do Sth
            }
            else
            {
                // Do Sth   
            }
            mBleReader.AddPDList("deviceId");
            mBleReader.AddPDList("deviceId", "password");
            mBleReader.RemovePDList("deviceId");
            mBleReader.PurgePDList();
            var pdListLength = mBleReader.PDListLength;
            mBleReader.StartTemperatureUpdate();
            mBleReader.StopTemperatureUpdate();
            if (Build.Manufacturer?.ToLower() == "samsung")
            {
                if (Build.VERSION.PreviewSdkInt >= 23)
                {
                    var serviceIntent = new Intent(this, typeof(VDIBleService));
                    StartService(serviceIntent);
                    BindService(serviceIntent, null, 0);
                }
            }
            var chargerInfo = new ChargerInfo("chie?", "chie??", VDIType.CHARGER_BATTERY_STATUS.Low, 0.3f);
            // var deviceInfo = new DeviceInfo();

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}