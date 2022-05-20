using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Player ThisPlayer;
    public string thisPlayerName;

    public int scoreOfThisPlayer;

    public bool Winner;

    private void Awake()
    {
        ThisPlayer = new Player(thisPlayerName);
    }

    public void OnTabNewTurn()
    {
        
        GameLogic.NewTurn(ThisPlayer);
        scoreOfThisPlayer = ThisPlayer.playerScore;
        Winner = GameLogic.GameWon(scoreOfThisPlayer);
        if (Winner)
        {
            GameManager.instance.GameWon(thisPlayerName);
        }
    }
}
