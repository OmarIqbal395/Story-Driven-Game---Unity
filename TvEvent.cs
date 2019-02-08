using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvEvent : MonoBehaviour {


	public GameObject light;
	static AudioSource audioSrc;
	


	void Start () {
		audioSrc = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
    {
        
		 if (other.tag == "Player")
    	{
			
			light.SetActive(true);
			audioSrc.Play();
			
        
    	}
       

    }
}
