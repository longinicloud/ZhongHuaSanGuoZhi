﻿namespace GameObjects.ArchitectureDetail.EventEffect
{
    using GameObjects;
    using System;

    internal class EventEffect305 : EventEffectKind
    {
        private int increment;

        public override void ApplyEffectKind(Person person, Event e)
        {
            GameObjects.PersonDetail.Skill skill = person.Scenario.GameCommonData.AllSkills.GetSkill(increment);
            person.Skills.Skills.Remove(increment);
            skill.Influences.PurifyInfluence(person, GameObjects.Influences.Applier.Skill, increment);
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
    }
}

