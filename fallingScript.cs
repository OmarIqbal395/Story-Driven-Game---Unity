using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))] //Make sure a rigidbody is attached to the falling object
public class fallingScript : MonoBehaviour
{

    public Transform player; //This creates a slot in the inspector where you can add your player
    public float maxDistance = 5f; //This can be changed in the inspector to your liking
    private Rigidbody rigidbody;
    //public AudioSource audioData;
    private bool hasFallen = false;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
    }

    void Update()
    {
        if (Vector3.Distance(player.position, transform.position) < maxDistance)
        { //transform is the object that this script is attached to
            if (!hasFallen)
            {
                rigidbody.isKinematic = false;
                rigidbody.useGravity = true;
                rigidbody.AddForce(0, 0, -5);

                //audioData = GetComponent<AudioSource>();
                //audioData.Play(5);
                
            }
        }
    }
}