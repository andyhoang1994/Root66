using UnityEngine;

public class ObjectiveAssets: MonoBehaviour
{
    public static ObjectiveAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public GameObject colony1;
    public GameObject colony2;
    public GameObject colony3;
    public GameObject home;
}