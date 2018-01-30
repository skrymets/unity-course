using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpaceHazard : MonoBehaviour
{
    public float speed;

    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = Vector3.down * speed;
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, .5f);
    }
}
