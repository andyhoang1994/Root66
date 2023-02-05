using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Material> materials = new List<Material>();
    public List<Material> Materials { get; set; }

    public Inventory()
    {
        Material wood = new Material(MaterialType.Wood, 1);
        this.materials.Add(wood);

        Debug.Log($"amount: {this.materials.Count}");
    }

    public void AddItem(MaterialType materialType, int quantity)
    {
        Material material = new Material(materialType, quantity);
        this.materials.Add(material);
    }
}