using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// TODO: Controlar esta logica de carga de datos con eventos
public class CreateGameView : MonoBehaviour
{
    [SerializeField]
    public TMP_InputField playerName;

    [SerializeField]
    public ToggleButtonsGroup gameType;

    [SerializeField]
    public TMP_Dropdown gameFormat;

    [SerializeField]
    public TMP_Dropdown players;

    [SerializeField]
    public TMP_Dropdown gameSize;

    [SerializeField]
    public Button createButton;

    private void Start()
    {
        createButton.onClick.AddListener(this.OnCreateButton);
    }

    public void UpdatePlayerName(string name)
    {
        playerName.text = name;
    }

    public void UpdateGameType (GameType gameType)
    {
        this.gameType.SetActiveButton((int) gameType);
    }

    public void UpdateGameFormat(GameFormat gameFormat)
    {
        this.gameFormat.value = (int) gameFormat;
    }

    public void UpdatePlayers(int players)
    {
        this.players.value = players;
    }

    public void UpdateSize (GameSize gameSize)
    {
        this.gameSize.value = (int) gameSize;
    }

    public void OnCreateButton ()
    {

    }
}
