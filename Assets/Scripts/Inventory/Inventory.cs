using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MaterialType
{
    Wood, Iron
}

public enum WeaponType
{
    Gun
}

public class Inventory : MonoBehaviour
{
    private List<Material> materials = new List<Material>();
    private List<Material> Materials { get; set; }


    void Start()
    {
        Material wood = new Material(MaterialType.Wood, 1);
        materials.Add(wood);

        Debug.Log($"amount: {materials.Count}");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class Material
{
    public Material(MaterialType type, int quantity)
    {
        this.type = type;
        this.quantity = quantity;
    }

    public int quantity;

    public MaterialType type;
}

public class Weapon
{
    public Weapon() { }

    private WeaponType type = WeaponType.Gun;
    private WeaponType Type { get; set; }


    private float health = 100f;
    private float Health { get; set; }

    private float damage = 5f;
    private float Damage { get; set; }

    private float range = 50f;
    private float Range { get; }
}