using System;
using System.Collections.Generic;

namespace MbmStore.Models.Products
{
    public class MusicCD: Product
    {
        public MusicCD(string title, decimal price, string artist, short released) : base(title, price)
        {
            Artist = artist;
            Released = released;
            Tracks = new List<Track>();
        }

        public string Artist;
        public string Label;
        public short Released;
        public readonly TimeSpan PlayingTime;
        public readonly List<Track> Tracks;

        public void AddTrack(Track track)
        {
            Tracks.Add(track);
        }
    }
}