using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Objective
{
    None,
    Fetch,
    Deliver,
}

public class GameState : MonoBehaviour
{
    public Inventory inventory;
    public int test = 2;

    private Objective objective = Objective.None;

    void Awake()
    {
        Debug.Log("initializing");

        this.inventory = new Inventory();
        this.test = 5;
        ObjectiveSpawner.SpawnColony(ObjectiveAssets.Instance.colony1);
        ObjectiveSpawner.SpawnColony(ObjectiveAssets.Instance.colony2);
        ObjectiveSpawner.SpawnColony(ObjectiveAssets.Instance.colony3);
        ObjectiveSpawner.SpawnHome();
    }
}
