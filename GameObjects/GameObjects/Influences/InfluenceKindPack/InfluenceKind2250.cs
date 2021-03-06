﻿namespace GameObjects.Influences.InfluenceKindPack
{
    using GameObjects;
    using GameObjects.Influences;
    using System;

    internal class InfluenceKind2250 : InfluenceKind
    {
        private float rate = 0f;
        private int type = 0;

        public override void ApplyInfluenceKind(Faction faction)
        {
            switch (this.type)
            {
                case 0:
                    faction.DefenceRateOfBubing += this.rate;
                    break;

                case 1:
                    faction.DefenceRateOfNubing += this.rate;
                    break;

                case 2:
                    faction.DefenceRateOfQibing += this.rate;
                    break;

                case 3:
                    faction.DefenceRateOfShuijun += this.rate;
                    break;

                case 4:
                    faction.DefenceRateOfQixie += this.rate;
                    break;
            }
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.type = int.Parse(parameter);
            }
            catch
            {
            }
        }

        public override void InitializeParameter2(string parameter)
        {
            try
            {
                this.rate = float.Parse(parameter);
            }
            catch
            {
            }
        }

        public override void PurifyInfluenceKind(Faction faction)
        {
            switch (this.type)
            {
                case 0:
                    faction.DefenceRateOfBubing -= this.rate;
                    break;

                case 1:
                    faction.DefenceRateOfNubing -= this.rate;
                    break;

                case 2:
                    faction.DefenceRateOfQibing -= this.rate;
                    break;

                case 3:
                    faction.DefenceRateOfShuijun -= this.rate;
                    break;

                case 4:
                    faction.DefenceRateOfQixie -= this.rate;
                    break;
            }
        }
    }
}

