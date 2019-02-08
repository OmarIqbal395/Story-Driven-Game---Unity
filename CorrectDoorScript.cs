using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorrectDoorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (KitchenControl.foodEaten == true || KitchenControl.wrongDoor == true)
        {
            Debug.Log("door trigger works");
        	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }

    }
}
