﻿using Saga.PrimaryTypes;

namespace Saga.Skills
{
    static partial class Spelltable
    {
        public static void RECRUIT_TRACKING(SkillBaseEventArgs bargument)
        {
            if (bargument.Context == Saga.Enumarations.SkillContext.SkillUse)
            {
                SkillUsageEventArgs arguments = (SkillUsageEventArgs)bargument;
                arguments.Result = Saga.SkillBaseEventArgs.ResultType.NoDamage;
                arguments.Damage = 0;
                arguments.Failed = false;
                Common.Skills.UpdateAddition(bargument.Target as Actor, arguments.Addition, 900000);
            }
        }
    }
}