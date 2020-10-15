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
            String path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            
            return Path.Combine(path, FileName);
        }

    }
}
