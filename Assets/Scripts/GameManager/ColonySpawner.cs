using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveSpawner : MonoBehaviour
{
    public static void SpawnColony(GameObject colony)
    { 
        Instantiate(colony, colony.transform.position, Quaternion.identity);
    }

    public static void SpawnRandomColony()
    {
        int val = Random.Range(1, 4);
        Debug.Log($"val: {val}");
        switch (val) {
            case 1:
                SpawnColony(ObjectiveAssets.Instance.colony1);
                break;
            case 2:
                SpawnColony(ObjectiveAssets.Instance.colony2);
                break;
            case 3:
                SpawnColony(ObjectiveAssets.Instance.colony1);
                break;
        }
    }

    public static void SpawnHome()
    {
        GameObject home = ObjectiveAssets.Instance.home;
        Instantiate(home, home.transform.position, Quaternion.identity);
    }
}
