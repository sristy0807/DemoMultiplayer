using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Text[] scoreTexts;
    public Text ResultText;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UpdateScore(int whoseTurn)
    {
          scoreTexts[whoseTurn].text = GameManager.instance.Players[whoseTurn].GetComponent<PlayerController>().scoreOfThisPlayer.ToString();
      
    }

    public void OnClickTurnButton()
    {
        GameManager.instance.CurrentPlayersTurn();
    }

    public void GameResultShow(string wName)
    {
        ResultText.text = wName + " Won!";
    }

    private void Start()
    {
      
    }

}
