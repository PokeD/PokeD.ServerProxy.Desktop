using System;

using PCLStorage;

namespace PokeD.ServerProxy.Desktop.WrapperInstances
{
    public class FileSystemWrapperInstance : Core.Wrappers.IFileSystem
    {
        public IFolder UsersFolder { get { throw new NotImplementedException(); } }

        public IFolder SettingsFolder { get; }
        public IFolder LogFolder { get; }
        
        public FileSystemWrapperInstance()
        {
            var baseDirectory = FileSystem.Current.GetFolderFromPathAsync(AppDomain.CurrentDomain.BaseDirectory).Result;

            SettingsFolder  = baseDirectory.CreateFolderAsync("Settings", CreationCollisionOption.OpenIfExists).Result;
            LogFolder       = baseDirectory.CreateFolderAsync("Logs", CreationCollisionOption.OpenIfExists).Result;
        }
    }
}
