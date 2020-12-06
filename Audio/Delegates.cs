using System;
using System.Collections.Generic;
using System.IO;
namespace RKitchen.Audio
{
    using SourceMap = Dictionary<string, AudioSource>;
    using SinkMap = Dictionary<string, AudioSink>;
    using FromAudioMap = Dictionary<string, FromAudioStream>;
    using ToAudioMap = Dictionary<string, ToAudioStream>;

    public delegate Stream AudioSource(IAudioDevice device);
    public delegate void AudioSink(Stream data, IAudioDevice device);
    public delegate Track FromAudioStream(Stream source);
    public delegate Stream ToAudioStream(Track source);

    public static class DelegateStruct
    {
        public static SourceMap Sources { get; } = new SourceMap();
        public static SinkMap Sinks { get; } = new SinkMap();
        public static FromAudioMap StreamFro { get; } = new FromAudioMap();
        public static ToAudioMap StreamTo { get; } = new ToAudioMap();
    }
}