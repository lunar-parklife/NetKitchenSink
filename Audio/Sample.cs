using System;
using System.Runtime.ConstrainedExecution;
namespace RKitchen.Audio
{
    [ReliabilityContract (Consistency.WillNotCorruptState, Cer.Success)]
    [Serializable]
    public readonly struct Sample
    {
        public Sample(int pitch, uint length)
        {
            Pitch = pitch;
            Length = length;
        }

        public int Pitch { get; }
        public uint Length { get; }

        public override string ToString() => $"p{Pitch}-l{Length}";
    }
}