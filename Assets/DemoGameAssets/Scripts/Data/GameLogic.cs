using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class GameLogic 
{
    public static int MaxScore=20;

    public static void NewTurn(Player p)
    {
        int turnScore = UnityEngine.Random.Range(1, 6);
        p.AddPlayerScore(turnScore);

    }

    public static bool GameWon(int score)
    {
        if (score >= MaxScore)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}
