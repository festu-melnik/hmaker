using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace HTMLCreator.Config
{
    static class ConfigurationManager
    {
        private static SoapFormatter formatter;
        private static string defPath;

        public static Configuration CurrentConfig { get; set; }

        static ConfigurationManager()
        {
            formatter = new SoapFormatter();
            defPath = "config.xml";

            CurrentConfig = new Configuration();
        }

        public static void LoadConfig()
        {
            if (File.Exists(defPath))
                LoadConfig(defPath);
        }

        public static void LoadConfig(string confPath)
        {
            using (Stream stream = File.Open(confPath, FileMode.Open))
            {
                CurrentConfig = (Configuration)formatter.Deserialize(stream);
            }
        }

        public static void SaveConfig()
        {
            SaveConfig(defPath);
        }

        public static void SaveConfig(string confPath)
        {
            using (Stream stream = File.Open(confPath, FileMode.Create))
            {
                formatter.Serialize(stream, CurrentConfig);
            }
        }
    }
}