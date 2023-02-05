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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
