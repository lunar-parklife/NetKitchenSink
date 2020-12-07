using System;
using System.Runtime.InteropServices;
namespace RKitchen.Audio.PA.Platform
{
    internal static unsafe class Simple
    {
        [DllImport("pulseaudio")]
        internal extern static IntPtr pa_simple_new(
            [MarshalAs(UnmanagedType.BStr)] string server,
            [MarshalAs(UnmanagedType.BStr)] string name,
            StreamDirection dir,
            [MarshalAs(UnmanagedType.BStr)] string dev
        );

        [DllImport("pulseaudio")]
        internal extern static void pa_sample_free(IntPtr s);

        [DllImport("puseaudio")]
        internal extern static int pa_simple_write(
            IntPtr s,
            byte* data,
            uint bytes,
            int* error
        );
    }
}