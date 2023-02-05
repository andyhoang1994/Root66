using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColonySpawner : MonoBehaviour
{
    public static void SpawnColony(Vector3 position, Colony colony) {
        Instantiate(ColonyAssets.Instance.colony1, position, Quaternion.identity);
    }
}
