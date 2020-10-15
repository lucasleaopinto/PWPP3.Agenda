using System;
using Contatos.Droid;
using Xamarin.Forms;
using System.IO;

[assembly: Dependency(typeof(FileHelper))]

namespace Contatos.Droid
{
    internal class FileHelper : IFileHelper
    {
        public String GetLocalFilePath(String FileName)
        {
            String docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            String libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, FileName);
        }

    }
}
