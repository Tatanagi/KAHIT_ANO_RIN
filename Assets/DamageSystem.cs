public class DamageSystem
{
    int damage_AK47 = 20;
    int damage_dessert_eagle = 15;
    int rocket_launcher = 100;

    public int Damage_AK47
    {
        get { return damage_AK47; }
        set { damage_AK47 = value; }
    }
    public int Damage_Dessert_Eagle
    {
        get { return damage_dessert_eagle; }
        set { damage_dessert_eagle = value; }
    }
    public int Damage_Rocket_Launcher
    {
        get { return rocket_launcher; }
        set { rocket_launcher = value; }
    }
    
}
public class PowerUP
{
    //Base Damage Power Up
    float feeding_frenzy = 20;
    public float Feeding_Frenzy
    {
        get { return feeding_frenzy; }
        set { feeding_frenzy = value; }
    }
    //Percentage Power Up
    float wellFed = 30;
    public float Well_Fed
    {
        get { return wellFed; }
        set { wellFed = value; }
    }
}
