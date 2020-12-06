using System;
using System.IO;
namespace RKitchen.Audio
{
    public delegate Stream AudioSource();
    public delegate void AudioSink(Stream data);
    public delegate Track FromAudioStream(Stream source);
    public delegate Stream ToAudioStream(Track source);
}