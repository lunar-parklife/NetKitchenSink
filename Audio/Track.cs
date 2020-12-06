using System;
using System.Collections.Generic;
namespace RKitchen.Audio
{
    [Serializable]
    public sealed class Track
    {
        public string Name { get; }
        public IList<Sample> Samples { get; }
    }
}