using System;
using System.Runtime.InteropServices;
namespace RKitchen.Audio.PA.Platform
{
    internal static class Simple
    {
        [DllImport("pulseaudio")]
        internal extern static IntPtr pa_simple_new(
            [MarshalAs(UnmanagedType.AnsiBStr)] string server,
            [MarshalAs(UnmanagedType.AnsiBStr)] string name,
            int dir,
            [MarshalAs(UnmanagedType.AnsiBStr)] string dev
        );

        [DllImport("pulseaudio")]
        internal extern static void pa_sample_free(IntPtr s);

        [DllImport("puseaudio")]
        internal extern static int pa_simple_write(
            IntPtr s,
            IntPtr data,
            uint bytes,
            IntPtr error
        );
    }
}