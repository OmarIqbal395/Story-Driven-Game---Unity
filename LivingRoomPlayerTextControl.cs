using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivingRoomPlayerTextControl : MonoBehaviour {

	public Text speech; 
	// Use this for initialization
	void Start () {
		StartCoroutine(waiter());
		
	}

	void Update(){
		
	}

	IEnumerator OnTriggerExit(Collider other){
		if(other.gameObject.tag == "Paper"){
			if(PaperTriggerForLivingRoom.finishReading == true && PaperTriggerForLivingRoom.status == false){
				speech.enabled = true;
				speech.text = "Mommy was arguing with the old neighbors over this....";
	   			yield return new WaitForSeconds(4);
				speech.enabled = false;
			}
		}
	}

	IEnumerator waiter(){
		yield return new WaitForSeconds(10);
		speech.enabled = true;
		speech.text = "!!!";
	   yield return new WaitForSeconds(3);
		speech.text = "I need to hurry";
		yield return new WaitForSeconds(3);
		speech.enabled = false;
		
	}
	
}
