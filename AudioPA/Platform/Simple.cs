using System;
using System.Runtime.InteropServices;
namespace RKitchen.Audio.PA.Platform
{
    internal static class Simple
    {
        [DllImport("pulseaudio")]
        public extern static void pa_sample_free(IntPtr s);
    }
}