using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LevelScaler
{
    public static void ScaleLevel(ref MobSpawnPreset mob, int level)
    {
        switch (mob.ScaleType)
        {
            case StaticContainer.LevelScaleType.straight: mob.Mob.HP = 15;
                break;
            case StaticContainer.LevelScaleType.none:
                break;
        }
    }
}
