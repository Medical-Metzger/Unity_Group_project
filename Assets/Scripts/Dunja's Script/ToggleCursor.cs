using UnityEngine;

public class ToggleCursor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space")) //if player holds down space bar
        {
            //Debug.Log("space key is held down");
            Cursor.lockState = CursorLockMode.None; //the mouse won't be locked to the center
            Cursor.visible = true; //the cursor will be visible
        }
        else // otherwise/when space bar isn't being held down
        {
            Cursor.lockState = CursorLockMode.Locked; //the mouse will be locked to the center
            Cursor.visible = false; //cursor won't be visible
        }
        
    }
}
