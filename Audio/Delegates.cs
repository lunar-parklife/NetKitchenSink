using System;
using System.Collections.Generic;
using System.IO;
namespace RKitchen.Audio
{
    public delegate Stream AudioSource(IAudioDevice device);
    public delegate void AudioSink(Stream data, IAudioDevice device);
    public delegate Track FromAudioStream(Stream source);
    public delegate Stream ToAudioStream(Track source);

    public static class DelegateStruct
    {
        public static IDictionary<string, AudioSource> Sources { get; } =
            new Dictionary<string, AudioSource>();
        public static IDictionary<string, AudioSink> Sinks { get; } =
            new Dictionary<string, AudioSink>();
    }
}