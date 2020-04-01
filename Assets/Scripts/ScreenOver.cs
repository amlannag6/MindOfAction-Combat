using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenOver : MonoBehaviour
{
    public void Retry()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
    }
}

