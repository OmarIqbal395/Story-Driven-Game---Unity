using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KitchenControl : MonoBehaviour {

    public Rigidbody player;
    public static bool foodEaten = false;
    public Text txt;
    public static bool wrongDoor = false;

    // Use this for initialization
    void Start () {


    }

    // Update is called once per frame
    void Update () {
		if(foodEaten)
        {
            
            txt.text = "At least it's something.\nI should go to the Living Room now.";
           
        }
        if(wrongDoor)
        {
            foodEaten = false;
            txt.text = "This leads back to my room. Not this way.";
            
        }
	}

}
