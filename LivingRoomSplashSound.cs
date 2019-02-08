using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingRoomSplashSound : MonoBehaviour {
	
	
	
	
	static AudioSource audioSrc;
	


	void Start () {
		audioSrc = GetComponent<AudioSource>();
		StartCoroutine(waiter());
		
	}

	IEnumerator waiter(){
   		yield return new WaitForSeconds(8);
		audioSrc.Play();
	}
}
