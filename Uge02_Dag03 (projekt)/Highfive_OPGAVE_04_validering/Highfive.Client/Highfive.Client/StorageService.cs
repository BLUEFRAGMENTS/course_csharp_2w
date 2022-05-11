using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Highfive.Client
{
    internal class StorageService
    {
        private string filePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "temp.txt");

        public void StoreUsername(string username)
        {
            File.WriteAllText(filePath, username);
        }

        public string RetrieveUsernameIfAny()
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }

            return string.Empty;
        }
    }
}
