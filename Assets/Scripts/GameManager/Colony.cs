using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Colony : MonoBehaviour
{
    private Weapon weapon;
    private Weapon Weapon { get; set; }
    private List<Material> requestedMaterials;
    private List<Material> remainingMaterials;
    private bool isActive = false;

    public Colony(List<Material> materials)
    {
        this.isActive = true;
        this.requestedMaterials = materials;
        this.remainingMaterials = materials;
    }

    public void SetWeapon(Weapon weapon)
    {
        this.weapon = weapon;
    }

    public void SubmitMaterials(Material material)
    {
        foreach(Material remainingMaterial in this.remainingMaterials)
        {
            if (remainingMaterial.Type == material.Type)
            {
                int difference = remainingMaterial.Quantity - material.Quantity;

                switch(difference > 0)
                {
                    case true:
                        {
                            remainingMaterial.Quantity -= difference;
                            material.Quantity = 0;
                            Debug.Log($"Material left: {remainingMaterial.Quantity}");
                            break;
                        }
                    case false:
                        {
                            remainingMaterial.Quantity = 0;
                            material.Quantity = difference;
                            Debug.Log($"Material left: {difference}");
                            break;
                        }
                }
            }
        };
    }
}