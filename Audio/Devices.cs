using System;
using System.IO;
namespace RKitchen.Audio
{
    public interface IAudioDevice : IDisposable
    {
        string Name { get; }
        Stream Broadcast();
        Stream Listen();
    }
}