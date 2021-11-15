using HospitalManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Implementations
{
    public class LoginDetailIniSetting : IniSetting<string>
    {

        public LoginDetailIniSetting(string path = "login_info.ini") : base(path) { }
       
        public override string Read(string key, string section = null)
        {
            string encryptedData = base.Read(key,section).Trim();
            return Decryptor.Decrypt(encryptedData, Container.PASS);
        }

        public override void Write(string key, string data, string section = null)
        {
            string encryptedData = Encryptor.Encrypt(data, Container.PASS);
            base.Write(key, encryptedData,section);
        }
    }
}
