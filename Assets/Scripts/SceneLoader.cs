using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void NextScene() {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex + 1);
    }

    public void StartScene() {
        SceneManager.LoadScene(0);
    }

    public void QuitGame() {
        Application.Quit();
    }

    public static void QuitGameEarly() {
        Application.Quit();
    }

    public void LoseScene() {
        
    }

    public static void WinScene() {
        SceneManager.LoadScene("Win Screen");
    }

    public void ReloadGame() {
        EasyMode.Reset();
        SceneManager.LoadScene("Easy Mode");
    }
}
