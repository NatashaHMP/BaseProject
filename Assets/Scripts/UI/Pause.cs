using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour 
{
    private bool stopGame;

    private void Start()
    {
        LoadResources();
    }

    private void LoadResources()
    {
        stopGame = false;
    }

    public void StopGame()
    {
        if (stopGame)
        {
            stopGame = false;
        }
        else
        {
            stopGame = true;
        }
    }

    private void Update()
    {
        CheckGamePaused();
    }

    private void CheckGamePaused()
    {
        if(stopGame)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
