using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setZvelocity : MonoBehaviour
{
    public float initialZVelocity = 10.0f;

    void Start()
    {
        SetInitialVelocities();
    }

    void SetInitialVelocities()
    {
        Rigidbody[] rigidbodies = FindObjectsOfType<Rigidbody>();
        for (int i = 0; i < rigidbodies.Length; i++)
        {
            rigidbodies[i].velocity = new Vector3(0, 0, initialZVelocity);
        }
    }
}
