using UnityEngine;

public class SubmitMaterials : MonoBehaviour
{
    public float collectDuration = 0f;

    void OnCollect()
    {
        Destroy(gameObject, collectDuration);
        ObjectiveSpawner.SpawnHome();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            OnCollect();
        }
    }
}
