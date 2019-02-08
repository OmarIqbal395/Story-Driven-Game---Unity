using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioOnFall : MonoBehaviour {
    public AudioSource audioData;
    private bool hasNotFallen = true;
    // Use this for initialization
    void Start () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (hasNotFallen)
        {
            if (other.gameObject.tag == "Floor")
            {
                audioData.Play();
            }
            hasNotFallen = false;
        }
    }
    // Update is called once per frame
    void Update () {
        
    }
}
