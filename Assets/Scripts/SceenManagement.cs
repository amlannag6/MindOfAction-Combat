﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceenManagement : MonoBehaviour
{
  
    public void play()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("instru");
    }
    public void multiplayer()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Multiplayer");
    }

    public void option()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("options");
    }

    public void aboutus()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("aboutus");
    }
}
