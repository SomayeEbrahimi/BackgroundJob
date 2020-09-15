using Matcha.BackgroundService;
using System;
using System.IO;
using System.Threading.Tasks;

namespace BackgroundJob.Service
{
    public class WriterService : IPeriodicTask
    {
        public WriterService()
        {
            Interval = TimeSpan.FromSeconds(1);
        }

        public TimeSpan Interval { get; set; }

        public async Task<bool> StartJob()
        {
            await WriteDateTime();

            return true;
        }

        async Task WriteDateTime()
        {
            string rootPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string path = Path.Combine(rootPath, "DateTime.txt");

            using (var writer = new StreamWriter(path, append: true))
            {
                await writer.WriteLineAsync(DateTime.Now.ToString());
            }
        }
    }
}
