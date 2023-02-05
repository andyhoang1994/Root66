using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColonySpawner : MonoBehaviour
{
    public static ColonySpawer(Vector3 position, Colony colony) {
        Transform transform = Instantiate(ColonyAssets.Instance.pfColonies, position, Quaternion.identity);

        ColonySpawner colonySpawner = transform.GetComponent<ColonySpawner>();
        colonySpawner.SetColony(colony);
    }

    private Colony colony;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void setColony(Colony colony)
    {
        this.colony = colony;
        spriteRenderer.sprite = colony.GetSprite();
    }
}
