using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGravity : MonoBehaviour {
	// Update is called once per frame
	void FixedUpdate () {

        GetComponent<Rigidbody>().AddForce(Physics.gravity, ForceMode.Acceleration);
		
	}
}
