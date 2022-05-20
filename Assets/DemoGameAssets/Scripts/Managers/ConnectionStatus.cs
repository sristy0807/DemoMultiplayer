using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ConnectionStatus : MonoBehaviour
{
    public static ConnectionStatus instance;

    public Text connectionStatusText;

    public void ShowConnectionStatus(string message)
    {
        connectionStatusText.text = message;
    }

    private void Start()
    {
        instance = this;
    }

}
