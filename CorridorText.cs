using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorridorText : MonoBehaviour {
	
	public Text Comment;
	private bool onlyonce;
	public GameObject light;
	// Use this for initialization
	void Start () {
		onlyonce = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	 IEnumerator OnTriggerEnter(Collider other){
        if(onlyonce == false){    
			if(other.gameObject.tag == "Comment"){
				
				Comment.enabled = true;
            	Comment.text = "Not Again... I hope they don't hear me";
             	yield return new WaitForSeconds(3);
            	Comment.enabled =false;
				onlyonce = true;
	        }
		}
		if(other.gameObject.tag == "Down"){
				
				if(light.active == false){
					Comment.enabled = true;
            		Comment.text = "I still want to turn on the light before going down...";
             		yield return new WaitForSeconds(3);
            		Comment.enabled =false;

				}
				
			
	    }
	}
}
