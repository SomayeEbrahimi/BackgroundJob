using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BackgroundJob.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> ItemsList { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand AddCommand { get; set; }
        public ICommand ReadCommand { get; set; }

        public MainViewModel()
        {
            AddCommand = new Command(async () => await Add());
            ReadCommand = new Command(async () => await Read());
        }

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
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
            ItemsList = new ObservableCollection<string>();

            using (var reader = new StreamReader(GetFilePath()))
            {
                while (reader.ReadLine() != null)
                    ItemsList.Add(await reader.ReadLineAsync());
            }

            OnPropertyChanged("ItemsList");
        }

        string GetFilePath()
        {
            string rootPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(rootPath, "DateTime.txt");
        }
    }
}
