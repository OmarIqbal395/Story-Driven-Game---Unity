using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorridorToKitchenTrigger : MonoBehaviour {
	public GameObject light;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator OnTriggerEnter(Collider other){
   		 if (light.active == true) 
    	{
        	yield return new WaitForSeconds(1);
        	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    	}

	}
}
