﻿namespace GameObjects.Conditions.ConditionKindPack
{
    using GameObjects;
    using GameObjects.Conditions;
    using System;

    internal class ConditionKind1601 : ConditionKind
    {
        public override bool CheckConditionKind(Troop troop)
        {
            foreach (Person p in troop.Persons)
            {
                if (p != null && p.BelongedFaction != null && p.BelongedFaction.Leader == p)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

