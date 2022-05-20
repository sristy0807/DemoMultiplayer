using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    public string playerName;
    public int playerScore;

    public Player(string name)
    {
        playerName = name;
    }

    public void AddPlayerScore(int score)
    {
        playerScore += score;
    }
}
