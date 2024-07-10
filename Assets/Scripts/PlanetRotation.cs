using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Rigidbody sun;

    public Rigidbody mercury;
    public Rigidbody venus;
    public Rigidbody earth;
    public Rigidbody mars;
    public Rigidbody jupiter;
    public Rigidbody saturn;
    public Rigidbody uranus; 
    public Rigidbody neptune;

    public float mercurySpeed = 100f; 
    public float venusSpeed = 61f;
    public float earthSpeed = 47f;
    public float marsSpeed = 35f;
    public float jupiterSpeed = 12f;
    public float saturnSpeed = 8f;
    public float uranusSpeed = 5f;
    public float neptuneSpeed = 3f;

    void Start()
    {
        mercury.velocity = new Vector3(0, 0, mercurySpeed);
        venus.velocity = Vector3.up * venusSpeed;
        // earth.velocity = new Vector3(0, 0, earthSpeed);
        mars.velocity = Vector3.up * marsSpeed;
        jupiter.velocity = Vector3.up * jupiterSpeed;
        saturn.velocity = Vector3.up * saturnSpeed;
        uranus.velocity = Vector3.up * uranusSpeed;
        neptune.velocity = Vector3.up * neptuneSpeed;
    }

    /*void TryUpdate()
    {
        if (sun == null)
        {
            Debug.LogError("Sun reference not assigned to PlanetRotation script on " + gameObject.name);
            return;
        }

        mercury.RotateAround(sun.position, Vector3.up, mercurySpeed * Time.deltaTime);
        venus.RotateAround(sun.position, Vector3.up, venusSpeed * Time.deltaTime);
        earth.RotateAround(sun.position, Vector3.up, earthSpeed * Time.deltaTime);
        mars.RotateAround(sun.position, Vector3.up, marsSpeed * Time.deltaTime);
        jupiter.RotateAround(sun.position, Vector3.up, jupiterSpeed * Time.deltaTime);
        saturn.RotateAround(sun.position, Vector3.up, saturnSpeed * Time.deltaTime);
        uranus.RotateAround(sun.position, Vector3.up, uranusSpeed * Time.deltaTime);
        neptune.RotateAround(sun.position, Vector3.up, neptuneSpeed * Time.deltaTime);
    }*/
}