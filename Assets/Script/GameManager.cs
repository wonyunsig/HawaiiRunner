using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void Quitgame()
    {
        Application.Quit();
    }
}