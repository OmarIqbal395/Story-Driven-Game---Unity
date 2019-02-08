using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBangingEvent : MonoBehaviour {



	static AudioSource audioSrc;
	public static bool isPlaying;


	void Start () {
		audioSrc = GetComponent<AudioSource>();
		StartCoroutine(waiter());
		
	}

	IEnumerator waiter(){
   		yield return new WaitForSeconds(10);
		isPlaying = true;
		audioSrc.Play();
	}	
	
 
}
