using HospitalManagementSystem.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class  IniSetting<T>
    {
        IniFile iniFile;

        public string Path { get; }

        public IniSetting (string path = "settings.ini") 
        {
            this.Path = path;
            CreateFileIfNotExist();
            iniFile = new IniFile(Path);
        }

        private void CreateFileIfNotExist()
        {
            if (!File.Exists(this.Path))
            {
                var file = File.Create(this.Path);
                file.Close();
            }
        }

        public bool KeyExists(string key) 
        {
            return iniFile.KeyExists(key);
        }

        public virtual void Write(string key, T data, string section = null)
        {
            iniFile.Write(key, data.ToString(),section);
        }

        public virtual T Read(string key, string section = null)
        {
            string data = iniFile.Read(key,section);
            return (T)Convert.ChangeType(data, typeof(T));
        }

        public void RemoveSection(string section)
        {
            iniFile.DeleteSection(section);
        }

        public virtual void RemoveKey(string key,string section = null)
        {
            iniFile.DeleteKey(key);
        }
    }
}
