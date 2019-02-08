using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class OmarSplashFade : MonoBehaviour {
    public Image fadeImage;  // to assist with fading between scenes

	public Text splashText1;
    public Text splashText2;
    public Text splashText3;
    public Text splashText4;
    public string loadLevel;

    public AudioSource lockSound;

	IEnumerator Start()
	{
        fadeImage.canvasRenderer.SetAlpha(0.0f);
        splashText1.canvasRenderer.SetAlpha(0.0f);
        splashText2.canvasRenderer.SetAlpha(0.0f);
        splashText3.canvasRenderer.SetAlpha(0.0f);
        splashText4.canvasRenderer.SetAlpha(0.0f);
        
        // fade for first text
        FadeIn (splashText1);
		yield return new WaitForSeconds(5.0f);
		FadeOut (splashText1);
		yield return new WaitForSeconds(2.5f);

        // fade for second text
        FadeIn(splashText2);
        yield return new WaitForSeconds(4.0f);
        FadeOut(splashText2);
        yield return new WaitForSeconds(2.5f);

        // fade for third text
        FadeIn(splashText3);
        yield return new WaitForSeconds(4.0f);
        FadeOut(splashText3);
        yield return new WaitForSeconds(2.5f);


        // fade for fourth text
        FadeIn(splashText4);
        yield return new WaitForSeconds(4.0f);
        FadeOut(splashText4);
        yield return new WaitForSeconds(2.5f);
        //fadeImage.canvasRenderer.SetAlpha(1.0f);  // introduce black solid image

        SceneManager.LoadScene (loadLevel);

        //FadeOutImage(fadeImage);
	}

	void FadeIn (Text splashText)
	{
		splashText.CrossFadeAlpha (1.0f, 1.5f, false);
	}

	void FadeOut(Text splashText)
	{
		splashText.CrossFadeAlpha (0.0f, 2.5f, false);
	}

    void FadeOutImage(Image fadeSubstance)
    {
        fadeSubstance.CrossFadeAlpha(0.0f, 2.5f, false);
    }

}
