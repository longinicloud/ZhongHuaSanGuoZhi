﻿namespace GameObjects.Influences.InfluenceKindPack
{
    using GameObjects;
    using GameObjects.Influences;
    using System;

    internal class InfluenceKind3300 : InfluenceKind
    {
        private int increment = 0;

        public override void ApplyInfluenceKind(Architecture architecture)
        {
            architecture.IncrementOfFactionReputationPerDay += this.increment;
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

        public override void PurifyInfluenceKind(Architecture architecture)
        {
            architecture.IncrementOfFactionReputationPerDay -= this.increment;
        }

        public override double AIFacilityValue(Architecture a)
        {
            return (a.BelongedFaction.Reputation >= a.BelongedFaction.MaxPossibleReputation ? 0.001 : this.increment / 5.0);
        }
    }
}

