using UnityEngine;

[CreateAssetMenu(fileName = "Mob", menuName = "Mob")]
public class MobSO : ScriptableObject
{
    public GameObject MobPrefab;
    public int HP;
    public int MP;
    public int LVL;
    public int[] ArrayOfDamage = new int[3];
    public float Speed;
    public float AttackSpeed;
    public float HPRegen;
    public float MPRegen;
    public int XPReward;
    public int MoneyReward;
    public Item[] Drop;
}
