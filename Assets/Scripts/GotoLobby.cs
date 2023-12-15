using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GotoLobby : MonoBehaviour
{
    public Button startButton;

    void Awake()
    {
        startButton.onClick.AddListener(OnStartButton);
    }

    void OnStartButton()
    {
        SceneManager.LoadScene("LobbyScene");
    }

    // Update is called once per frame
    void Update()
    {
    }
}
