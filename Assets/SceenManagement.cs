using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceenManagement : MonoBehaviour
{
  
    public void play()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("lvl1");
    }

   
}
