using System;
using System.IO;
using System.Text.Json;

namespace TP_MODUL9_103022430005
{
    internal class CovidConfig
    {
        public ConfigData config;
        public string filePath = "covid_config.json";

        public CovidConfig()
        {
            LoadConfig();
        }

        public void LoadConfig()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                config = JsonSerializer.Deserialize<ConfigData>(json);
            }
            else
            {
                SetDefault();
                SaveConfig();
            }
        }

        public void SetDefault()
        {
            config = new ConfigData
            {
                satuan_suhu = "celcius",
                batas_hari_deman = 14,
                pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini",
                pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini"
            };
        }

        public void SaveConfig()
        {
            string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public void UbahSatuan()
        {
            if (config.satuan_suhu == "celcius")
            {
                config.satuan_suhu = "fahrenheit";
            }
            else
            {
                config.satuan_suhu = "celcius";
            }

            SaveConfig();
        }
    }
}