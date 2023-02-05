using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
/*        if (collision.gameObject.layer == "Terrain")
        {
            Physics.IgnoreCollision(collision.gameObject.GetComponent<Collider>, GetComponent<Collider>());
        }*/

    }
}