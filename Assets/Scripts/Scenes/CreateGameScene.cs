using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateGameScene : MonoBehaviour
{

    [SerializeField]
    public Game game;

    [SerializeField]
    public CreateGameView createGameView;

    void Start()
    {
        createGameView.UpdatePlayerName(game.gameName);
        createGameView.UpdateGameType(game.gameType);
        createGameView.UpdateGameFormat(game.gameFormat);
        createGameView.UpdatePlayers(game.players);
        createGameView.UpdateSize(game.gameSize);
    }

    public void OnBack ()
    {
        SceneManager.LoadScene(Scenes.MAIN_SCENE, LoadSceneMode.Single);
    }

    public void OnCreateGame()
    {
        
    }
}
