using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceenManagement : MonoBehaviour
{
  
    public void play()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("lvl1");
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
