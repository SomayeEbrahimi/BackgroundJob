using Android.Content;
using Android.OS;
using System;
using System.IO;

namespace BackgroundJob.Droid
{
    [BroadcastReceiver]
    public class BackgroundReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            string rootPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            string path = Path.Combine(rootPath, "DateTime.txt");

            using var writer = new StreamWriter(path, append: true);

            writer.WriteLine(DateTime.Now.ToString());
        }
    }
}