using UnityEngine;

public class GetMaterials : MonoBehaviour
{
    public float collectDuration = 0f;

    void OnCollect()
    {
        Destroy(gameObject, collectDuration);
        ObjectiveSpawner.SpawnRandomColony();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            OnCollect();
        }
    }
}
