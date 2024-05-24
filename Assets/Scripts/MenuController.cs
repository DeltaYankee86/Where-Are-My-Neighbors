using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Scenes/GameScene");
    }

    public void OpenControls()
    {
        SceneManager.LoadScene("Scenes/ControlsMenu");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Scenes/MainMenu");
    }
}
