using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform sun;

    public Transform mercury;
    public Transform venus;
    public Transform earth;
    public Transform mars;
    public Transform jupiter;
    public Transform saturn;
    public Transform uranus; 
    public Transform neptune;

    public float mercurySpeed = 100f; 
    public float venusSpeed = 61f;
    public float earthSpeed = 47f;
    public float marsSpeed = 35f;
    public float jupiterSpeed = 12f;
    public float saturnSpeed = 8f;
    public float uranusSpeed = 5f;
    public float neptuneSpeed = 3f;

    void Update()
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
    }
}