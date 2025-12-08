using UnityEngine;

public class CursorManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.None; //the mouse isnt locked to the center
        Cursor.visible = true; //cursor is visible
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

