using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private string newScene = "UIGabriel";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newScene);
    }
}