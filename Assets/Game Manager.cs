using UnityEngine;

public enum EquipWeapon
{
    AK47,
    DESSERT_EAGLE,
    ROCKET_lAUNCHER
}
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Player Stats")]
    public float basePlayerDamage;
    public float finalPlayerDamage;
    [Header("Equip Weapon")]
    public EquipWeapon eweapon;
    [Header("Exprience")]
    public float MAX_XP;
    public float Current_XP;
    public int playerlvl;
    public float EXP_to_Add;

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //{
        //    DamagePowerUP_FeedingFrenzy();
        //}
    }

    private void OnValidate()
    {
        DamageSystem damageSystem = new DamageSystem();
        switch (eweapon)
        {
            case
                EquipWeapon.AK47:
                finalPlayerDamage = basePlayerDamage + damageSystem.Damage_AK47;
                break;
            case
                EquipWeapon.DESSERT_EAGLE:
                finalPlayerDamage = basePlayerDamage + damageSystem.Damage_Dessert_Eagle;
                break;
            case
                EquipWeapon.ROCKET_lAUNCHER:
                finalPlayerDamage = basePlayerDamage + damageSystem.Damage_Rocket_Launcher;
                break;
            default:
                break;

        }
    }
    public void DamagePowerUP_FeedingFrenzy()
    {
        PowerUP powerUP = new();
        finalPlayerDamage += powerUP.Feeding_Frenzy;
    }
    public void DamagePowerUP_WellFed()
    {
        PowerUP powerUP = new();
        float power_Up_Player_Damage = (finalPlayerDamage * (powerUP.Well_Fed / 100));
        finalPlayerDamage = power_Up_Player_Damage + finalPlayerDamage;
    }
    public void ResetValues()
    {
        DamageSystem damageSystem = new DamageSystem();
        switch (eweapon)
        {
            case
                EquipWeapon.AK47:
                finalPlayerDamage = basePlayerDamage + damageSystem.Damage_AK47;
                break;
            case
                EquipWeapon.DESSERT_EAGLE:
                finalPlayerDamage = basePlayerDamage + damageSystem.Damage_Dessert_Eagle;
                break;
            case
                EquipWeapon.ROCKET_lAUNCHER:
                finalPlayerDamage = basePlayerDamage + damageSystem.Damage_Rocket_Launcher;
                break;
            default:
                break;

        }
    }
}
