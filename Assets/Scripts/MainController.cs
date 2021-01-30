using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour
{

    private string CREATE_GAME_SCENE = "CreateGame";
    private string SEARCH_GAME_SCENE = "SearchGame";
    private string SETTINGS_SCENE = "Settings";

    private void Awake()
    {
    }

    public void OnCreateGame()
    {
        SceneManager.LoadScene(CREATE_GAME_SCENE, LoadSceneMode.Single);
    }

    public void OnSearchGame()
    {
        SceneManager.LoadScene(SEARCH_GAME_SCENE, LoadSceneMode.Single);
    }

    public void OnSettings()
    {
        SceneManager.LoadScene(SETTINGS_SCENE, LoadSceneMode.Single);
    }
}
