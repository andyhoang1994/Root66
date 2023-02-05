using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject wayPoint;
    public Rigidbody rigidbody;
    private Vector3 wayPointPos;

    [SerializeField] private float speed = 50.0f;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        wayPointPos = new Vector3(wayPoint.transform.position.x, rigidbody.velocity.y * 5, wayPoint.transform.position.z);
        Vector3 newVelocity = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
        var lookPosition = wayPointPos - transform.position;
        lookPosition.y = 0;
        var rotation = Quaternion.LookRotation(lookPosition);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);
        transform.position = newVelocity;
    }
}
