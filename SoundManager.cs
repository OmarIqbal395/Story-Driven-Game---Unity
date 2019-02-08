using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public static AudioClip background, footSteps, tvOn, tvStatic;
	static AudioSource audioSrc;

	void Start () {
		background = Resources.Load<AudioClip>("Scary_Music_Lmao");
		tvStatic = Resources.Load<AudioClip>("tv-static-02");
		audioSrc = GetComponent<AudioSource>();

	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void PlaySound(string name){
		switch(name){
			case "background":
          	 	audioSrc.PlayOneShot(background);
         	   break;
        	case "tvStatic":
        		audioSrc.PlayOneShot(tvStatic);
            	break;
        	default:
            	break;
        }

		
		
	}

}
