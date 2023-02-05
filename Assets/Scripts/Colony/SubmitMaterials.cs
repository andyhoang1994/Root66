using UnityEngine;

public class SubmitMaterials : MonoBehaviour
{
    [SerializeField] private GameState gameState;
    public GameObject spawnPrefabOnPickup;

    public float destroySpawnPrefabDelay = 2;

    [Tooltip("Destroy this gameobject after collectDuration seconds")]
    public float collectDuration = 0f;

    private bool active;

    void Start()
    {
        /*Objective.OnRegisterPickup?.Invoke(this);*/
    }

    void OnCollect()
    {
/*        if (CollectSound)
        {
            AudioUtility.CreateSFX(CollectSound, transform.position, AudioUtility.AudioGroups.Pickup, 0f);
        }

        if (spawnPrefabOnPickup)
        {
            var vfx = Instantiate(spawnPrefabOnPickup, CollectVFXSpawnPoint.position, Quaternion.identity);
            Destroy(vfx, destroySpawnPrefabDelay);
        }*/

        /*Objective.OnUnregisterPickup(this);*/

        active = false;
        Destroy(gameObject, collectDuration);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            OnCollect();
        }
        
    }

    void OnEnable()
    {
        active = true;
    }
}
