﻿using Saga.PrimaryTypes;

namespace Saga.Skills
{
    static partial class Spelltable
    {
        public static void GENERAL_WICKEDSTARMAGIC(SkillBaseEventArgs bargument)
        {
            if (bargument.Context == Saga.Enumarations.SkillContext.SkillUse)
            {
                SkillUsageEventArgs arguments = (SkillUsageEventArgs)bargument;
                arguments.Result = Saga.SkillBaseEventArgs.ResultType.NoDamage;
                arguments.Damage = 0;
                if (arguments.Target.ModelId == 10012 || arguments.Target.ModelId == 10013)
                {
                    arguments.Failed = !Common.Items.GiveItem(arguments.Sender as Character, 0, 0);
                }
                else
                {
                    arguments.Failed = true;
                }
            }
        }
    }
}