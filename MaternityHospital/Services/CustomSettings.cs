using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MaternityHospital.Services
{
    [Serializable]
    internal class CustomSettings
    {

        private int _currentFontSize;
        public int CurrentFontSize
        {
            get
            {
                return _currentFontSize;
            }
            set
            {
                _currentFontSize = value;
            }
        }
        private string _currentDoctor;
        public string CurrentDoctor
        {
            get
            {
                return _currentDoctor ?? "???";
            }
            set
            {
                _currentDoctor = value;
            }
        }
        private string _filePath;
        public CustomSettings()
        {
            _filePath = $"{Environment.CurrentDirectory}/{ConfigurationManager.AppSettings["AppSettings"]}";

            if (File.Exists(_filePath)) SetCustomSettings();
            else SetDefaultSettings();
        }

        private void SetDefaultSettings()
        {
            CurrentFontSize = int.Parse(ConfigurationManager.AppSettings["CurrentFontSize"]);
            CurrentDoctor = ConfigurationManager.AppSettings["CurrentDoctor"];
        }

        private void SetCustomSettings()
        {
            string json;
            using (var sr = new StreamReader(_filePath))
            {
                json = sr.ReadToEnd();
            }
            var settings = JsonSerializer.Deserialize<CustomSettings>(json);
            CurrentDoctor = settings.CurrentDoctor;
            CurrentFontSize = settings.CurrentFontSize;
        }

        public void SaveCustomSettings()
        {
            var json = JsonSerializer.Serialize(this);
            using (var sw = new StreamWriter(_filePath))
            using (FileStream fs = new FileStream(_filePath, FileMode.Create))
            {
                byte[] input = Encoding.Default.GetBytes(json);
                // запись массива байтов в файл
                fs.Write(input, 0, input.Length);
            }
        }
    }
}
