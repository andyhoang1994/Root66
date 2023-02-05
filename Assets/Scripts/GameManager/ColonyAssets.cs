using UnityEngine;

public class ColonyAssets: MonoBehaviour
{
    public static ColonyAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public GameObject colony1;
    public GameObject colony2;
    public GameObject colony3;
}