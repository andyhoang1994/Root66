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
/*
public class ColonyMap
{
    private GameObject colony;
    public GameObject Colony { get; }

    private Vector3 position;
    public Vector3 Position { get; }

    public ColonyMap(GameObject colony, Vector3 position)
    {
        this.colony = colony;
        this.position = position;
    }
}*/