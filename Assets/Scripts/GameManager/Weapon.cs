public enum WeaponType
{
    Gun
}

public class Weapon
{
    public Weapon() { }

    private WeaponType type = WeaponType.Gun;
    private WeaponType Type { get; set; }


    private float health = 100f;
    public float Health { get; set; }

    private float damage = 5f;
    public float Damage { get; set; }

    private float range = 50f;
    public float Range { get; }
}