using UnityEngine;

[CreateAssetMenu(fileName = "SpawnPreset", menuName = "SpawnPreset")]
public class MobSpawnPreset : ScriptableObject
{
    public MobSO Mob;
    public Vector2 MobPosition;
    public int MobCount;
    public int SpawnRadius;
    public StaticContainer.LevelScaleType ScaleType;
}
