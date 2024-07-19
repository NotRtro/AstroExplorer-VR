using UnityEngine;
using UnityEngine.UI;

public class CameraUIHandler : MonoBehaviour
{
    // public Image playPauseButtonImage; // Referencia a la imagen del bot�n Play/Pause
    public GameObject spherePrefab;
    private bool play = true;

    public void OnMenuButtonClick()
    {
        Debug.Log("ABRIO MEN�");
    }

    public void OnAddPlanetButtonClick()
    {
        Debug.Log("Agregar planeta");
        // Obtener la posici�n y rotaci�n de la c�mara
        Transform cameraTransform = Camera.main.transform;
        Vector3 cameraPosition = cameraTransform.position;
        Quaternion cameraRotation = cameraTransform.rotation;

        // Calcular la posici�n de instanciaci�n (2 metros frente a la c�mara)
        Vector3 spawnPosition = cameraPosition + cameraTransform.forward * 2f;

        // Instanciar la esfera
        GameObject newSphere = Instantiate(spherePrefab, spawnPosition, cameraRotation);
    }

    public void OnPlayPauseButtonClick()
    {
        // Cambiar el estado y la imagen del bot�n Play/Pause
        // ...
        Debug.Log(play ? "Pause" : "Play");
        play = !play;
    }
}
