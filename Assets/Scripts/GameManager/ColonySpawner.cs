using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveSpawner : MonoBehaviour
{
    public static void SpawnColony(GameObject colony)
    { 
        Instantiate(colony, colony.transform.position, Quaternion.identity);
    }

    public static void SpawnHome()
    {
        GameObject home = ObjectiveAssets.Instance.home;
        Instantiate(home, home.transform.position, Quaternion.identity);
    }
}
