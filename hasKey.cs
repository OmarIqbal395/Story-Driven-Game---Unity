using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hasKey : MonoBehaviour {

	public GameObject key;
	public static bool gotit = false;


	void OnTriggerEnter(Collider other){
		Destroy(key);
		gotit = true;

	}
}
