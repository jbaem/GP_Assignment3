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
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

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
