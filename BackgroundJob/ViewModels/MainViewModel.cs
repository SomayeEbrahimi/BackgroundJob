using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BackgroundJob.ViewModels
{
    public class MainViewModel
    {
        public List<string> ItemsList { get; set; } = new List<string>();

        public ICommand AddCommand { get; set; }
        public ICommand ReadCommand { get; set; }

        public MainViewModel()
        {
            AddCommand = new Command(async () => await Add());
            ReadCommand = new Command(async () => await Read());
        }

        async Task Add()
        {
            using (var writer = new StreamWriter(GetFilePath(), append: true))
            {
               await writer.WriteLineAsync(DateTime.Now.ToString());
            }
        }

        async Task Read()
        {
            using (var reader = new StreamReader(GetFilePath()))
            {
                while (reader.ReadLine() != null)
                    ItemsList.Add(await reader.ReadLineAsync());
            }
        }

        string GetFilePath()
        {
            string rootPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(rootPath, "DateTime.txt");
        }
    }
}
