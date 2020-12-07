using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace RKitchen.Audio.PA
{
    public sealed class PaContext : IAudioContext
    {
        private bool simple;
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
            Debug.WriteLine($"Disposing of {Name}...");
            foreach(IAudioDevice c in devices) c.Dispose();
            if (simple) Platform.Simple.pa_sample_free(contextData);
        }
    }
}