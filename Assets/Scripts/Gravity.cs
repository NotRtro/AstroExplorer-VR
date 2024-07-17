using UnityEngine;

public class GravitationalAttraction : MonoBehaviour
{
    public Rigidbody sun;
    public float G = 6.67430e-21f;

    void FixedUpdate()
    {
        ApplyGravitationalForces();
    }

    void ApplyGravitationalForces()
    {
        Rigidbody[] rigidbodies = FindObjectsOfType<Rigidbody>();
        for (int i = 0; i < rigidbodies.Length; i++)
        {
            if (rigidbodies[i] != sun) // Avoid applying force to the sun itself
            {
                Vector3 direction = sun.gameObject.transform.position - rigidbodies[i].gameObject.transform.position;
                float distance = direction.magnitude;
                Vector3 forceDirection = direction.normalized;
                float forceMagnitude = G * rigidbodies[i].mass * sun.mass / Mathf.Pow(distance, 2);
                Vector3 force = forceDirection * forceMagnitude;
                rigidbodies[i].AddForce(force);
            }
        }
    }
}
