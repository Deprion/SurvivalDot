using UnityEngine;

public class Mob : MonoBehaviour
{
    public GameObject MobPrefab;
    public int HP;
    public int MaxHP;
    public int MP;
    public int MaxMP;
    public int LVL;
    public int[] ArrayOfDamage;
    public float Speed;
    public float AttackSpeed;
    public float HPRegen;
    public float MPRegen;
    public int XPReward;
    public int MoneyReward;
    public Item[] Drop;

    public Mob(MobSO so)
    {
        MobPrefab = so.MobPrefab;
        MaxHP = so.HP;
        MaxMP = so.MP;
        HP = so.HP;
        MP = so.HP;
        LVL = so.LVL;
        ArrayOfDamage = new int[so.ArrayOfDamage.Length];
        so.ArrayOfDamage.CopyTo(ArrayOfDamage, 0);
        Speed = so.Speed;
        AttackSpeed = so.AttackSpeed;
        HPRegen = so.HPRegen;
        MPRegen = so.MPRegen;
        XPReward = so.XPReward;
        MoneyReward = so.MoneyReward;
        Drop = so.Drop;
    }
}
