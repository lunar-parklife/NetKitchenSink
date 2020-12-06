using System;
using System.Collections.Generic;
namespace RKitchen.Audio
{
    [Serializable]
    public sealed class Track
    {
        public Track()
        {
            Name = "Unnamed";
            Samples = new List<Sample>();
        }

        public string Name { get; set; }
        public IList<Sample> Samples { get; }
    }
}