﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
  public void ExitThisGame()
    {
        UnityEngine.Debug.LogError("Exit Game");
        Application.Quit();
    }
}

