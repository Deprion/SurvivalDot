using UnityEngine;

public class MobSpawner : MonoBehaviour
{
    [SerializeField]
    private MobSpawnPreset[] mobArray;
    [SerializeField]
    private float AreaRange;
    private Transform parentTransform;
    private void Start()
    {
        parentTransform = gameObject.transform.GetChild(0);
        foreach (MobSpawnPreset preset in mobArray)
        {
            for (int i = 0; i < preset.MobCount; i++) SpawnMob(preset);
        }
    }
    private void SpawnMob(MobSpawnPreset preset)
    {
        var obj = Instantiate(preset.Mob.MobPrefab, RandomPos(preset), Quaternion.identity);
        obj.transform.SetParent(parentTransform, false);
        //LevelScaler.ScaleLevel(ref mobArray[0], 1);
    }

    private Vector2 RandomPos(MobSpawnPreset preset)
    {
        return preset.MobPosition + Random.insideUnitCircle * preset.SpawnRadius;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(gameObject.transform.position, AreaRange);
    }
}
