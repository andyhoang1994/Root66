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
    private Inventory inventory;

    private Objective objective = Objective.None;

    void Start()
    {
        inventory = new Inventory();
        ObjectiveSpawner.SpawnColony(ObjectiveAssets.Instance.colony1);
        ObjectiveSpawner.SpawnColony(ObjectiveAssets.Instance.colony2);
        ObjectiveSpawner.SpawnColony(ObjectiveAssets.Instance.colony3);
        ObjectiveSpawner.SpawnHome();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
