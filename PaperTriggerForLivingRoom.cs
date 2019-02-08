using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PaperTriggerForLivingRoom : MonoBehaviour {


	public GameObject paper;
	public static bool finishReading;
	private bool onlyonce = true;
	public bool on = false;
	public static bool status = false;
	


	void Update(){
		 if (on)
        {
			if(status == false){
				if (Input.GetKeyDown(KeyCode.E))
            	{
               	 	paper.SetActive(true);
					if(onlyonce == true){
						finishReading = true;
						onlyonce = false;
						status = true;
					}
	        	}
			}else{
				if (Input.GetKeyDown(KeyCode.E))
            	{
               	 	paper.SetActive(false);
					
						status = false;
	        	}
			}
            
        }else{
			paper.SetActive(false);
			
		}
		
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Player"){
			on = true;
			
		}
		
		
	}

	void OnTriggerExit(Collider other){
		if(other.gameObject.tag == "Player"){
			on = false;

		}
	}
}
