using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public string lvl1;
    public string lvl2;
    public string lvl3;
    public string mainmenu;
    public string gameover;
    public string winscreen;

    private void Start()
    {
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(mainmenu);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(lvl1);
    }

    public void GameOver()
    {
        SceneManager.LoadScene(gameover);
    }

    public void WinScreen()
    {
        SceneManager.LoadScene(winscreen);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting...");
    }

    public void ChangeLevel()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == lvl1)
        {
            SceneManager.LoadScene(lvl2);
        }
        else if (sceneName == lvl2)
        {
            SceneManager.LoadScene(lvl3);
        }
        else if (sceneName == lvl3)
        {
            SceneManager.LoadScene(winscreen);
        }
    }
}
