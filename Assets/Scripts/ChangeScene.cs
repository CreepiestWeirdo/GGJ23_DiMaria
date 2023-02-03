using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    private readonly string MAIN_MENU = "MAIN_MENU";
    private readonly string MAIN_GAME = "MAIN_GAME";
    private readonly string CREDITS = "CREDITS";
    Scene currentScene;

    public static ChangeScene _instance;

    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void Change_To_Main_Menu()
    {
        SceneManager.LoadScene(MAIN_MENU);
        currentScene = SceneManager.GetSceneByName(MAIN_MENU);
    }

    public void Change_To_Main_Game()
    {
        SceneManager.LoadScene(MAIN_GAME);
        currentScene = SceneManager.GetSceneByName(MAIN_GAME);
    }

    public void Change_To_Credits()
    {
        SceneManager.LoadScene(CREDITS);
        currentScene = SceneManager.GetSceneByName(CREDITS);
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(currentScene.name);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
