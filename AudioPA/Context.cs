using System;
using System.Collections.Generic;
namespace RKitchen.Audio.PA
{
    public sealed class PaContext : IAudioContext
    {
        private IntPtr contextData;
        private IList<IAudioDevice> devices;

        public PaContext()
        {
            //
        }

        public string Name { get; }

        public IAudioDevice ConnectNew(string desc, params object[] args)
        {
            throw new NotImplementedException();
        }

        public IAudioDevice ConnectExist(string desc)
        {
            throw new NotImplementedException();
        }

        public void DestroyDevice(string desc)
        {
            //
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}