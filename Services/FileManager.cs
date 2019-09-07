using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Etudiant.Services
{
    public class FileManager
    {

        public async void SaveFile(string filePath, string base64Img)
        {
            byte[] bytes = Convert.FromBase64String(base64Img);
            await File.WriteAllBytesAsync(filePath, bytes);
        }
    }
}
