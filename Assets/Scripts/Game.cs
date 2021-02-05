using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Game : ScriptableObject
{
    public string gameName;
    public string code;
    public GameType gameType;
    public GameFormat gameFormat;
    public int players;
    public GameSize gameSize;
    public string ip;
    public int timeout; // In seconds
}
