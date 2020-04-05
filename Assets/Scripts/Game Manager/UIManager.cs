using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    [SerializeField]
    TextMeshProUGUI kill_counter;
    [HideInInspector]
    public int killCount;
    


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UpdateKillCounterUI()
    {
        kill_counter.text = killCount.ToString();

         PlayerPrefs.SetInt("HighScore", killCount);
    }
   

}
