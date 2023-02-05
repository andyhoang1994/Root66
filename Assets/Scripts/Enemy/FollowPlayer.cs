using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject wayPoint;
    private Vector3 wayPointPos;

    [SerializeField] private float speed = 50.0f;

    void Start()
    {
        // wayPoint = GameObject.Find("WayPoint");
    }

    void Update()
    {
        wayPointPos = new Vector3(wayPoint.transform.position.x, wayPoint.transform.position.y, wayPoint.transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
    }
}
