using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LivingRoomExit : MonoBehaviour {


	IEnumerator OnTriggerEnter(Collider other){
		if(hasKey.gotit){
			yield return new WaitForSeconds(1);
        	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}
