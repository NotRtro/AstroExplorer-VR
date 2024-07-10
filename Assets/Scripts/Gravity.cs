using UnityEngine;

public class GravitationalAttraction : MonoBehaviour
{
    public Rigidbody sun;
    public float G = 6.67430e-21f;

    void FixedUpdate()
    {
        
        Rigidbody[] Rigidbodies = FindObjectsOfType(typeof(Rigidbody)) as Rigidbody[];
        for (int i = 0; i < Rigidbodies.Length; i++)
        {
                Vector3 direction = sun.gameObject.transform.position - Rigidbodies[i].gameObject.transform.position;
                float distance = direction.magnitude;
                Vector3 forceDirection = direction.normalized;
                float forceMagnitude = G * Rigidbodies[i].mass * sun.mass / Mathf.Pow(distance, 2);
                Vector3 force = forceDirection * forceMagnitude;
                Rigidbodies[i].AddForce(force);
        }
            
    }
    
}