using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int HP { get; set; }
    public int MP { get; set; }
    public int XP { get; set; }
    public int LVL { get; set; }
    public int[] ArrayOfDamage { get; set; } = new int[3];
}
