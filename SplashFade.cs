using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SplashFade : MonoBehaviour {
	//public AudioClip doorCreak;
	public Text splashText1;
	public Text splashText2;
	public Text splashText3;
	public Text splashText4;

	public string loadLevel;

	IEnumerator Start()
	{
		splashText1.canvasRenderer.SetAlpha(0.0f);
		splashText2.canvasRenderer.SetAlpha(0.0f);
		splashText3.canvasRenderer.SetAlpha(0.0f);
		splashText4.canvasRenderer.SetAlpha(0.0f);

		FadeIn (splashText1);
		yield return new WaitForSeconds(5.0f);
		FadeOut (splashText1);
		yield return new WaitForSeconds(2.5f);

		FadeIn (splashText2);
		yield return new WaitForSeconds(5.0f);
		FadeOut (splashText2);
		yield return new WaitForSeconds(2.5f);

		FadeIn (splashText3);
		yield return new WaitForSeconds(5.0f);
		FadeOut (splashText3);
		yield return new WaitForSeconds(2.5f);

		FadeIn (splashText4);
		yield return new WaitForSeconds(5.0f);
		FadeOut (splashText4);
		yield return new WaitForSeconds(2.5f);


		SceneManager.LoadScene (loadLevel);
	}

	void FadeIn (Text splashText)
	{
		splashText.CrossFadeAlpha (1.0f, 1.5f, false);
	}

	void FadeOut(Text splashText)
	{
		splashText.CrossFadeAlpha (0.0f, 2.5f, false);
	}

}
