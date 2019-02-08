using UnityEngine;

// Include the namespace required to use Unity UI
using UnityEngine.UI;

using System.Collections;

public class playerMovement : MonoBehaviour
{
    private Vector3 movement;

    public Animation anim;

    // Create public variables for player speed, and for the Text UI game objects
    public float speed;

    public CharacterController controller;
    // Create private references to the rigidbody component on the player, and the count of pick up objects picked up so far
    private Rigidbody rb;

    public Vector3 jump;
    public float jumpForce;

    public bool isGrounded;
    public float gravityScale;

    public float rotSpeed; 

    
    // At the start of the game..
    void Start()
    {

        controller = GetComponent<CharacterController>();
        // Assign the Rigidbody component to our private rb variable
        rb = GetComponent<Rigidbody>();

        jump = new Vector3(0.0f, 5.0f, 0.0f);



    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    // Each physics step..
    void FixedUpdate()
    {
        
    }

    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            rb.AddForce(jump, ForceMode.Impulse);
            
        }*/

        // Set some local float variables equal to the value of our Horizontal and Vertical Inputs
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create a Vector3 variable, and assign X and Z to feature our horizontal and vertical float variables above
        movement = new Vector3(moveHorizontal * speed, movement.y, moveVertical * speed);

        // Add a physical force to our Player rigidbody using our 'movement' Vector3 above, 
        // multiplying it by 'speed' - our public player speed that appears in the inspector
        //rb.AddForce(movement * speed);

        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            movement.y = jumpForce;
        }

        movement.y = movement.y + (Physics.gravity.y * gravityScale * Time.deltaTime);

        controller.Move(movement * Time.deltaTime);

        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            
            anim.Play("Walk");

        }


        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            
            anim.Play("Walk");

        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            
            anim.Play("Walk");

        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            anim.Play("Walk");

        }

        else if (!Input.anyKey)
        {
            anim.Stop();
        }


    }

}
