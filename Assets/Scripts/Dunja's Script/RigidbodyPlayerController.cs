using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class RigidbodyPlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject camHolder;
    public float moveSpeed;
    public float sensitivity; 
    public float maxForce;
    private float moveX;
    private float moveY;
    private Vector3 moveDirection;
    private float lookX;
    private float lookY;
    private float lookRotation; //keeping track of look rotation

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        moveX = input.x;
        moveY = input.y;
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        lookX = input.x;
        lookY = input.y;
    }

    private void FixedUpdate()
    {
        Vector3 currentVelocity = rb.linearVelocity; //gets current velocity

        Vector3 moveDirection = transform.right * moveX + transform.forward * moveY; //declares movement direction

        moveDirection = moveDirection.normalized; //gives movement direction

        Vector3 targetVelocity = moveDirection * moveSpeed; //gets target velocity

        targetVelocity.y = currentVelocity.y; //keeps gravity

        Vector3 velocityChange = targetVelocity - currentVelocity; //calculates how much velocity needs to be added

        velocityChange = new Vector3(velocityChange.x, 0, velocityChange.z); //makes y axis zero so it falls back on ground instead of floating

        Vector3.ClampMagnitude(velocityChange, maxForce); //limits force

        rb.AddForce(velocityChange, ForceMode.VelocityChange); //adds force to rigidbody


    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void LateUpdate()
    {
        //Turn body horizontally
        transform.Rotate(Vector3.up * lookX * sensitivity);

        //Look up and down
        lookRotation -= lookY * sensitivity;
        lookRotation = Mathf.Clamp(lookRotation, -90f, 90f); //makes it so that player is restricted how far up and down they can rotate and look when moving the mouse
        camHolder.transform.eulerAngles = new Vector3(lookRotation,camHolder.transform.eulerAngles.y, camHolder.transform.eulerAngles.z);
    }

}
