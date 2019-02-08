using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorridorControlScript : MonoBehaviour {

    public Rigidbody player;
    public static CorridorControlScript instance;

    //Awake & Update function from tutorial on adding game controller https://unity3d.com/learn/tutorials/topics/2d-game-creation/adding-game-controller
    void Awake()
    {
        //If we don't currently have a game control...
        if (instance == null)
            //...set this one to be it...
            instance = this;
        //...otherwise...
        else if (instance != this)
            //...destroy this one because it is a duplicate.
            Destroy(gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if(player.position.x >= 46.0f)
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }	
	}
}
