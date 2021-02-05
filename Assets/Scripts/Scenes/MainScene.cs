using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
    public void OnCreateGame()
    {
        SceneManager.LoadScene(Scenes.CREATE_GAME_SCENE, LoadSceneMode.Single);
    }

    public void OnSearchGame()
    {
        SceneManager.LoadScene(Scenes.SEARCH_GAME_SCENE, LoadSceneMode.Single);
    }

    public void OnSettings()
    {
        SceneManager.LoadScene(Scenes.SETTINGS_SCENE, LoadSceneMode.Single);
    }
}
