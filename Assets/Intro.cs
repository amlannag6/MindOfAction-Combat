using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
	public Image intro ;
	void Start()
	{
		intro = GetComponent<Image>();
		intro.CrossFadeAlpha(0f, 0f, false);
		StartCoroutine(FadeImage());
	}

	IEnumerator FadeImage()
	{
		intro.CrossFadeAlpha(1f, 1.5f, false);
		yield return new WaitForSeconds(2.5f);
		intro.CrossFadeAlpha(0f, 1.5f, false);
		yield return new WaitForSeconds(1.5f);
		SceneManager.LoadScene("lvl1");
	}

}







	