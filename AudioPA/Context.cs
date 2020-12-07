using System;
namespace RKitchen.Audio.PA
{
    public sealed class PaContext : IAudioContext
    {
        public string Name { get; }

        public IAudioDevice ConnectNew(string desc, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}