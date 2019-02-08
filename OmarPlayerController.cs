using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class OmarPlayerController : MonoBehaviour
{
    public Animation anim;

    public string nextLevel;

    private float yRotation;
    private Vector3 movement;
    public CharacterController controller;

    public GameObject roomLight;
    public bool roomLightOn = false;

    // Create public variables for player speed, and for the Text UI game objects
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public float rotateSpeed = 3.0f;


    public Text noKeyDoorText;          //when player tries to unlock door without key
    public Text haveKeyDoorText;        //when player goes to door with key
    public Text findBallText;           //when player finds ball
    public Text findKeyText;            //when the player finds key
    private bool foundKey = false;
    public Text needToFindLightText;   //when player enters dark zone
    public Text lightOnText;
    public Text lightOffText;

    //public AudioSource idleMusic;
    public AudioSource darkZoneAudio;  //heartbeat when player is away from light   
    public AudioSource safeZoneAudio;   //heartbeat when player is near light

    void Start()
    {
        //idleMusic.Play();
    }



    void Update()
    {

        if (roomLight.active == true)
        {
            darkZoneAudio.Pause();
            //safeZoneAudio.Play();
        }


        controller = GetComponent<CharacterController>();

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create a Vector3 variable, and assign X and Z to feature our horizontal and vertical float variables above
        movement = new Vector3(moveHorizontal * speed, movement.y, moveVertical * speed);
        if (controller.isGrounded)
        {
            if (Input.GetButton("Jump"))
            {
                movement.y = jumpSpeed;
            }
        }

        movement.y -= gravity * Time.deltaTime;


        controller.Move(movement * Time.deltaTime);


        //rotate player
        yRotation = controller.transform.eulerAngles.y;


        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            if (yRotation == -180.0f)
            {

            }
            else
            {
                transform.rotation = Quaternion.Euler(0, -180, 0);
            }

            anim.Play("Walk");

        }


        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            if (yRotation == 0.0f)
            {

            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }

            anim.Play("Walk");

        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            if (yRotation == 90.0f)
            {

            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 90, 0);
            }

            anim.Play("Walk");

        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            if (yRotation == -90.0f)
            {

            }
            else
            {
                transform.rotation = Quaternion.Euler(0, -90, 0);
            }

            anim.Play("Walk");

        }

        else if (!Input.anyKey)
        {
            anim.Stop();
        }


    }



    IEnumerator OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "safe zone")
        {
            darkZoneAudio.Pause();
            //safeZoneAudio.Play();
        }
        if (col.gameObject.tag == "dark zone")
        {

            //safeZoneAudio.Pause();
            darkZoneAudio.Play();

        }
        if (col.gameObject.tag == "turn on light notification")
        {
            needToFindLightText.text = "I need to find the lights, i don't like the dark...";
            yield return new WaitForSeconds(3);
            needToFindLightText.enabled = false;
        }


        if (col.gameObject.tag == "door1 tag" && foundKey == false)
        {

            lightOffText.enabled = false;
            lightOnText.enabled = false;
            needToFindLightText.enabled = false;
            findBallText.enabled = false;
            haveKeyDoorText.enabled = false;
            findKeyText.enabled = false;

            noKeyDoorText.enabled = true;
            noKeyDoorText.text = "Hmm mom and dad must have locked the door\nI need a key...";
            yield return new WaitForSeconds(3);
            noKeyDoorText.enabled = false;
        }
        else if (col.gameObject.tag == "door1 tag" && foundKey == true)
        {


            lightOffText.enabled = false;
            lightOnText.enabled = false;
            needToFindLightText.enabled = false;
            noKeyDoorText.enabled = false;
            findBallText.enabled = false;
            findKeyText.enabled = false;

            haveKeyDoorText.enabled = true;
            haveKeyDoorText.text = "I can leave now";
            yield return new WaitForSeconds(3);
            haveKeyDoorText.enabled = false;
            SceneManager.LoadScene(nextLevel);
        }
        if (col.gameObject.tag == "Ball")
        {


            lightOffText.enabled = false;
            lightOnText.enabled = false;
            needToFindLightText.enabled = false;
            findKeyText.enabled = false;
            noKeyDoorText.enabled = false;
            haveKeyDoorText.enabled = false;

            findBallText.enabled = true;
            findBallText.text = "My favorite ball...";
            yield return new WaitForSeconds(3);
            findBallText.enabled = false;

        }
        if (col.gameObject.tag == "key")
        {


            lightOffText.enabled = false;
            lightOnText.enabled = false;
            needToFindLightText.enabled = false;
            haveKeyDoorText.enabled = false;
            noKeyDoorText.enabled = false;
            findBallText.enabled = false;

            findKeyText.enabled = true;
            foundKey = true;
            col.gameObject.SetActive(false);

            findKeyText.text = "Found a key!";
            yield return new WaitForSeconds(3);
            findKeyText.enabled = true;

        }

        if (col.gameObject.tag == "light switch" && roomLight.activeInHierarchy == false && Input.GetKeyDown(KeyCode.E))
        {


            lightOffText.enabled = false;
            findKeyText.enabled = false;
            needToFindLightText.enabled = false;
            haveKeyDoorText.enabled = false;
            noKeyDoorText.enabled = false;
            findBallText.enabled = false;

            lightOnText.enabled = true;
            lightOnText.text = "Thats much better";
            yield return new WaitForSeconds(3);
            lightOnText.enabled = true;
        }
        if (col.gameObject.tag == "light switch" && roomLight.activeInHierarchy == true && Input.GetKeyDown(KeyCode.E))
        {


            lightOnText.enabled = false;
            findKeyText.enabled = false;
            needToFindLightText.enabled = false;
            haveKeyDoorText.enabled = false;
            noKeyDoorText.enabled = false;
            findBallText.enabled = false;

            lightOffText.enabled = true;
            lightOffText.text = "I dont like that";
            yield return new WaitForSeconds(3);
            lightOffText.enabled = false;
        }




    }
}