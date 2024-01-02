using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    private static MainMenuManager instance;

    private void Awake() => instance = this;

    public void CreateLobby()
    {
        BootsrapManager.CreateLobby();
    }
}
