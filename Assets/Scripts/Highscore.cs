using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Highscore : MonoBehaviour
{
    // Start is called before the first frame update
    public Text highscoreText;
    void Start()
    {
        highscoreText.text = "Highscore : " + PlayerPrefs.GetInt("HighScore");
    }

   
}
