﻿namespace p11_InfernoInfinity.Models.Gems
{
    public class Emerald : Gem
    {
        public Emerald(string clarity) 
            : base(clarity)
        {
            this.Stat = new Stat(1,4,9);
            this.GetStatsBonus();
        }
    }
}
