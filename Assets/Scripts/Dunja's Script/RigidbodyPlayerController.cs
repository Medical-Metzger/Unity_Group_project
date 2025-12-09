using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

// I used this script following a youtube guidance on rigidbody player controllers using unity's input system
// https://www.youtube.com/watch?v=1LtePgzeqjQ&t=929s 
public class RigidbodyPlayerController : MonoBehaviour
{
    public Rigidbody rb; // player
    public GameObject camHolder; // empty game obj where camera is stored for fps 
    public float speed;
    public float sensitivity; 
    public float maxForce;
    private Vector2 move, look; // stores x and y components together as a 2D value, and its easier for functions like movement
    private float lookRotation; // to keep track of current look rotation

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        look = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        // Find target velocity
        Vector3 currentVelocity = rb.linearVelocity; 
        Vector3 targetVelocity = new Vector3(move.x, 0, move.y); // takes the input and turns it into a vector to help move the player
        targetVelocity *= speed;

        // Align direction so player always moves in correct direction
        targetVelocity = transform.TransformDirection(targetVelocity);

        // Calculate forces
        Vector3 velocityChange = (targetVelocity - currentVelocity);
        velocityChange = new Vector3(velocityChange.x, 0, velocityChange.z);

        // Limits force on player for safety
        Vector3.ClampMagnitude(velocityChange, maxForce);

        // Add force to rigidbody
        rb.AddForce(velocityChange, ForceMode.VelocityChange); // instant velocity change to player
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void LateUpdate()
    {
        // Turn body horizontally
        transform.Rotate(Vector3.up * look.x * sensitivity);

        // Look up and down
        lookRotation += (-look.y * sensitivity); // flips mouse input because by default its inverted
        lookRotation = Mathf.Clamp(lookRotation, -90f, 90f); // makes it so that player is restricted how far up and down they can rotate and look when moving the mouse
        camHolder.transform.eulerAngles = new Vector3(lookRotation, camHolder.transform.eulerAngles.y, camHolder.transform.eulerAngles.z);
    }

}
