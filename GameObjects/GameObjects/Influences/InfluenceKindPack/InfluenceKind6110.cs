﻿namespace GameObjects.Influences.InfluenceKindPack
{
    using GameObjects;
    using GameObjects.Influences;
    using System;

    internal class InfluenceKind6110 : InfluenceKind
    {
        private int increment;

        public override void ApplyInfluenceKind(Architecture a)
        {
            a.captureChance += this.increment;
        }

        public override void PurifyInfluenceKind(Architecture a)
        {
            a.captureChance -= this.increment;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.increment = int.Parse(parameter);
            }
            catch
            {
            }
        }

        public override double AIFacilityValue(Architecture a)
        {
            return this.increment * 10 / (double)a.BelongedFaction.PersonCount * (a.FrontLine ? 1 : 0.2);
        }
    }
}

