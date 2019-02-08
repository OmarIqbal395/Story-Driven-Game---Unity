using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour 
{
	 public CharacterController controller;
 	 public float moveSpeed = 100.0f;
	 private float yRotation;
 
    // Use this for initialization
    void Start () {
    	controller = GetComponent<CharacterController>();
    }
 
    // Update is called once per frame
    void Update () {
 		yRotation = controller.transform.eulerAngles.y;

 		

        if (Input.GetKey ("w") || Input.GetKey(KeyCode.UpArrow)) {
			if(yRotation == -90.0f){

			}else{
					transform.rotation = Quaternion.Euler(0, -90, 0);
			}

			
            
        }
        if (Input.GetKey ("s") || Input.GetKey(KeyCode.DownArrow)) {
			if(yRotation == 90.0f){

			}else{
				transform.rotation = Quaternion.Euler(0, 90, 0);
			}
            
        }
        if (Input.GetKey ("a") || Input.GetKey(KeyCode.LeftArrow)) {
			if(yRotation == 180.0f){

			}else{
				transform.rotation = Quaternion.Euler(0, 180, 0);
			}
            
        }
        if (Input.GetKey ("d") || Input.GetKey(KeyCode.RightArrow)) {
			if(yRotation == 0.0f){

			}else{
				transform.rotation = Quaternion.Euler(0, 0, 0);
			}
            
        }
}
}
