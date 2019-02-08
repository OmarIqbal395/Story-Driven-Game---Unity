using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAwayText : MonoBehaviour {

    float duration = 5;
	
	
	// Update is called once per frame
	void Update () {
	    if(Time.time > duration)
        {
            Destroy(gameObject);
        }

        
	}
}
