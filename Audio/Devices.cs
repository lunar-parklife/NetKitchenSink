using System;
using System.Threading;
namespace RKitchen.Audio
{
    public interface IAudioDevice : IDisposable
    {
        string Name { get; }
        AudioDeviceFlags Flags { get; }
    }

    [Flags]
    [Serializable]
    public enum AudioDeviceFlags : byte
    {
        Unknown = 0x00
    }
}