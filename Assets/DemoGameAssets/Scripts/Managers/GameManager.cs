using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    public GameObject PlayerPrefab;
    public int MaxPlayers;

    private int whoseTurn;

    public GameObject[] Players;
    public GameObject[] NewTurnButtons;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        StartGame();
    }

    public void StartGame()
    {
        GeneratePlayers();
        InitializeTurn();
    }

    private void InitializeTurn()
    {
        whoseTurn = 0;
        NewTurnButtons[whoseTurn].GetComponent<Button>().interactable = true;
        NewTurnButtons[1].GetComponent<Button>().interactable = false;
    }

    public void GeneratePlayers()
    {
        Players = new GameObject[MaxPlayers];

        for (int i = 0; i < MaxPlayers; i++)
        {
           
            GameObject newPlayer = Instantiate(PlayerPrefab);
            
            Players[i] = newPlayer;
      
            Players[i].GetComponent<PlayerController>().thisPlayerName = "player" + i;
           
        }
    }

    public void CurrentPlayersTurn()
    {
        Players[whoseTurn].GetComponent<PlayerController>().OnTabNewTurn();
        UIManager.instance.UpdateScore(whoseTurn);
        UpdateNewTurn();
    }

    private void UpdateNewTurn()
    {
        NewTurnButtons[whoseTurn].GetComponent<Button>().interactable = false;

        if (whoseTurn == 0)
        {
            whoseTurn = 1;
        }
        else
        {
            whoseTurn = 0;
        }
        NewTurnButtons[whoseTurn].GetComponent<Button>().interactable = true;
    }

    public void GameWon(string wName) {
        for(int i = 0; i < NewTurnButtons.Length; i++)
        {
            NewTurnButtons[i].GetComponent<Button>().interactable = false;
        }

        UIManager.instance.GameResultShow(wName);
    }

    private void Start()
    {
       
    }
}
