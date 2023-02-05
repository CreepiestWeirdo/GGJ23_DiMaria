using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class ChangeScene : MonoBehaviour
{
    private readonly string MAIN_MENU = "MAIN_MENU";
    private readonly string MAIN_GAME = "MAIN_GAME";
    private readonly string CREDITS = "CREDITS";
    private readonly string OPTIONS = "OPTIONS";
    Scene currentScene;

    public static ChangeScene _instance;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //MusicManager._instance.sfxList.Clear();

        if (scene.name == MAIN_MENU)
        {     
            if(MusicManager._instance.GetMusicName() != "Intro")
            {
                MusicManager._instance.SetMusic(MusicManager._instance.IntroMusic);
            }
        //    MusicManager._instance.sfxList.Add(GameObject.Find("StartButton").GetComponent<AudioSource>());
        //    MusicManager._instance.sfxList.Add(GameObject.Find("OptionsButton").GetComponent<AudioSource>());
        //    MusicManager._instance.sfxList.Add(GameObject.Find("CreditsButton").GetComponent<AudioSource>());
        //    MusicManager._instance.sfxList.Add(GameObject.Find("ExitGameButton").GetComponent<AudioSource>());
        }

        if(scene.name == MAIN_GAME)
        {
            MusicManager._instance.SetMusic(MusicManager._instance.GameplayMusic);
        }

        //if(scene.name == CREDITS)
        //{
        //    MusicManager._instance.sfxList.Add(GameObject.Find("MainMenuButton").GetComponent<AudioSource>());
        //    MusicManager._instance.sfxList.Add(GameObject.Find("ExitButton").GetComponent<AudioSource>());
        //}

        //if(scene.name == OPTIONS)
        //{
        //    MusicManager._instance.sfxList.Add(GameObject.Find("MainMenuButton").GetComponent<AudioSource>());
        //}
    }

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
    public void Change_To_Options()
    {
        SceneManager.LoadScene(OPTIONS);
        currentScene = SceneManager.GetSceneByName(OPTIONS);
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
