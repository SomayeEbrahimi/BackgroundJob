using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using Xamarin.Forms;

namespace BackgroundJob.ViewModels
{
    public class MainViewModel
    {
        public List<string> ItemsList { get; set; }

        public Command AddCommand { get; set; }
        public Command ReadCommand { get; set; }

        public MainViewModel()
        {
            AddCommand = new Command(Add);
            ReadCommand = new Command(Read);
        }


        void Add()
        {
            using (var writer = new StreamWriter(GetFileStream()))
            {
                writer.WriteLine(DateTime.Now);
            }
        }

        void Read()
        {
            using (var reader = new StreamReader(GetFileStream()))
            {
                var serializer = new XmlSerializer(typeof(List<string>));
                ItemsList = (List<string>)serializer.Deserialize(reader);
            }
        }

        Stream GetFileStream()
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainViewModel)).Assembly;

            return assembly.GetManifestResourceStream("BackgroundJob.DateTime.txt");
        }
    }
}
